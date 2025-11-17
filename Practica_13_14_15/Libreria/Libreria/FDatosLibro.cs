using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class FDatosLibro : Form
    {
        public Libro? libro { get; set; } 

        public FDatosLibro(Libro? libro = null) 
        {
            InitializeComponent();
            this.libro = libro;
            MostrarDatos();
        }

        private void bLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitulo.Text) || string.IsNullOrWhiteSpace(tbAutor.Text))
            {
                MessageBox.Show("Título y Autor son obligatorios.", "Advertencia");
                return;
            }

            bool esNuevo = (libro == null);

            if (esNuevo)
            {
                libro = new Libro(tbTitulo.Text, tbAutor.Text, (int)nudPaginas.Value, (Bitmap?)pbImg.Image);
            }
            else
            {
                libro.Titulo = tbTitulo.Text;
                libro.Autor = tbAutor.Text;
                libro.NumPaginas = (int)nudPaginas.Value;
                libro.Portada = (Bitmap?)pbImg.Image;
            }

            if (libro != null)
            {
                if (DataManager.GuardarLibro(libro))
                {
                    MessageBox.Show(esNuevo ? "Libro guardado en la base de datos." : "Libro actualizado en la base de datos.", "Éxito");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el libro en la base de datos. Verifique la conexión.", "Error");
               
                }
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bImg_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
               
                pbImg.Image = new Bitmap(ofdImage.FileName);
            }
        }

        private void MostrarDatos()
        {
            if (libro != null)
            {
                tbTitulo.Text = libro.Titulo;
                tbAutor.Text = libro.Autor;
                nudPaginas.Value = libro.NumPaginas;
                pbImg.Image = libro.Portada;
            }
        }
    }
}