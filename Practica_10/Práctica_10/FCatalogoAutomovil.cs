using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_10
{
    public partial class FCatalogoAutomovil : Form
    {
        List<Automovil> automoviles = new List<Automovil>();
        public FCatalogoAutomovil(List<Automovil> automoviles)
        {
            InitializeComponent();
            this.automoviles = automoviles;
            DesplegarAutomovilesEnListBox();
        }

        private void BAgregarAutomovil_Click(object sender, EventArgs e)
        {
            FDatosAutomovil v_datos_automovil = new FDatosAutomovil();
            if (v_datos_automovil.ShowDialog() == DialogResult.OK)
            {
                automoviles.Add(v_datos_automovil.Automovil);

                DesplegarAutomovilesEnListBox();
            }
        }

        private void DesplegarAutomovilesEnListBox()
        {
            LBAutomovil.Items.Clear();
            for (int i = 0; i < automoviles.Count; i++)
            {
                LBAutomovil.Items.Add(automoviles[i].GetDatos());
            }
        }
    }
}
