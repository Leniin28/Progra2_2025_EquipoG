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
        public Libro libro { get; private set; }
        public FDatosLibro()
        {
            InitializeComponent();
            libro = new Libro();
        
    }
        public FDatosLibro( Libro libroExistente)
        {
            InitializeComponent();
            libro = libroExistente;

            tbTitulo.Text = libro.Titulo;
            tbAutor.Text = libro.Autor;
            nudPaginas.Text = libro.NumPaginas.ToString();
            if (libro.Portada != null)
                pbImg.Image = libro.Portada;
        }

        private void bLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitulo.Text) || string.IsNullOrWhiteSpace(tbAutor.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Título y Autor).");
                return;
            }

            int paginas;
            if (!int.TryParse(nudPaginas.Text, out paginas))
            {
                MessageBox.Show("Ingrese un número válido de páginas.");
                return;
            }

            libro.Titulo = tbTitulo.Text;
            libro.Autor = tbAutor.Text;
            libro.NumPaginas = paginas;
            libro.Portada = pbImg.Image != null ? new Bitmap(pbImg.Image) : null;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImg.Image = new Bitmap(ofd.FileName);
                }
            }
            }
    }
}
