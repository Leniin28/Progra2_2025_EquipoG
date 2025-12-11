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
        public Libro libro { get; set; }
        public FDatosLibro(Libro libro = null)
        {
            InitializeComponent();
            this.libro = libro;
            MostrarDatos();
        }

        private void bLibro_Click(object sender, EventArgs e)
        {
            if (libro == null)
            {
                // 1. Crear el nuevo objeto Libro
                libro = new Libro(0, tbTitulo.Text, tbAutor.Text, (int)nudPaginas.Value, (Bitmap)pbImg.Image);

                // CORRECCIÓN PARA EVITAR EL ERROR DE CLAVE EXTERNA:
                // Asignamos un Id_Editorial válido que DEBE existir en la tabla TbEditorial.
                // Si la primera editorial que guardaste tiene el Id = 1, esto funcionará.
                // Si tienes varias editoriales, se asignará temporalmente a la primera.
                libro.Id_editorial = 1;

                // 2. Guardar en la Base de Datos
                libro.GuardarLibroBD();
            }
            else
            {
                libro.Titulo = tbTitulo.Text;
                libro.Autor = tbAutor.Text;
                libro.NumPaginas = (int)nudPaginas.Value;
                libro.Portada = (Bitmap)pbImg.Image;
                libro.ActualizarBD();
            }

            DialogResult = DialogResult.OK;
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