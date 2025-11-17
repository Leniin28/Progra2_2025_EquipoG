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
    public partial class Form1 : Form
    {
        List<Automovil> automoviles = new List<Automovil>();
        public Form1()
        {
            InitializeComponent();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatalogoAutomovil v_catalogo_automoviles = new FCatalogoAutomovil(automoviles);
            v_catalogo_automoviles.ShowDialog();
        }
    }
}
