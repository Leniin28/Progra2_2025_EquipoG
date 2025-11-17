using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FDatosestudiante ventana_datos_estudiantes = new FDatosestudiante();
            ventana_datos_estudiantes.ShowDialog();
        }

        private void grupoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FDatosGrupo ventana_datos_grupo = new FDatosGrupo();
            ventana_datos_grupo.ShowDialog();
        }
    }
}
