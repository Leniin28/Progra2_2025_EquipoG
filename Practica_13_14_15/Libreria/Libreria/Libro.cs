using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.Json.Serialization;

namespace Libreria
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }
        public Bitmap? Portada { get; set; } 

        [JsonConstructor]
        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            NumPaginas = 0;
            Portada = null;
        }

        public Libro(string titulo, string autor, int paginas, Bitmap? img)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.NumPaginas = paginas;
            this.Portada = img;
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

        
        public override string ToString()
        {
            return GetDatosCorto();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Libro otroLibro)
            {
                return this.Titulo.Equals(otroLibro.Titulo, StringComparison.OrdinalIgnoreCase) &&
                       this.Autor.Equals(otroLibro.Autor, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titulo.ToLowerInvariant(), Autor.ToLowerInvariant());
        }
    }
}
