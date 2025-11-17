using System;
using System.Windows.Forms;
using WinFormsAlumnos.Models;

namespace WinFormsAlumnos
{
    public partial class MainForm : Form
    {
        private Grupo grupo;

        public MainForm()
        {
            InitializeComponent();
            grupo = new Grupo();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            using (var form = new AlumnoForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var alumno = form.Alumno;
                    grupo.Alumnos.Add(alumno);
                    RefreshAlumnosList();
                }
            }
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedIndex < 0) return;
            var alumno = grupo.Alumnos[lstAlumnos.SelectedIndex];
            using (var form = new AlumnoForm(alumno))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshAlumnosList();
                }
            }
        }

        private void btnAbrirGrupo_Click(object sender, EventArgs e)
        {
            using (var form = new GrupoForm(grupo))
            {
                form.ShowDialog();
            }
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            double promedio = grupo.PromedioGrupo();
            int reprobadas = grupo.TotalReprobadas();
            var regulares = grupo.EstudiantesRegulares();
            var irregulares = grupo.EstudiantesIrregulares();

            MessageBox.Show($"Promedio Grupo: {promedio:0.00}\n" +
                            $"Reprobadas Totales: {reprobadas}\n" +
                            $"Regulares: {regulares.Count}\n" +
                            $"Irregulares: {irregulares.Count}", "Información del Grupo");
        }

        private void RefreshAlumnosList()
        {
            lstAlumnos.Items.Clear();
            foreach (var a in grupo.Alumnos)
            {
                lstAlumnos.Items.Add($"{a.Nombre} - {a.NumeroControl}");
            }
        }
    }
}
