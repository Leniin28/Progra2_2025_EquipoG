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
        List<Libro> libros;

        public FCatalogoLibros()
        {
            InitializeComponent();
            this.libros = DataManager.CargarLibros();
            MostrarLibros();
        }

        private void bAgregarLibro_Click(object sender, EventArgs e)
        {
            FDatosLibro fdatoslibro = new FDatosLibro();
            if (fdatoslibro.ShowDialog() == DialogResult.OK)
            {
                this.libros = DataManager.CargarLibros();
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
            if (libros.Count > 0)
            {
                lbLibros.SelectedIndex = 0;
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

            FDatosLibro fdatoslibro = new FDatosLibro(libros[seleccion]);

            if (fdatoslibro.ShowDialog() == DialogResult.OK)
            {
                this.libros = DataManager.CargarLibros();
            }

            ModificarLibro();
        }

        private void ModificarLibro()
        {
            MostrarLibros();
        }
    }
}