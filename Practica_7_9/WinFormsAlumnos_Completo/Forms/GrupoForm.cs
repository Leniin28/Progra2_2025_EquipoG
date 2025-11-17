using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsAlumnos.Models;

namespace WinFormsAlumnos
{
    public partial class GrupoForm : Form
    {
        private Grupo grupo;

        public GrupoForm(Grupo grupo)
        {
            InitializeComponent();
            this.grupo = grupo ?? new Grupo();
            RefreshUI();
        }

        private void RefreshUI()
        {
            lblPromedio.Text = $"Promedio Grupo: {grupo.PromedioGrupo():0.00}";
            lblReprobadas.Text = $"Total reprobadas: {grupo.TotalReprobadas()}";
            lstRegulares.Items.Clear();
            lstIrregulares.Items.Clear();
            foreach (var r in grupo.EstudiantesRegulares())
            {
                lstRegulares.Items.Add($"{r.Nombre} ({r.ObtenerPromedio():0.00})");
            }
            foreach (var i in grupo.EstudiantesIrregulares())
            {
                lstIrregulares.Items.Add($"{i.Nombre} ({i.ObtenerPromedio():0.00})");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }
    }
}
