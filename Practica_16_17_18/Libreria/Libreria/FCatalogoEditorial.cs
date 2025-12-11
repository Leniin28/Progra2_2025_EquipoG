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
    public partial class FCatalogoEditorial : Form
    {
        List<Editorial> editoriales = new List<Editorial>();
        List<Libro> libros = new List<Libro>();
        public FCatalogoEditorial(List<Editorial> editorial, List<Libro> libros)
        {
            InitializeComponent();
            this.editoriales = editorial;
            this.libros = libros;
            MostrarEditoriales();
        }

        private void bAgregarEditorial_Click(object sender, EventArgs e)
        {
            FDatosEditorial fdatoseditorial = new FDatosEditorial(libros);
            if (fdatoseditorial.ShowDialog() == DialogResult.OK)
            {
                editoriales.Add(fdatoseditorial.editorial);
                MostrarEditoriales();
            }
        }
        public void MostrarEditoriales()
        {
            lbEditorial.Items.Clear();
            for (int i = 0; i < editoriales.Count; i++)
            {
                lbEditorial.Items.Add(editoriales[i].GetDatos());
            }
        }

        private void ModificarEditorial()
        {
            lbEditorial.Items.Clear();

            for (int i = 0; i < editoriales.Count; i++)
            {
                lbEditorial.Items.Add(editoriales[i].GetDatos());
            }
        }

        private void bListaLibros_Click(object sender, EventArgs e)
        {
            lbListaLibros.Items.Clear();
            int seleccion = lbEditorial.SelectedIndex;
            if (seleccion == -1)
            {
                MessageBox.Show("Seleccione un libro para editar");
                return;
            }
            for (int i = 0; i < editoriales[seleccion].Libros.Count; i++)
            {
                lbListaLibros.Items.Add(editoriales[seleccion].Libros[i].GetDatosCorto());
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            int seleccion = lbEditorial.SelectedIndex;
            if (seleccion == -1)
            {
                MessageBox.Show("Seleccione un libro para editar");
                return;
            }

            //editoriales[seleccion].Id_Editorial = seleccion + 1;
            //FDatosEditorial.bCrearEdit.Text = "Actualizar Editorial";
            FDatosEditorial fdatoseditorial = new FDatosEditorial(libros, editoriales[seleccion]);
            fdatoseditorial.ShowDialog();
            ModificarEditorial();
        }
    }
}
