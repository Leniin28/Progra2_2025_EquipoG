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
        private List<Libro> libros;

        public FCatalogoLibros(List<Libro> libros)
        {
            InitializeComponent();
            this.libros = libros ?? new List<Libro>();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int seleccion = lbLibros.SelectedIndex;
            if (seleccion == -1)
            {
                MessageBox.Show("Seleccione un libro para editar.");
                return;
            }

            FDatosLibro fdatoslibro = new FDatosLibro(libros[seleccion]);
            if (fdatoslibro.ShowDialog() == DialogResult.OK)
            {
                // El objeto libro fue modificado por referencia en el formulario de edición
                MostrarLibros();
            }
        }

        public void MostrarLibros()
            {
                try
                {
                    if (lbLibros == null)
                    {
                        MessageBox.Show("Control lbLibros no encontrado. Verifica el nombre en el diseñador.");
                        return;
                    }

                    lbLibros.Items.Clear();

                    if (libros == null || libros.Count == 0)
                        return;

                    foreach (var libro in libros)
                        if (libro != null)
                            lbLibros.Items.Add(libro.GetDatos());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en MostrarLibros(): " + ex.Message);
                }
            }
        }
    } 

