using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_10
{
    public class Automovil
    {
        private string nombre;
        private string color;
        private int modelo;
        private Bitmap imagen;

        public Automovil(string nombre, string color, int modelo)
        {
            this.nombre = nombre;
            this.modelo = modelo;
            this.color = color;

        }
        public string GetDatos()
        {
            string datos = nombre + ", color: " + color + ", modelo: " + modelo;
            return datos;
        }
        
        public void SetColor(string nuevoColor)
        {
            this.color = nuevoColor;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetModelo(int nuevoModelo)
        {
            this.modelo = nuevoModelo;
        }
        public int GetModelo()
        {
            return this.modelo;
        }
        public void SetImagen(Bitmap nuevaImagen)
        {
            this.imagen = nuevaImagen;
        }

        public Bitmap GetImagen()
        {
            return this.imagen;
        }
    }
}

