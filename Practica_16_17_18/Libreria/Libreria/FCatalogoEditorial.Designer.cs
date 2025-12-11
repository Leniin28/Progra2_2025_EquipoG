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
            lbListaLibros = new ListBox();
            bListaLibros = new Button();
            SuspendLayout();
            // 
            // lbEditorial
            // 
            lbEditorial.FormattingEnabled = true;
            lbEditorial.ItemHeight = 25;
            lbEditorial.Location = new Point(15, 86);
            lbEditorial.Margin = new Padding(4, 4, 4, 4);
            lbEditorial.Name = "lbEditorial";
            lbEditorial.Size = new Size(814, 229);
            lbEditorial.TabIndex = 3;
            // 
            // bAgregarEditorial
            // 
            bAgregarEditorial.Location = new Point(11, 15);
            bAgregarEditorial.Margin = new Padding(4, 4, 4, 4);
            bAgregarEditorial.Name = "bAgregarEditorial";
            bAgregarEditorial.Size = new Size(171, 50);
            bAgregarEditorial.TabIndex = 2;
            bAgregarEditorial.Text = "Agregar Editorial";
            bAgregarEditorial.UseVisualStyleBackColor = true;
            bAgregarEditorial.Click += bAgregarEditorial_Click;
            // 
            // bEditar
            // 
            bEditar.Location = new Point(190, 15);
            bEditar.Margin = new Padding(4, 4, 4, 4);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(171, 50);
            bEditar.TabIndex = 4;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            bEditar.Click += bEditar_Click;
            // 
            // lbListaLibros
            // 
            lbListaLibros.FormattingEnabled = true;
            lbListaLibros.ItemHeight = 25;
            lbListaLibros.Location = new Point(214, 348);
            lbListaLibros.Margin = new Padding(4, 4, 4, 4);
            lbListaLibros.Name = "lbListaLibros";
            lbListaLibros.Size = new Size(204, 229);
            lbListaLibros.TabIndex = 5;
            // 
            // bListaLibros
            // 
            bListaLibros.Location = new Point(15, 348);
            bListaLibros.Margin = new Padding(4, 4, 4, 4);
            bListaLibros.Name = "bListaLibros";
            bListaLibros.Size = new Size(171, 50);
            bListaLibros.TabIndex = 6;
            bListaLibros.Text = "Lista de Libros ";
            bListaLibros.UseVisualStyleBackColor = true;
            bListaLibros.Click += bListaLibros_Click;
            // 
            // FCatalogoEditorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 590);
            Controls.Add(bListaLibros);
            Controls.Add(lbListaLibros);
            Controls.Add(bEditar);
            Controls.Add(lbEditorial);
            Controls.Add(bAgregarEditorial);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FCatalogoEditorial";
            Text = "FCatalogoEditorial";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEditorial;
        private Button bAgregarEditorial;
        private Button bEditar;
        private ListBox lbListaLibros;
        private Button bListaLibros;
    }
}