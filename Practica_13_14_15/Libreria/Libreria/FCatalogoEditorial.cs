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
    public partial class FCatalogoEditorial : Form
    {
        List<Editorial> editoriales;
        
        List<Libro> libros;

        public FCatalogoEditorial(List<Editorial> editorial, List<Libro> libros)
        {
            InitializeComponent();

            this.editoriales = DataManager.CargarEditoriales();

            this.libros = DataManager.CargarLibros();

            MostrarEditoriales();
        }

        private void bAgregarEditorial_Click(object sender, EventArgs e)
        {
            FDatosEditorial fdatoseditorial = new FDatosEditorial();

            if (fdatoseditorial.ShowDialog() == DialogResult.OK)
            {
                RecargarDatosYMostrar();
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            int seleccion = lbEditorial.SelectedIndex;
            if (seleccion == -1)
            {
                MessageBox.Show("Seleccione una editorial para editar");
                return;
            }

           
            FDatosEditorial fdatoseditorial = new FDatosEditorial(editoriales[seleccion]);

            if (fdatoseditorial.ShowDialog() == DialogResult.OK)
            {
                RecargarDatosYMostrar();
            }
        }

        private void RecargarDatosYMostrar()
        {
            
            this.editoriales = DataManager.CargarEditoriales();
            this.libros = DataManager.CargarLibros();
            MostrarEditoriales();
        }

        public void MostrarEditoriales()
        {
            lbEditorial.Items.Clear();
            for (int i = 0; i < editoriales.Count; i++)
            {
      
                lbEditorial.Items.Add(editoriales[i].GetDatos());
            }
            if (editoriales.Count > 0)
            {
                lbEditorial.SelectedIndex = 0;
            }
        }

        private void ModificarEditorial()
        {
            MostrarEditoriales();
        }
    }
}