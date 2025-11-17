using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms2
{
    public partial class FDatosestudiante : Form
    {
        public FDatosestudiante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBNC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (PDFotografía.ShowDialog(this) == DialogResult.OK)

            PB.Image = new Bitmap(PDFotografía.FileName);
        }

        private void TBCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void PB_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = TBNombre.Text;
            string carrera = TBCarrera.Text;
            string numeroControl = TBNC.Text;
            Image imagen = PB.Image;

            // Validaciones
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(carrera) ||
                string.IsNullOrEmpty(numeroControl) || imagen == null)
            {
                MessageBox.Show("Por favor llena todos los campos y selecciona una imagen.");
                return;
            }

            // Crear objeto
            Estudiante est = new Estudiante(nombre, carrera, numeroControl, imagen);

            // Mostrar confirmación
            MessageBox.Show("Objeto Estudiante creado correctamente");
            MessageBox.Show(est.MostrarDatos(), "Datos del Estudiante");
        }
    }
}

 

