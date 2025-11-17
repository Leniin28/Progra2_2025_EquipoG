using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumPaginas { get; set; }
        public Bitmap Portada { get; set; }
        public Libro() { }

        public Libro(string titulo, string autor, int paginas, Bitmap img) 
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.NumPaginas = paginas;
            this.Portada = img;
        }
        public string GetDatos() 
        {
            return $"{Titulo}, por: {Autor}, con {NumPaginas} páginas.";
        }
        public string GetDatosCorto() 
        {
            return $"{Titulo} - {Autor}";
        }
    }
}
