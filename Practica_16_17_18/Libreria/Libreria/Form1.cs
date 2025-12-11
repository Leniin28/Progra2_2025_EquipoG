using Microsoft.Data.SqlClient;
using System.Windows.Forms; // Se necesita para Form, List, etc.
using System.Collections.Generic;
using System.Drawing; // Se necesita para Bitmap

namespace Libreria
{
    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Editorial> editoriales = new List<Editorial>();
        // CORRECCIÓN 1: Cadena de conexión estandarizada y corregida
        public string cadena_conexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDLibreriaLibro;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            CargarBD();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatalogoLibros fCatalogolibro = new FCatalogoLibros(libros);
            fCatalogolibro.ShowDialog();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatalogoEditorial fCatalogoEditorial = new FCatalogoEditorial(editoriales, libros);
            fCatalogoEditorial.ShowDialog();
        }

        public void CargarBD()
        {
            // Cargar Libros
            SqlConnection conexion = new SqlConnection(cadena_conexion);
            conexion.Open();

            string query = "SELECT * FROM TbLibro";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader leer = comando.ExecuteReader();

            string titulo, autor;
            int numpaginas, id, id_editorial;
            Bitmap portada;

            while (leer.Read())
            {
                id = Convert.ToInt32(leer["Id_Libro"].ToString());
                titulo = leer["Titulo"].ToString();
                autor = leer["Autor"].ToString();
                numpaginas = Convert.ToInt32(leer["NumPaginas"].ToString());

                // Corrección: Leer Id_Editorial
                // Usamos GetOrdinal para evitar errores si la columna es DBNull, aunque la DB dice NOT NULL.
                id_editorial = Convert.ToInt32(leer["Id_Editorial"].ToString());

                byte[] portadaBits = (byte[])leer["Portada"];

                MemoryStream imgPortada = new MemoryStream(portadaBits);
                portada = new Bitmap(imgPortada);

                Libro libro = new Libro(id, titulo, autor, numpaginas, portada);
                libro.Id_editorial = id_editorial; // Asignar la Editorial leída
                libros.Add(libro);
            }
            leer.Close(); // Es importante cerrar el DataReader antes de cerrar la conexión o abrir otro.
            comando.Dispose();
            conexion.Close();
            conexion.Dispose();

            // Cargar Editoriales
            // Ya que tienes las editoriales en la clase, puedes usar la misma cadena. 
            // Para simplificar, reutilizaré la conexión, pero es más limpio cerrar y abrir una nueva.

            // Reabrir conexión para editoriales
            SqlConnection conexion_Edit = new SqlConnection(cadena_conexion);
            conexion_Edit.Open();

            string query_Edit = "SELECT * FROM TbEditorial";
            SqlCommand comando_Edit = new SqlCommand(query_Edit, conexion_Edit);

            SqlDataReader leer_Edit = comando_Edit.ExecuteReader();

            string nombre, localidad;
            // Se usa object para leer la cédula ya que podría ser NULL si la DB lo permitiera, pero si es INT, se lee directo.
            int cedula, id_edit;
            Bitmap logo;

            while (leer_Edit.Read())
            {
                id_edit = Convert.ToInt32(leer_Edit["Id_Editorial"].ToString());
                nombre = leer_Edit["Nombre"].ToString();
                localidad = leer_Edit["Localidad"].ToString();
                cedula = Convert.ToInt32(leer_Edit["Cedula"].ToString());
                byte[] logoBits = (byte[])leer_Edit["Logo"];

                MemoryStream imgLogo = new MemoryStream(logoBits);
                logo = new Bitmap(imgLogo);

                Editorial editorial = new Editorial(id_edit, nombre, localidad, cedula, logo);
                editoriales.Add(editorial);
            }
            leer_Edit.Close();
            comando_Edit.Dispose();
            conexion_Edit.Close();
            conexion_Edit.Dispose();

            // Asignar libros a editoriales después de cargar ambas listas
            foreach (var libro in libros)
            {
                var editorialAsignada = editoriales.FirstOrDefault(e => e.Id_Editorial == libro.Id_editorial);
                editorialAsignada?.Libros.Add(libro);
            }
        }
    }
}