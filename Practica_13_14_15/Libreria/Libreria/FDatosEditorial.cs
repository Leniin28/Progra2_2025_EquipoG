using Libreria;
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
    public partial class FDatosEditorial : Form
    {
        public Editorial? editorial;
        public List<Libro> libros;


        public FDatosEditorial(List<Libro> librosIniciales, Editorial? editorial = null)
        {
            InitializeComponent();

            this.libros = librosIniciales;

            this.editorial = editorial;

            Desplegar_librosCB(this.libros);
            MostrarDatos();


            bEditorial.Text = (editorial == null) ? "Guardar" : "Actualizar";
        }

       
        public FDatosEditorial(Editorial? editorial = null)
        {
            InitializeComponent();
            this.libros = DataManager.CargarLibros();
            this.editorial = editorial;
            Desplegar_librosCB(this.libros);
            MostrarDatos();
            bEditorial.Text = (editorial == null) ? "Guardar" : "Actualizar";
        }


        public void Desplegar_librosCB(List<Libro> libros)
        {
            cbLibros.Items.Clear();

            for (int i = 0; i < libros.Count; i++)
            {
                cbLibros.Items.Add(libros[i]);
            }
        }


        private void bEditorial_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("El nombre de la editorial es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editorial == null)
            {
                editorial = new Editorial(
                    tbNombre.Text,
                    tbLocalidad.Text,
                    (int)nudCedula.Value,
                    (Bitmap?)pbLogo.Image 
                );
            }
            else
            {
              
                editorial.Nombre = tbNombre.Text;
                editorial.Localidad = tbLocalidad.Text;
                editorial.Cedula = (int)nudCedula.Value;
                editorial.Logo = (Bitmap?)pbLogo.Image;
              
            }

       
            bool exito = false;

            if (bEditorial.Text == "Guardar")
            {
                exito = DataManager.GuardarEditorial(editorial);
            }
            else 
            {
               
                MessageBox.Show("La función de Actualizar (UPDATE) aún no está implementada en DataManager.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }


            if (exito)
            {
                MessageBox.Show($"Editorial '{editorial.Nombre}' guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bLogo_Click(object sender, EventArgs e)
        {
            if (ofdLogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbLogo.Image = new Bitmap(ofdLogo.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error");
                }
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
            
            if (editorial == null)
            {
                MessageBox.Show("Primero debes completar los datos y guardar la editorial para empezar a agregar libros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbLibros.SelectedItem is Libro libroSeleccionado)
            {
                if (editorial.AgregarLibro(libroSeleccionado))
                {
                    MessageBox.Show($"Libro '{libroSeleccionado.Titulo}' agregado a la editorial.", "Éxito");
                    cbLibros.SelectedItem = null;
                   
                }
                else
                {
                    MessageBox.Show("Libro no agregado (posiblemente ya existe).", "Error");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro de la lista.", "Advertencia");
            }
        }
    }
}