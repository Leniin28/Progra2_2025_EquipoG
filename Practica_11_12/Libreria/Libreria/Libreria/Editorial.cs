using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Editorial
    {
        public string Nombre;
        public string Localidad;
        public int Cedula;
        public Bitmap Logo;
        public List<Libro> Libros;

        public Editorial(string nombre, string localidad, int cedula, Bitmap logo) 
        {
            this.Nombre = nombre;
            this.Localidad = localidad;
            this.Cedula = cedula;
            this.Logo = logo;
            Libros = new List<Libro>();
        }
        public string GetDatos() 
        {
            return Nombre + ", de " + Localidad + ", Cedula " + Cedula;
        }
    }
}
