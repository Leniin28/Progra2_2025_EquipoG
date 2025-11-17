namespace WinFormsAlumnos
{
    partial class AlumnoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.ListBox lstCalificaciones;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.Button btnEliminarCalificacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblRegular;
        private System.Windows.Forms.Label lblCalificaciones;

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.lstCalificaciones = new System.Windows.Forms.ListBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.btnEliminarCalificacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblRegular = new System.Windows.Forms.Label();
            this.lblCalificaciones = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();

            // Labels and textboxes
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(110, 12);
            this.txtNombre.Size = new System.Drawing.Size(260, 20);

            this.lblCarrera.Text = "Carrera:";
            this.lblCarrera.Location = new System.Drawing.Point(12, 45);
            this.lblCarrera.AutoSize = true;
            this.txtCarrera.Location = new System.Drawing.Point(110, 42);
            this.txtCarrera.Size = new System.Drawing.Size(260, 20);

            this.lblNumeroControl.Text = "Número de Control:";
            this.lblNumeroControl.Location = new System.Drawing.Point(12, 75);
            this.lblNumeroControl.AutoSize = true;
            this.txtNumeroControl.Location = new System.Drawing.Point(130, 72);
            this.txtNumeroControl.Size = new System.Drawing.Size(240, 20);

            // Foto
            this.pictureBoxFoto.Location = new System.Drawing.Point(12, 105);
            this.pictureBoxFoto.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCargarFoto.Location = new System.Drawing.Point(140, 105);
            this.btnCargarFoto.Size = new System.Drawing.Size(230, 25);
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);

            // Calificaciones
            this.lblCalificaciones.Text = "Calificaciones:";
            this.lblCalificaciones.Location = new System.Drawing.Point(140, 140);
            this.lblCalificaciones.AutoSize = true;
            this.lstCalificaciones.Location = new System.Drawing.Point(140, 160);
            this.lstCalificaciones.Size = new System.Drawing.Size(230, 65);

            this.txtCalificacion.Location = new System.Drawing.Point(140, 230);
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);

            this.btnAgregarCalificacion.Location = new System.Drawing.Point(250, 228);
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(60, 24);
            this.btnAgregarCalificacion.Text = "Agregar";
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);

            this.btnEliminarCalificacion.Location = new System.Drawing.Point(315, 228);
            this.btnEliminarCalificacion.Size = new System.Drawing.Size(60, 24);
            this.btnEliminarCalificacion.Text = "Eliminar";
            this.btnEliminarCalificacion.Click += new System.EventHandler(this.btnEliminarCalificacion_Click);

            this.lblPromedio.Location = new System.Drawing.Point(12, 235);
            this.lblPromedio.Size = new System.Drawing.Size(120, 20);
            this.lblPromedio.Text = "Promedio: 0.00";

            this.lblRegular.Location = new System.Drawing.Point(12, 255);
            this.lblRegular.Size = new System.Drawing.Size(120, 20);
            this.lblRegular.Text = "Regular: No";

            // Botones guardar/cancelar
            this.btnGuardar.Location = new System.Drawing.Point(140, 265);
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(270, 265);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Form settings
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblNumeroControl);
            this.Controls.Add(this.txtNumeroControl);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.lblCalificaciones);
            this.Controls.Add(this.lstCalificaciones);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.btnEliminarCalificacion);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblRegular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
