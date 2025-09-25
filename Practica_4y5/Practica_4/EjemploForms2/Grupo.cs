using System.Drawing;

public class Grupo
{
    public string Aula { get; set; }
    public string Docente { get; set; }
    public int CantidadAlumnos { get; set; }
    public Image Imagen { get; set; }

    public Grupo(string aula, string docente, int cantidadAlumnos, Image imagen)
    {
        Aula = aula;
        Docente = docente;
        CantidadAlumnos = cantidadAlumnos;
        Imagen = imagen;
    }

    public string MostrarDatos()
    {
        return $"Aula: {Aula}\nDocente: {Docente}\nCantidad de Alumnos: {CantidadAlumnos}";
    }
}