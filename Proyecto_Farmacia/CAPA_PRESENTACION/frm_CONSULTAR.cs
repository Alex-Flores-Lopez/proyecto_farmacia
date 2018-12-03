using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class frm_CONSULTAR : Form
    {
        public frm_CONSULTAR()
        {
            InitializeComponent();
        }

        private void frm_CONSULTAR_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nregistrar_DW.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nregistrar_DW.Mostrar_campo(dmDESDE.Value,dmHASTA.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nregistrar_DW.Mostrar();
        }
    }
}
