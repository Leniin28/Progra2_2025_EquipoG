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
        public FCatalogoEditorial(List<Editorial> lista, List<Libro> libros)
        {
            InitializeComponent();
            this.editoriales = lista;
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

        private void button1_Click(object sender, EventArgs e)
        {
                int seleccion = lbEditorial.SelectedIndex;
                if (seleccion == -1)
                {
                    MessageBox.Show("Seleccione un libro para editar");
                    return;
                }

                FDatosEditorial fdatoseditorial = new FDatosEditorial(libros, editoriales[seleccion]);
                fdatoseditorial.ShowDialog();
                ModificarEditorial();
            }

            private void ModificarEditorial()
            {
                lbEditorial.Items.Clear();

                for (int i = 0; i < editoriales.Count; i++)
                {
                    lbEditorial.Items.Add(editoriales[i].GetDatos());
                }
            }
        }
    }

