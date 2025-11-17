using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text.Json; 
using System.Linq;

namespace Libreria
{
    public static class DataManager
    {
        private const string ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BDLibrosYEditoriales;Integrated Security=True;Connect Timeout=30";

       
        private static byte[]? ImageToByteArray(Bitmap? image)
        {
            if (image == null) return null;
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private static Bitmap? ByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;
            try
            {
                using (MemoryStream stream = new MemoryStream(byteArray))
                {
                    return new Bitmap(stream);
                }
            }
            catch { return null; }
        }

        

        public static bool GuardarLibro(Libro libro)
        {
            string query = "INSERT INTO dbo.TbLibros (Titulo, Autor, Paginas, Imagen) VALUES (@Titulo, @Autor, @Paginas, @Imagen)";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@Titulo", libro.Titulo);
                        command.Parameters.AddWithValue("@Autor", libro.Autor);
                        command.Parameters.AddWithValue("@Paginas", libro.NumPaginas);

                        byte[]? imagenBytes = ImageToByteArray(libro.Portada);

                        if (imagenBytes != null)
                        {
                            command.Parameters.AddWithValue("@Imagen", imagenBytes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Imagen", DBNull.Value);
                        }

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro en la base de datos: " + ex.Message, "Error de DB");
                return false;
            }
        }

        public static List<Libro> CargarLibros()
        {
            List<Libro> librosCargados = new List<Libro>();
            string query = "SELECT Titulo, Autor, Paginas, Imagen FROM dbo.TbLibros";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string titulo = reader.GetString(0);
                                string autor = reader.GetString(1);

                                int paginas = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);

                                Bitmap? portada = null;
                                if (!reader.IsDBNull(3))
                                {
                                    byte[]? imagenBytes = (byte[])reader.GetValue(3);
                                    portada = ByteArrayToImage(imagenBytes);
                                }

                                Libro libro = new Libro(titulo, autor, paginas, portada);
                                librosCargados.Add(libro);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros de la base de datos: " + ex.Message, "Error de Carga");
            }

            return librosCargados;
        }


        public static bool GuardarEditorial(Editorial editorial)
        {
            string query = "INSERT INTO dbo.TbEditorial (Nombre, Localidad, Cedula, Imagen, Libros) VALUES (@Nombre, @Localidad, @Cedula, @Imagen, @Libros)";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@Nombre", editorial.Nombre);
                        command.Parameters.AddWithValue("@Localidad", editorial.Localidad);
                        command.Parameters.AddWithValue("@Cedula", editorial.Cedula);

                        byte[]? imagenBytes = ImageToByteArray(editorial.Logo);
                        if (imagenBytes != null)
                        {
                            command.Parameters.AddWithValue("@Imagen", imagenBytes);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Imagen", DBNull.Value);
                        }

                        string librosJson = JsonSerializer.Serialize(editorial.Libros);
                        command.Parameters.AddWithValue("@Libros", librosJson);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la editorial en la base de datos: " + ex.Message, "Error de DB");
                return false;
            }
        }

        public static List<Editorial> CargarEditoriales()
        {
            List<Editorial> editorialesCargadas = new List<Editorial>();
            string query = "SELECT Nombre, Localidad, Cedula, Imagen, Libros FROM dbo.TbEditorial";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombre = reader.GetString(0);
                                string localidad = reader.GetString(1);
                                int cedula = reader.GetInt32(2);

                                Bitmap? logo = null;
                                if (!reader.IsDBNull(3))
                                {
                                    byte[]? imagenBytes = (byte[])reader.GetValue(3);
                                    logo = ByteArrayToImage(imagenBytes);
                                }

                                List<Libro> libros = new List<Libro>();
                                if (!reader.IsDBNull(4))
                                {
                                    string librosJson = reader.GetString(4);
                                    var deserializedLibros = JsonSerializer.Deserialize<List<Libro>>(librosJson);
                                    if (deserializedLibros != null)
                                    {
                                        
                                        libros = deserializedLibros;
                                    }
                                }

                                Editorial editorial = new Editorial(nombre, localidad, cedula, logo);
                                editorial.Libros = libros;
                                editorialesCargadas.Add(editorial);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las editoriales de la base de datos: " + ex.Message, "Error de Carga");
            }

            return editorialesCargadas;
        }
    }
}