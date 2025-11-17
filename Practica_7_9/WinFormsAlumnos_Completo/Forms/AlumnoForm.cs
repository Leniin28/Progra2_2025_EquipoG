using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsAlumnos.Models;

namespace WinFormsAlumnos
{
    public partial class AlumnoForm : Form
    {
        public Alumno Alumno { get; private set; }

        public AlumnoForm()
        {
            InitializeComponent();
            Alumno = new Alumno();
            UpdateCalificacionesList();
        }

        public AlumnoForm(Alumno alumno) : this()
        {
            if (alumno != null)
            {
                Alumno = alumno;
                txtNombre.Text = Alumno.Nombre;
                txtCarrera.Text = Alumno.Carrera;
                txtNumeroControl.Text = Alumno.NumeroControl;
                if (Alumno.Fotografia != null) pictureBoxFoto.Image = Alumno.Fotografia;
                UpdateCalificacionesList();
            }
        }

        private void btnAgregarCalificacion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCalificacion.Text.Trim(), out int cal))
            {
                if (Alumno.AgregarCalificacion(cal))
                {
                    txtCalificacion.Clear();
                    UpdateCalificacionesList();
                }
                else
                {
                    MessageBox.Show("La calificación debe estar entre 0 y 100.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Introduce un número entero para la calificación.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCalificacion_Click(object sender, EventArgs e)
        {
            if (lstCalificaciones.SelectedIndex >= 0)
            {
                int index = lstCalificaciones.SelectedIndex;
                Alumno.Calificaciones.RemoveAt(index);
                UpdateCalificacionesList();
            }
        }

        private void UpdateCalificacionesList()
        {
            lstCalificaciones.Items.Clear();
            foreach (var c in Alumno.Calificaciones)
            {
                lstCalificaciones.Items.Add(c);
            }
            lblPromedio.Text = $"Promedio: {Alumno.ObtenerPromedio():0.00}";
            lblRegular.Text = "Regular: " + (Alumno.EsRegular() ? "Sí" : "No");
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Cargar imagen en memoria para evitar bloqueo del archivo
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        var img = Image.FromStream(fs);
                        pictureBoxFoto.Image = new Bitmap(img);
                        Alumno.Fotografia = pictureBoxFoto.Image;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno.Nombre = txtNombre.Text.Trim();
            Alumno.Carrera = txtCarrera.Text.Trim();
            Alumno.NumeroControl = txtNumeroControl.Text.Trim();

            if (string.IsNullOrWhiteSpace(Alumno.Nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
