using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class FDatosEditorial : Form
    {
        public Editorial editorial;
        public List<Libro> libros;
        public FDatosEditorial(List<Libro> libros, Editorial editorial = null)
        {
            InitializeComponent();
            this.libros = libros;
            this.editorial = editorial;
            Desplegar_librosCB(libros);
            MostrarDatos();
        }

        public void Desplegar_librosCB(List<Libro> libros)
        {
            cbLibros.Items.Clear();
            for (int i = 0; i < libros.Count; i++)
            {
                cbLibros.Items.Add(libros[i].GetDatosCorto());
            }
        }
        private void bEditorial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bLogo_Click(object sender, EventArgs e)
        {
            if (ofdLogo.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = new Bitmap(ofdLogo.FileName);
            }
        }

        public void MostrarDatos()
        {
            if (editorial != null)
            {
                tbNombre.Text = editorial.Nombre;
                tbLocalidad.Text = editorial.Localidad;
                nudCedula.Value = editorial.Cedula;
                pbLogo.Image = editorial.Logo;
            }
        }

        private void bAgregarLibro_Click(object sender, EventArgs e)
        {
            if (cbLibros.SelectedIndex != -1)
            {
                Libro libro_seleccionado = libros[cbLibros.SelectedIndex];
                int id_libro = libro_seleccionado.Id_Libro;
                if (editorial.AgregarLibro(libro_seleccionado) == false)
                {

                    MessageBox.Show("El libro ya se encuentra en la editorial.");
                }
                else
                {
                    // Práctica 18
                    editorial.GuardarLibroEditorialBD(id_libro);
                    MessageBox.Show("Libro agregado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para agregar.");
            }
        }

        private void bCrearEdit_Click(object sender, EventArgs e)
        {
            if (editorial == null)
            {
                editorial = new Editorial(0, tbNombre.Text, tbLocalidad.Text, (int)nudCedula.Value, (Bitmap)pbLogo.Image);
                editorial.GuardarEditorialBD();
            }
            else
            {
                editorial.Nombre = tbNombre.Text;
                editorial.Localidad = tbLocalidad.Text;
                editorial.Cedula = (int)nudCedula.Value;
                editorial.Logo = (Bitmap)pbLogo.Image;
                editorial.ActualizarBD();
            }
        }
    }
}
