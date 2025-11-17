namespace Libreria
{
    public partial class Form1 : Form
    {
        List<Libro> libros = new List<Libro>();
        List<Editorial> editoriales = new List<Editorial>();
        public Form1()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatalogoLibros fCatalogolibro = new FCatalogoLibros(libros);
            fCatalogolibro.ShowDialog();
        }

        private void editorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCatalogoEditorial fCatalogoEditorial = new FCatalogoEditorial(editoriales, libros);
            fCatalogoEditorial.ShowDialog();
        }
    }
}
