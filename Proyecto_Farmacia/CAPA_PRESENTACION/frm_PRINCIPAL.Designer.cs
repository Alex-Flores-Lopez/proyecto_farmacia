namespace CAPA_PRESENTACION
{
    partial class frm_PRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PRINCIPAL));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Exportacion de datos      ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Importacion de datos para DW       ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Especiales          ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Usuario      ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Consultas de DW     ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Otros           ", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.especialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exportacionDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionDeDatosParaDWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasDeDWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Gakuseisean-Ivista-2-Misc-Database-3.ico");
            this.imageList1.Images.SetKeyName(1, "database-export.png");
            this.imageList1.Images.SetKeyName(2, "Tutorial Apolo 4.0_html_m10daeb51.jpg");
            this.imageList1.Images.SetKeyName(3, "DATA3.png");
            this.imageList1.Images.SetKeyName(4, "subir.png");
            this.imageList1.Images.SetKeyName(5, "bajar.png");
            this.imageList1.Images.SetKeyName(6, "usuario.png");
            this.imageList1.Images.SetKeyName(7, "database-backup.png");
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageKey = "bajar.png";
            treeNode1.Name = "Nodo1";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Exportacion de datos      ";
            treeNode2.ImageKey = "subir.png";
            treeNode2.Name = "Nodo3";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "Importacion de datos para DW       ";
            treeNode3.Name = "Nodo0";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.Text = "Especiales          ";
            treeNode4.ImageIndex = 6;
            treeNode4.Name = "Nodo4";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.SelectedImageKey = "usuario.png";
            treeNode4.Text = "Usuario      ";
            treeNode5.ImageKey = "database-backup.png";
            treeNode5.Name = "Nodo0";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.SelectedImageIndex = 7;
            treeNode5.Text = "Consultas de DW     ";
            treeNode6.Name = "Nodo2";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "Otros           ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(426, 779);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialesToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1539, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // especialesToolStripMenuItem
            // 
            this.especialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportacionDeDatosToolStripMenuItem,
            this.importacionDeDatosParaDWToolStripMenuItem});
            this.especialesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialesToolStripMenuItem.Name = "especialesToolStripMenuItem";
            this.especialesToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.especialesToolStripMenuItem.Text = "Especiales";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.consultasDeDWToolStripMenuItem});
            this.administradorToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 807);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 24, 0);
            this.statusStrip.Size = new System.Drawing.Size(1539, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(899, 668);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATA WAREHOUSE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAPA_PRESENTACION.Properties.Resources.DATA3;
            this.pictureBox1.Location = new System.Drawing.Point(971, 355);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // exportacionDeDatosToolStripMenuItem
            // 
            this.exportacionDeDatosToolStripMenuItem.Image = global::CAPA_PRESENTACION.Properties.Resources.bajar;
            this.exportacionDeDatosToolStripMenuItem.Name = "exportacionDeDatosToolStripMenuItem";
            this.exportacionDeDatosToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.exportacionDeDatosToolStripMenuItem.Text = "Exportacion de datos";
            this.exportacionDeDatosToolStripMenuItem.Click += new System.EventHandler(this.exportacionDeDatosToolStripMenuItem_Click);
            // 
            // importacionDeDatosParaDWToolStripMenuItem
            // 
            this.importacionDeDatosParaDWToolStripMenuItem.Image = global::CAPA_PRESENTACION.Properties.Resources.subir;
            this.importacionDeDatosParaDWToolStripMenuItem.Name = "importacionDeDatosParaDWToolStripMenuItem";
            this.importacionDeDatosParaDWToolStripMenuItem.Size = new System.Drawing.Size(312, 26);
            this.importacionDeDatosParaDWToolStripMenuItem.Text = "Importacion de datos para DW";
            this.importacionDeDatosParaDWToolStripMenuItem.Click += new System.EventHandler(this.importacionDeDatosParaDWToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = global::CAPA_PRESENTACION.Properties.Resources.usuario;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // consultasDeDWToolStripMenuItem
            // 
            this.consultasDeDWToolStripMenuItem.Image = global::CAPA_PRESENTACION.Properties.Resources.database_backup;
            this.consultasDeDWToolStripMenuItem.Name = "consultasDeDWToolStripMenuItem";
            this.consultasDeDWToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultasDeDWToolStripMenuItem.Text = "Consultas de DW";
            this.consultasDeDWToolStripMenuItem.Click += new System.EventHandler(this.consultasDeDWToolStripMenuItem_Click);
            // 
            // frm_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 832);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_PRINCIPAL";
            this.Text = "frm_PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PRINCIPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem especialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportacionDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importacionDeDatosParaDWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasDeDWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



