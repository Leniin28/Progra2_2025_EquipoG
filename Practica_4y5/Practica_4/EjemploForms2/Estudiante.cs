using System.Drawing;

public class Estudiante
{
    public string Nombre { get; set; }
    public string Carrera { get; set; }
    public string NumeroControl { get; set; }
    public Image Imagen { get; set; }

    public Estudiante(string nombre, string carrera, string numeroControl, Image imagen)
    {
        Nombre = nombre;
        Carrera = carrera;
        NumeroControl = numeroControl;
        Imagen = imagen;
    }

    public string MostrarDatos()
    {
        return $"Nombre: {Nombre}\nCarrera: {Carrera}\nNúmero de Control: {NumeroControl}";
    }
}
