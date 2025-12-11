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
    public partial class FCatalogoLibros : Form
    {
        List<Libro> libros = new List<Libro>();
        public FCatalogoLibros(List<Libro> libros)
        {
            InitializeComponent();
            this.libros = libros;
            MostrarLibros();
        }

        private void bAgregarLibro_Click(object sender, EventArgs e)
        {
            FDatosLibro fdatoslibro = new FDatosLibro();
            if (fdatoslibro.ShowDialog() == DialogResult.OK)
            {
                libros.Add(fdatoslibro.libro);
                MostrarLibros();
            }
        }

        public void MostrarLibros()
        {
            lbLibros.Items.Clear();
            for (int i = 0; i < libros.Count; i++)
            {
                lbLibros.Items.Add(libros[i].GetDatos());
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            int seleccion = lbLibros.SelectedIndex;
            if (seleccion == -1) 
            {
                MessageBox.Show("Seleccione un libro para editar");
                return;
            }
            //libros[seleccion].Id_Libro = seleccion + 1;
            FDatosLibro fdatoslibro = new FDatosLibro(libros[seleccion]);
            fdatoslibro.ShowDialog();
            ModificarLibro();
        }

        private void ModificarLibro() 
        {
            lbLibros.Items.Clear();

            for (int i = 0; i < libros.Count; i++)
            {
                lbLibros.Items.Add(libros[i].GetDatos());
            }
        }
    }
}
