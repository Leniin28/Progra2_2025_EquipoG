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
        List<Libro> libros;
        public FDatosEditorial(List<Libro> libro, Editorial editorial = null)
        {
            InitializeComponent();
            this.libros = libro;
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
            editorial = new Editorial(tbNombre.Text, tbLocalidad.Text, (int)nudCedula.Value, (Bitmap)pbLogo.Image);
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

        private void cbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
