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
    public class Editorial
    {
        public int Id_Editorial;
        public string Nombre;
        public string Localidad;
        public int Cedula;
        public Bitmap Logo;
        public List<Libro> Libros;
        // CORRECCIÓN 1: Cadena de conexión estandarizada y corregida
        public string cadena_conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDLibreriaLibro;Integrated Security=True;TrustServerCertificate=True;";

        public Editorial(int id, string nombre, string localidad, int cedula, Bitmap logo)
        {
            this.Id_Editorial = id;
            this.Nombre = nombre;
            this.Localidad = localidad;
            this.Cedula = cedula;
            this.Logo = logo;
            Libros = new List<Libro>();
        }

        public string GetDatos()
        {
            return Nombre + ", de " + Localidad + ", Cedula: " + Cedula;
        }

        public bool AgregarLibro(Libro libro_nuevo)
        {
            // Se usa Linq para verificar si el libro ya está en la lista de la editorial.
            if (Libros.Any(l => l.Id_Libro == libro_nuevo.Id_Libro))
            {
                return false;
            }
            Libros.Add(libro_nuevo);
            return true;
        }

        public void GuardarEditorialBD()
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);

            conexion.Open();
            string query;

            SqlCommand comando;
            MemoryStream stream = new MemoryStream();
            Logo.Save(stream, Logo.RawFormat);
            byte[] Bytes = stream.GetBuffer();

            query = "INSERT INTO TbEditorial (Nombre, Localidad, Cedula, Logo) " +
                "VALUES (@nombre, @localidad, @cedula, @logo)";
            comando = new SqlCommand(query, conexion);
            comando.Parameters.Add(new SqlParameter("@nombre", Nombre));
            comando.Parameters.Add(new SqlParameter("@localidad", Localidad));
            comando.Parameters.Add(new SqlParameter("@cedula", Cedula));
            comando.Parameters.Add(new SqlParameter("@logo", (object)Bytes));

            comando.ExecuteNonQuery();
            comando.Dispose();

            query = "select @@IDENTITY as [Last Inserted Identity value];";
            comando = new SqlCommand(query, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            leer.Read();
            Id_Editorial = (int)leer.GetDecimal(0);

            conexion.Close();
        }

        public void ActualizarBD()
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);

            conexion.Open();

            string query;
            SqlCommand comando;

            MemoryStream stream = new MemoryStream();
            Logo.Save(stream, Logo.RawFormat);
            byte[] Bytes = stream.GetBuffer();

            query = "update TbEditorial set Nombre = @nombre, Localidad = @localidad, " +
                "Cedula = @cedula, Logo = @logo where Id_Editorial = @id";

            comando = new SqlCommand(query, conexion);
            comando.Parameters.Add(new SqlParameter("@nombre", Nombre));
            comando.Parameters.Add(new SqlParameter("@localidad", Localidad));
            comando.Parameters.Add(new SqlParameter("@cedula", Cedula));
            comando.Parameters.Add(new SqlParameter("@logo", (object)Bytes));
            // El parámetro ID debe ser INT.
            comando.Parameters.Add(new SqlParameter("@id", Id_Editorial));

            comando.ExecuteNonQuery();
            comando.Dispose();
            conexion.Close();
        }

        // Práctica 18: Función para asignar el ID de la editorial al libro en la BD
        public void GuardarLibroEditorialBD(int id_libro)
        {
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();

            string query;
            SqlCommand comando;

            // La lógica para añadir un libro es simplemente actualizar el Id_Editorial en la tabla TbLibro
            query = "update TbLibro set Id_Editorial = @id_editorial where Id_Libro = @id_libro";

            comando = new SqlCommand(query, conexion);
            comando.Parameters.Add(new SqlParameter("@id_editorial", Id_Editorial));
            // El parámetro ID debe ser INT.
            comando.Parameters.Add(new SqlParameter("@id_libro", id_libro));

            comando.ExecuteNonQuery();
            comando.Dispose();
            conexion.Close();
        }
    }
}