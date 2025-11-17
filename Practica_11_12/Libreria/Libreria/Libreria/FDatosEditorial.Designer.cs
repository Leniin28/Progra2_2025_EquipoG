namespace Libreria
{
    partial class FDatosEditorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbNombre = new TextBox();
            bCancelar = new Button();
            bEditorial = new Button();
            label4 = new Label();
            label5 = new Label();
            bLogo = new Button();
            tbLocalidad = new TextBox();
            ofdLogo = new OpenFileDialog();
            pbLogo = new PictureBox();
            nudCedula = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCedula).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(94, 15);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(261, 27);
            tbNombre.TabIndex = 1;
            // 
            // bCancelar
            // 
            bCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCancelar.Location = new Point(322, 163);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(96, 31);
            bCancelar.TabIndex = 9;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // bEditorial
            // 
            bEditorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bEditorial.Location = new Point(422, 163);
            bEditorial.Name = "bEditorial";
            bEditorial.Size = new Size(96, 31);
            bEditorial.TabIndex = 8;
            bEditorial.Text = "Agregar";
            bEditorial.UseVisualStyleBackColor = true;
            bEditorial.Click += bEditorial_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 60);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 15;
            label4.Text = "Localidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 105);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 16;
            label5.Text = "Cédula:";
            // 
            // bLogo
            // 
            bLogo.Location = new Point(261, 101);
            bLogo.Name = "bLogo";
            bLogo.Size = new Size(94, 29);
            bLogo.TabIndex = 17;
            bLogo.Text = "Logo";
            bLogo.UseVisualStyleBackColor = true;
            bLogo.Click += bLogo_Click;
            // 
            // tbLocalidad
            // 
            tbLocalidad.Location = new Point(94, 57);
            tbLocalidad.Name = "tbLocalidad";
            tbLocalidad.Size = new Size(261, 27);
            tbLocalidad.TabIndex = 18;
            // 
            // ofdLogo
            // 
            ofdLogo.FileName = "Img de Logo";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(378, 18);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(141, 112);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // nudCedula
            // 
            nudCedula.Location = new Point(94, 105);
            nudCedula.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCedula.Name = "nudCedula";
            nudCedula.Size = new Size(105, 27);
            nudCedula.TabIndex = 20;
            // 
            // FDatosEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 209);
            Controls.Add(nudCedula);
            Controls.Add(pbLogo);
            Controls.Add(tbLocalidad);
            Controls.Add(bLogo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(bCancelar);
            Controls.Add(bEditorial);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "FDatosEditorial";
            Text = "FDatosEditorial";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCedula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Button bCancelar;
        private Button bEditorial;
        private Label label4;
        private Label label5;
        private Button bLogo;
        private TextBox tbLocalidad;
        private OpenFileDialog ofdLogo;
        private PictureBox pbLogo;
        private NumericUpDown nudCedula;
    }
}