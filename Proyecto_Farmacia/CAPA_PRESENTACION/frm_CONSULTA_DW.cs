using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class frm_CONSULTA_DW : Form
    {
        public frm_CONSULTA_DW()
        {
            InitializeComponent();
        }

        private void consultarExportacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(y => y is frm_CONSULTAR);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm_CONSULTAR obj = new frm_CONSULTAR();
            obj.MdiParent = this;
            obj.Show();
        }

        private void consultarImportacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(y => y is CONSULTAR_IMPORTAR);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            CONSULTAR_IMPORTAR obj = new CONSULTAR_IMPORTAR();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_PRINCIPAL().Show();
            this.Close();
        }
    }
}
