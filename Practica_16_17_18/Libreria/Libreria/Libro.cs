using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {
        public int Id_Libro;
        public string Titulo;
        public string Autor;
        public int NumPaginas;
        public Bitmap Portada;
        public int Id_editorial;
        // CORRECCIÓN 1: Cadena de conexión estandarizada y corregida
        string cadena_conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDLibreriaLibro;Integrated Security=True;TrustServerCertificate=True;";

        public Libro(int id, string titulo, string autor, int paginas, Bitmap img)
        {
            this.Id_Libro = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.NumPaginas = paginas;
            this.Portada = img;
            // Al crear un libro, Id_editorial se queda en 0 por defecto.
            // Para que el INSERT funcione (si la DB requiere NOT NULL), la lógica de negocio debe asignar un ID válido antes de GuardarLibroBD().
        }

        public string GetDatos()
        {
            string datos = Titulo + ", por: " + Autor + ", con " + NumPaginas + " páginas.";
            return datos;
        }

        public string GetDatosCorto()
        {
            return Titulo + " - " + Autor;
        }

        public void GuardarLibroBD()
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);

            conexion.Open();
            string query;

            SqlCommand comando;
            MemoryStream stream = new MemoryStream();
            Portada.Save(stream, Portada.RawFormat);
            byte[] Bytes = stream.GetBuffer();

            // CORRECCIÓN 2: Se incluye Id_Editorial en el INSERT para evitar el error de NULL
            query = "INSERT INTO TbLibro (Titulo, Autor, NumPaginas, Portada, Id_Editorial)" +
                "VALUES (@titulo, @autor, @numpaginas, @portada, @id_editorial)";

            comando = new SqlCommand(query, conexion);
            comando.Parameters.Add(new SqlParameter("@titulo", Titulo));
            comando.Parameters.Add(new SqlParameter("@autor", Autor));
            comando.Parameters.Add(new SqlParameter("@numpaginas", NumPaginas));
            comando.Parameters.Add(new SqlParameter("@portada", (object)Bytes));
            // CORRECCIÓN 2.1: Se agrega el parámetro para Id_Editorial
            comando.Parameters.Add(new SqlParameter("@id_editorial", Id_editorial));

            comando.ExecuteNonQuery();
            comando.Dispose();

            // Práctica 18
            query = "select @@IDENTITY as [Last Inserted Identity value];";
            comando = new SqlCommand(query, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            Id_Libro = (int)leer.GetDecimal(0);

            conexion.Close();
        }

        public void ActualizarBD()
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);

            conexion.Open();
            string query;

            SqlCommand comando;
            MemoryStream stream = new MemoryStream();
            Portada.Save(stream, Portada.RawFormat);
            byte[] Bytes = stream.GetBuffer();

            // Incluyo Id_Editorial en el UPDATE por si se actualiza desde otra parte
            query = "update TbLibro set Titulo = @titulo, Autor = @autor, " +
                "NumPaginas = @numpaginas, Portada = @portada, Id_Editorial = @id_editorial where Id_libro = @id";
            comando = new SqlCommand(query, conexion);
            comando.Parameters.Add(new SqlParameter("@titulo", Titulo));
            comando.Parameters.Add(new SqlParameter("@autor", Autor));
            comando.Parameters.Add(new SqlParameter("@numpaginas", NumPaginas));
            comando.Parameters.Add(new SqlParameter("@portada", (object)Bytes));
            comando.Parameters.Add(new SqlParameter("@id_editorial", Id_editorial)); // Añadir parámetro de Id_Editorial
            // El parámetro ID debe ser INT, no string.
            comando.Parameters.Add(new SqlParameter("@id", Id_Libro));

            comando.ExecuteNonQuery();
            comando.Dispose();
            conexion.Close();
        }
    }
}