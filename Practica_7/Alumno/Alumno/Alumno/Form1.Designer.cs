namespace Alumno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumControl = new System.Windows.Forms.TextBox();
            this.pbxImagenAlumno = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarCalificacion = new System.Windows.Forms.Button();
            this.lstCalificaciones = new System.Windows.Forms.ListBox();
            this.btnCalcularResultados = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrera";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(82, 60);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Num. Control";
            // 
            // txtNumControl
            // 
            this.txtNumControl.Location = new System.Drawing.Point(82, 95);
            this.txtNumControl.Name = "txtNumControl";
            this.txtNumControl.Size = new System.Drawing.Size(100, 20);
            this.txtNumControl.TabIndex = 5;
            // 
            // pbxImagenAlumno
            // 
            this.pbxImagenAlumno.Location = new System.Drawing.Point(413, 28);
            this.pbxImagenAlumno.Name = "pbxImagenAlumno";
            this.pbxImagenAlumno.Size = new System.Drawing.Size(358, 164);
            this.pbxImagenAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenAlumno.TabIndex = 6;
            this.pbxImagenAlumno.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(293, 169);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(96, 23);
            this.btnCargarImagen.TabIndex = 7;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calificacion";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(117, 218);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(120, 20);
            this.txtCalificacion.TabIndex = 9;
            // 
            // btnAgregarCalificacion
            // 
            this.btnAgregarCalificacion.Location = new System.Drawing.Point(35, 252);
            this.btnAgregarCalificacion.Name = "btnAgregarCalificacion";
            this.btnAgregarCalificacion.Size = new System.Drawing.Size(133, 23);
            this.btnAgregarCalificacion.TabIndex = 10;
            this.btnAgregarCalificacion.Text = "Agregar Calificacion";
            this.btnAgregarCalificacion.UseVisualStyleBackColor = true;
            this.btnAgregarCalificacion.Click += new System.EventHandler(this.btnAgregarCalificacion_Click);
            // 
            // lstCalificaciones
            // 
            this.lstCalificaciones.FormattingEnabled = true;
            this.lstCalificaciones.Location = new System.Drawing.Point(35, 298);
            this.lstCalificaciones.Name = "lstCalificaciones";
            this.lstCalificaciones.Size = new System.Drawing.Size(120, 95);
            this.lstCalificaciones.TabIndex = 11;
            this.lstCalificaciones.SelectedIndexChanged += new System.EventHandler(this.lstCalificaciones_SelectedIndexChanged);
            // 
            // btnCalcularResultados
            // 
            this.btnCalcularResultados.Location = new System.Drawing.Point(177, 304);
            this.btnCalcularResultados.Name = "btnCalcularResultados";
            this.btnCalcularResultados.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularResultados.TabIndex = 12;
            this.btnCalcularResultados.Text = "Calcular";
            this.btnCalcularResultados.UseVisualStyleBackColor = true;
            this.btnCalcularResultados.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(183, 345);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 13;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(183, 369);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 14;
            this.lblEstatus.Text = "Estatus:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnCalcularResultados);
            this.Controls.Add(this.lstCalificaciones);
            this.Controls.Add(this.btnAgregarCalificacion);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbxImagenAlumno);
            this.Controls.Add(this.txtNumControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumControl;
        private System.Windows.Forms.PictureBox pbxImagenAlumno;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtCalificacion;
        private System.Windows.Forms.Button btnAgregarCalificacion;
        private System.Windows.Forms.ListBox lstCalificaciones;
        private System.Windows.Forms.Button btnCalcularResultados;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

