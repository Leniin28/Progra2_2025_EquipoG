using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno
{
    public partial class Form1 : Form
    {
        private Alumno alumnoActual;

        public Form1()
        {
            InitializeComponent();
            alumnoActual = new Alumno();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorDeArchivo = new OpenFileDialog();

            selectorDeArchivo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            selectorDeArchivo.Title = "Selecciona una fotografía";

            if (selectorDeArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbxImagenAlumno.Image = Image.FromFile(selectorDeArchivo.FileName);
                    alumnoActual.Fotografia = pbxImagenAlumno.Image; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarCalificacion_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un valor numérico
            if (int.TryParse(txtCalificacion.Text, out int calificacion))
            {
                // Agregar la calificación al objeto Alumno si es válida
                if (alumnoActual.AgregarCalificacion(calificacion))
                {
                    // Mostrar la calificación en la ListBox
                    lstCalificaciones.Items.Add(calificacion);
                    
                    txtCalificacion.Value = 0;
                }
                else
                {
                    MessageBox.Show("La calificación debe estar entre 0 y 100.", "Error de Calificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para la calificación.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            alumnoActual.Nombre = txtNombre.Text;
            alumnoActual.Carrera = txtCarrera.Text;
            alumnoActual.NumeroDeControl = txtNumControl.Text;

            // Calcular y mostrar el promedio
            double promedio = alumnoActual.ObtenerPromedio();
            lblPromedio.Text = $"Promedio: {promedio:F2}";

            // Determinar y mostrar el estatus
            string estatus = alumnoActual.EsRegular() ? "Regular ✅" : "Irregular ❌";
            lblEstatus.Text = $"Estatus: {estatus}";

            MessageBox.Show("Cálculos realizados. Revisa el promedio y el estatus.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Asignamos los valores de los controles al objeto
            alumnoActual.Nombre = txtNombre.Text;
            alumnoActual.Carrera = txtCarrera.Text;
            alumnoActual.NumeroDeControl = txtNumControl.Text;
            alumnoActual.Fotografia = pbxImagenAlumno.Image;

            MessageBox.Show("¡Alumno guardado correctamente!");
        }

        private void lstCalificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Alumno
    {
        // Propiedades del Alumno
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string NumeroDeControl { get; set; }
        public Image Fotografia { get; set; }
        public List<int> Calificaciones { get; private set; }

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
            if (Calificaciones.Count == 0)
            {
                return 0;
            }
            return Calificaciones.Average();
        }

        public bool EsRegular(int calificacionMinimaAprobatoria = 70)
        {
            if (Calificaciones.Count == 0)
            {
                return false;
            }
            return Calificaciones.All(cal => cal >= calificacionMinimaAprobatoria);
        }
    }
}