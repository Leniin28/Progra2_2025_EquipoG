namespace WinFormsAlumnos
{
    partial class GrupoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblReprobadas;
        private System.Windows.Forms.ListBox lstRegulares;
        private System.Windows.Forms.ListBox lstIrregulares;
        private System.Windows.Forms.Label lblRegulares;
        private System.Windows.Forms.Label lblIrregulares;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizar;

        private void InitializeComponent()
        {
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblReprobadas = new System.Windows.Forms.Label();
            this.lstRegulares = new System.Windows.Forms.ListBox();
            this.lstIrregulares = new System.Windows.Forms.ListBox();
            this.lblRegulares = new System.Windows.Forms.Label();
            this.lblIrregulares = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblPromedio
            this.lblPromedio.Location = new System.Drawing.Point(12, 9);
            this.lblPromedio.Size = new System.Drawing.Size(300, 20);
            this.lblPromedio.Text = "Promedio Grupo: 0.00";

            // lblReprobadas
            this.lblReprobadas.Location = new System.Drawing.Point(12, 30);
            this.lblReprobadas.Size = new System.Drawing.Size(300, 20);
            this.lblReprobadas.Text = "Total reprobadas: 0";

            // lstRegulares
            this.lblRegulares.Location = new System.Drawing.Point(12, 55);
            this.lblRegulares.AutoSize = true;
            this.lblRegulares.Text = "Regulares:";
            this.lstRegulares.Location = new System.Drawing.Point(12, 75);
            this.lstRegulares.Size = new System.Drawing.Size(200, 160);

            // lstIrregulares
            this.lblIrregulares.Location = new System.Drawing.Point(230, 55);
            this.lblIrregulares.AutoSize = true;
            this.lblIrregulares.Text = "Irregulares:";
            this.lstIrregulares.Location = new System.Drawing.Point(230, 75);
            this.lstIrregulares.Size = new System.Drawing.Size(200, 160);

            // Buttons
            this.btnActualizar.Location = new System.Drawing.Point(12, 245);
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnCerrar.Location = new System.Drawing.Point(330, 245);
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(450, 290);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblReprobadas);
            this.Controls.Add(this.lblRegulares);
            this.Controls.Add(this.lstRegulares);
            this.Controls.Add(this.lblIrregulares);
            this.Controls.Add(this.lstIrregulares);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCerrar);
            this.Text = "Información del Grupo";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
