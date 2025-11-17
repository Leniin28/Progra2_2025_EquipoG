using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace WinFormsAlumnos.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string NumeroControl { get; set; }
        public Image Fotografia { get; set; }
        public List<int> Calificaciones { get; set; }

        public Alumno()
        {
            Calificaciones = new List<int>();
        }

        public bool AgregarCalificacion(int calificacion)
        {
            if (calificacion >= 0 && calificacion <= 100)
            {
                Calificaciones.Add(calificacion);
                return true;
            }
            return false;
        }

        public double ObtenerPromedio()
        {
            return Calificaciones.Count > 0 ? Calificaciones.Average() : 0;
        }

        public bool EsRegular()
        {
            if (Calificaciones.Count == 0) return false;
            return Calificaciones.All(c = c >= 70);
        }
    }
}
