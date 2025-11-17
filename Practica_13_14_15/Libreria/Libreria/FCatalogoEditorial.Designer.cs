namespace Libreria
{
    partial class FCatalogoEditorial
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
            lbEditorial = new ListBox();
            bAgregarEditorial = new Button();
            bEditar = new Button();
            SuspendLayout();
            // 
            // lbEditorial
            // 
            lbEditorial.FormattingEnabled = true;
            lbEditorial.Location = new Point(12, 69);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(764, 184);
            lbEditorial.TabIndex = 3;
            // 
            // bAgregarEditorial
            // 
            bAgregarEditorial.Location = new Point(9, 12);
            bAgregarEditorial.Name = "bAgregarEditorial";
            bAgregarEditorial.Size = new Size(137, 40);
            bAgregarEditorial.TabIndex = 2;
            bAgregarEditorial.Text = "Agregar Editorial";
            bAgregarEditorial.UseVisualStyleBackColor = true;
            bAgregarEditorial.Click += bAgregarEditorial_Click;
            // 
            // bEditar
            // 
            bEditar.Location = new Point(152, 12);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(137, 40);
            bEditar.TabIndex = 4;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            bEditar.Click += button1_Click;
            // 
            // FCatalogoEditorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(bEditar);
            Controls.Add(lbEditorial);
            Controls.Add(bAgregarEditorial);
            Name = "FCatalogoEditorial";
            Text = "FCatalogoEditorial";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEditorial;
        private Button bAgregarEditorial;
        private Button bEditar;
    }
}