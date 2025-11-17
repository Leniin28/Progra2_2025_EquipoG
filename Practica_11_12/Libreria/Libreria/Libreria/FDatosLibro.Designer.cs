namespace Libreria
{
    partial class FDatosLibro
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
            label2 = new Label();
            tbTitulo = new TextBox();
            tbAutor = new TextBox();
            bLibro = new Button();
            bCancelar = new Button();
            bImg = new Button();
            ofdImage = new OpenFileDialog();
            pbImg = new PictureBox();
            label4 = new Label();
            nudPaginas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 28);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(109, 28);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(350, 27);
            tbTitulo.TabIndex = 3;
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(109, 72);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(350, 27);
            tbAutor.TabIndex = 4;
            // 
            // bLibro
            // 
            bLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bLibro.Location = new Point(522, 187);
            bLibro.Name = "bLibro";
            bLibro.Size = new Size(96, 31);
            bLibro.TabIndex = 6;
            bLibro.Text = "Agregar";
            bLibro.UseVisualStyleBackColor = true;
            bLibro.Click += bLibro_Click;
            // 
            // bCancelar
            // 
            bCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCancelar.Location = new Point(422, 187);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(96, 31);
            bCancelar.TabIndex = 7;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // bImg
            // 
            bImg.Location = new Point(480, 12);
            bImg.Name = "bImg";
            bImg.Size = new Size(139, 29);
            bImg.TabIndex = 8;
            bImg.Text = "Imagen";
            bImg.UseVisualStyleBackColor = true;
            bImg.Click += bImg_Click;
            // 
            // ofdImage
            // 
            ofdImage.FileName = "Imagen";
            // 
            // pbImg
            // 
            pbImg.Location = new Point(489, 47);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(121, 108);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 9;
            pbImg.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 116);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 10;
            label4.Text = "Páginas:";
            // 
            // nudPaginas
            // 
            nudPaginas.Location = new Point(109, 114);
            nudPaginas.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPaginas.Name = "nudPaginas";
            nudPaginas.Size = new Size(150, 27);
            nudPaginas.TabIndex = 11;
            // 
            // FDatosLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 230);
            Controls.Add(nudPaginas);
            Controls.Add(label4);
            Controls.Add(pbImg);
            Controls.Add(bImg);
            Controls.Add(bCancelar);
            Controls.Add(bLibro);
            Controls.Add(tbAutor);
            Controls.Add(tbTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FDatosLibro";
            Text = "FDatosLibro";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTitulo;
        private TextBox tbAutor;
        private Button bLibro;
        private Button bCancelar;
        private Button bImg;
        private OpenFileDialog ofdImage;
        private PictureBox pbImg;
        private Label label4;
        private NumericUpDown nudPaginas;
    }
}