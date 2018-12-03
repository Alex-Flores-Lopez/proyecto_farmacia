namespace CAPA_PRESENTACION
{
    partial class frm_EXPORTAR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAÑOEX = new System.Windows.Forms.TextBox();
            this.txtMESEX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMES = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMES2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMES = new System.Windows.Forms.TextBox();
            this.txtAÑO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMES2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtMES);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAÑO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbMES);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMESEX);
            this.groupBox1.Controls.Add(this.txtAÑOEX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(98, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(556, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exportar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo a Exportar:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(731, 490);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exporta informacion periodica de ventas \r\n                                       " +
    "     para ser usado en el modulo Data Warehouse";
            // 
            // txtAÑOEX
            // 
            this.txtAÑOEX.Location = new System.Drawing.Point(272, 64);
            this.txtAÑOEX.MaxLength = 4;
            this.txtAÑOEX.Name = "txtAÑOEX";
            this.txtAÑOEX.Size = new System.Drawing.Size(71, 27);
            this.txtAÑOEX.TabIndex = 0;
            this.txtAÑOEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMESEX
            // 
            this.txtMESEX.Location = new System.Drawing.Point(372, 65);
            this.txtMESEX.MaxLength = 2;
            this.txtMESEX.Name = "txtMESEX";
            this.txtMESEX.Size = new System.Drawing.Size(66, 27);
            this.txtMESEX.TabIndex = 1;
            this.txtMESEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMESEX.TextChanged += new System.EventHandler(this.txtMESEX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // lbMES
            // 
            this.lbMES.AutoSize = true;
            this.lbMES.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMES.Location = new System.Drawing.Point(445, 67);
            this.lbMES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMES.Name = "lbMES";
            this.lbMES.Size = new System.Drawing.Size(44, 19);
            this.lbMES.TabIndex = 6;
            this.lbMES.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ultimo periodo Exportado:";
            // 
            // lbMES2
            // 
            this.lbMES2.AutoSize = true;
            this.lbMES2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMES2.Location = new System.Drawing.Point(445, 114);
            this.lbMES2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMES2.Name = "lbMES2";
            this.lbMES2.Size = new System.Drawing.Size(56, 19);
            this.lbMES2.TabIndex = 11;
            this.lbMES2.Text = "Enero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "/";
            // 
            // txtMES
            // 
            this.txtMES.Enabled = false;
            this.txtMES.Location = new System.Drawing.Point(372, 112);
            this.txtMES.Name = "txtMES";
            this.txtMES.Size = new System.Drawing.Size(66, 27);
            this.txtMES.TabIndex = 9;
            this.txtMES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAÑO
            // 
            this.txtAÑO.Enabled = false;
            this.txtAÑO.Location = new System.Drawing.Point(272, 111);
            this.txtAÑO.Name = "txtAÑO";
            this.txtAÑO.Size = new System.Drawing.Size(71, 27);
            this.txtAÑO.TabIndex = 8;
            this.txtAÑO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(671, 57);
            this.label6.TabIndex = 6;
            this.label6.Text = "Se exportara informacion en el siguiente archivo\r\nD:\\PROYECTOS\\Proyecto_Farmacia\\" +
    "CAPA_PRESENTACION\\bin\\Debug\\ARCHIVOS\r\n                                          " +
    "  ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frm_EXPORTAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_EXPORTAR";
            this.Text = "frm_EXPORTAR";
            this.Load += new System.EventHandler(this.frm_EXPORTAR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMES2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMES;
        private System.Windows.Forms.TextBox txtAÑO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMESEX;
        private System.Windows.Forms.TextBox txtAÑOEX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}