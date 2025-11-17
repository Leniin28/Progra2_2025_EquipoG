namespace Libreria
{
    partial class FCatalogoLibros
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
            bAgregarLibro = new Button();
            lbLibros = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // bAgregarLibro
            // 
            bAgregarLibro.Location = new Point(12, 12);
            bAgregarLibro.Name = "bAgregarLibro";
            bAgregarLibro.Size = new Size(137, 40);
            bAgregarLibro.TabIndex = 0;
            bAgregarLibro.Text = "Agregar libro";
            bAgregarLibro.UseVisualStyleBackColor = true;
            bAgregarLibro.Click += bAgregarLibro_Click;
            // 
            // lbLibros
            // 
            lbLibros.FormattingEnabled = true;
            lbLibros.Location = new Point(15, 69);
            lbLibros.Name = "lbLibros";
            lbLibros.Size = new Size(764, 184);
            lbLibros.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(176, 18);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FCatalogoLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 280);
            Controls.Add(button1);
            Controls.Add(lbLibros);
            Controls.Add(bAgregarLibro);
            Name = "FCatalogoLibros";
            Text = "FCatalogoLibros";
            ResumeLayout(false);
        }

        #endregion

        private Button bAgregarLibro;
        private ListBox lbLibros;
        private Button button1;
    }
}