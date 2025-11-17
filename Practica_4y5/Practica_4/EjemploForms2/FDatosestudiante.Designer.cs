namespace EjemploForms2
{
    partial class FDatosestudiante
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
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCarrera = new System.Windows.Forms.TextBox();
            this.TBNC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.PictureBox();
            this.PDFotografía = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(75, 53);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(219, 22);
            this.TBNombre.TabIndex = 0;
            this.TBNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TBCarrera
            // 
            this.TBCarrera.Location = new System.Drawing.Point(75, 97);
            this.TBCarrera.Name = "TBCarrera";
            this.TBCarrera.Size = new System.Drawing.Size(219, 22);
            this.TBCarrera.TabIndex = 1;
            this.TBCarrera.TextChanged += new System.EventHandler(this.TBCarrera_TextChanged);
            // 
            // TBNC
            // 
            this.TBNC.Location = new System.Drawing.Point(115, 161);
            this.TBNC.Name = "TBNC";
            this.TBNC.Size = new System.Drawing.Size(100, 22);
            this.TBNC.TabIndex = 2;
            this.TBNC.TextChanged += new System.EventHandler(this.TBNC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carrera:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. De Control:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB
            // 
            this.PB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB.Location = new System.Drawing.Point(111, 207);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(327, 219);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB.TabIndex = 7;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            // 
            // PDFotografía
            // 
            this.PDFotografía.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FDatosestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNC);
            this.Controls.Add(this.TBCarrera);
            this.Controls.Add(this.TBNombre);
            this.Name = "FDatosestudiante";
            this.Text = "FDatosestudiante";
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCarrera;
        private System.Windows.Forms.TextBox TBNC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.OpenFileDialog PDFotografía;
        private System.Windows.Forms.Button button2;
    }
}