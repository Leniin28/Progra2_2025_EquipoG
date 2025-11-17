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
    public partial class FDatosGrupo : Form
    {
        public FDatosGrupo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
               
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                try
                {
                    string aula = textBox1.Text;
                    string docente = textBox2.Text;
                    int cantidad = int.Parse(textBox3.Text);
                    Image imagen = pictureBox1.Image;

                    Grupo grupo = new Grupo(aula, docente, cantidad, imagen);

                    MessageBox.Show("Grupo creado correctamente:\n\n" +
                                    grupo.MostrarDatos(),
                                    "Confirmación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el grupo: " + ex.Message);
                }
            }
    }
}
