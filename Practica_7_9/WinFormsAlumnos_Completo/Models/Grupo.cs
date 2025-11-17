using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsAlumnos.Models
{
    public class Grupo
    {
        public List<Alumno> Alumnos { get; set; }

        public Grupo()
        {
            Alumnos = new List<Alumno>();
        }

        public double PromedioGrupo()
        {
            var todas = Alumnos.SelectMany(a => a.GetCalificaciones());
            if (!todas.Any())return 0;
            return todas.Average();
        }

        public List<Alumno> EstudiantesRegulares()
        {
            return Alumnos.Where(a => a.EsRegular()).ToList();
        }

        public List<Alumno> EstudiantesIrregulares()
        {
            return Alumnos.Where(a => !a.EsRegular()).ToList();
        }

        public int TotalReprobadas()
        {
            return Alumnos.SelectMany(a => a.Calificaciones).Count(c => c <= 60);
        }
    }
}
