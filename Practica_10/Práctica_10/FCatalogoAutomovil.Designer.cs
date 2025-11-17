namespace Práctica_10
{
    partial class FCatalogoAutomovil
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
            this.BAgregarAutomovil = new System.Windows.Forms.Button();
            this.LBAutomovil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BAgregarAutomovil
            // 
            this.BAgregarAutomovil.Location = new System.Drawing.Point(12, 12);
            this.BAgregarAutomovil.Name = "BAgregarAutomovil";
            this.BAgregarAutomovil.Size = new System.Drawing.Size(75, 23);
            this.BAgregarAutomovil.TabIndex = 0;
            this.BAgregarAutomovil.Text = "Agregar";
            this.BAgregarAutomovil.UseVisualStyleBackColor = true;
            this.BAgregarAutomovil.Click += new System.EventHandler(this.BAgregarAutomovil_Click);
            // 
            // LBAutomovil
            // 
            this.LBAutomovil.FormattingEnabled = true;
            this.LBAutomovil.ItemHeight = 16;
            this.LBAutomovil.Location = new System.Drawing.Point(12, 58);
            this.LBAutomovil.Name = "LBAutomovil";
            this.LBAutomovil.Size = new System.Drawing.Size(416, 196);
            this.LBAutomovil.TabIndex = 1;
            // 
            // FCatalogoAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 292);
            this.Controls.Add(this.LBAutomovil);
            this.Controls.Add(this.BAgregarAutomovil);
            this.Name = "FCatalogoAutomovil";
            this.Text = "FCatalogoAutomovil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAgregarAutomovil;
        private System.Windows.Forms.ListBox LBAutomovil;
    }
}