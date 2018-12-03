namespace CAPA_PRESENTACION
{
    partial class frm_CONSULTA_DW
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarExportacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarImportacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarExportacionesToolStripMenuItem,
            this.consultarImportacionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarExportacionesToolStripMenuItem
            // 
            this.consultarExportacionesToolStripMenuItem.Name = "consultarExportacionesToolStripMenuItem";
            this.consultarExportacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.consultarExportacionesToolStripMenuItem.Text = "Consultar Exportaciones";
            this.consultarExportacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarExportacionesToolStripMenuItem_Click);
            // 
            // consultarImportacionesToolStripMenuItem
            // 
            this.consultarImportacionesToolStripMenuItem.Name = "consultarImportacionesToolStripMenuItem";
            this.consultarImportacionesToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.consultarImportacionesToolStripMenuItem.Text = "Consultar Importaciones";
            this.consultarImportacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarImportacionesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frm_CONSULTA_DW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_CONSULTA_DW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_CONSULTA_DW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarExportacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarImportacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}