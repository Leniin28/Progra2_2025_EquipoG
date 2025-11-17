using System.Collections.Generic;
using System.Drawing;

namespace Libreria
{
    

    public class Editorial
    {
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public int Cedula { get; set; }
        public Bitmap Logo { get; set; }
        public List<Libro> Libros { get; set; } 

        public Editorial(string nombre, string localidad, int cedula, Bitmap logo)
        {
            Nombre = nombre;
            Localidad = localidad;
            Cedula = cedula;
            Logo = logo;
            Libros = new List<Libro>(); 
        }

        public string GetDatos()
        {
            return $"Nombre: {Nombre}, Localidad: {Localidad}, Cédula: {Cedula}";
        }

        public bool AgregarLibro(Libro libro)
        {
            if (!Libros.Contains(libro))
            {
                Libros.Add(libro);
            
                return true;
            }
            return false;
        }
    }
}