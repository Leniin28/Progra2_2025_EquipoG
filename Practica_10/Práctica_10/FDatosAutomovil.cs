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
    public partial class FDatosAutomovil : Form
    {
        public Automovil Automovil { get; set; }
        public FDatosAutomovil()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Automovil = new Automovil(
                tbNombre.Text,
                tbColor.Text,
                (int)nudModelo.Value);

            if (pbImagen.Image != null)
            {
                Automovil.SetImagen(new Bitmap(pbImagen.Image));
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|* .jpg; .jpeg; .png; .bmp ";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            { pbImagen.Image = Image.FromFile(ofd.FileName); }
        }
    }
}
