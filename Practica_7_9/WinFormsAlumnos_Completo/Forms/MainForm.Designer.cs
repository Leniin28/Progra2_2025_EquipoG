namespace WinFormsAlumnos
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnAbrirGrupo;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Label lblAlumnos;

        private void InitializeComponent()
        {
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnAbrirGrupo = new System.Windows.Forms.Button();
            this.btnMostrarInfo = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lblAlumnos = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblAlumnos
            this.lblAlumnos.Text = "Alumnos del Grupo:";
            this.lblAlumnos.Location = new System.Drawing.Point(12, 10);
            this.lblAlumnos.AutoSize = true;

            // lstAlumnos
            this.lstAlumnos.Location = new System.Drawing.Point(12, 30);
            this.lstAlumnos.Size = new System.Drawing.Size(360, 160);

            // btnNuevoAlumno
            this.btnNuevoAlumno.Location = new System.Drawing.Point(12, 200);
            this.btnNuevoAlumno.Size = new System.Drawing.Size(110, 30);
            this.btnNuevoAlumno.Text = "Nuevo Alumno";
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);

            // btnEditarAlumno
            this.btnEditarAlumno.Location = new System.Drawing.Point(132, 200);
            this.btnEditarAlumno.Size = new System.Drawing.Size(110, 30);
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.Click += new System.EventHandler(this.btnEditarAlumno_Click);

            // btnAbrirGrupo
            this.btnAbrirGrupo.Location = new System.Drawing.Point(252, 200);
            this.btnAbrirGrupo.Size = new System.Drawing.Size(120, 30);
            this.btnAbrirGrupo.Text = "Gestionar Grupo";
            this.btnAbrirGrupo.Click += new System.EventHandler(this.btnAbrirGrupo_Click);

            // btnMostrarInfo
            this.btnMostrarInfo.Location = new System.Drawing.Point(12, 240);
            this.btnMostrarInfo.Size = new System.Drawing.Size(360, 30);
            this.btnMostrarInfo.Text = "Mostrar Información Rápida";
            this.btnMostrarInfo.Click += new System.EventHandler(this.btnMostrarInfo_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnNuevoAlumno);
            this.Controls.Add(this.btnEditarAlumno);
            this.Controls.Add(this.btnAbrirGrupo);
            this.Controls.Add(this.btnMostrarInfo);
            this.Text = "Gestión de Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
