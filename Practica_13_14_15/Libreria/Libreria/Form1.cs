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
    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Editorial> editoriales = new List<Editorial>();

        public Form1()
        {
            InitializeComponent();

            CargarBD();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FCatalogoLibros fCatalogolibro = new FCatalogoLibros();
            fCatalogolibro.ShowDialog();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FCatalogoEditorial fCatalogoEditorial = new FCatalogoEditorial(editoriales, libros);
            fCatalogoEditorial.ShowDialog();
        }

        private void CargarBD()
        {
            
        }
    }
}