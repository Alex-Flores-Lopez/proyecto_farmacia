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
    public partial class frm_BUSCAR_USUARIO : Form
    {
        public frm_BUSCAR_USUARIO()
        {
            InitializeComponent();
        }

        private void frm_BUSCAR_USUARIO_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nusuario.MostrarTodo();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int p = e.RowIndex;
            int kia = 0;
            foreach (DataGridViewRow rowp in dataGridView1.Rows)
            {
                kia = rowp.Index;

                if (kia == p)
                {
                    dataGridView1.Rows[p].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (kia != p)
                {
                    dataGridView1.Rows[kia].DefaultCellStyle.BackColor = Color.White;
                }
            }

            Program.id_usuario = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Program.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.telefono = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.sexo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Program.observacion = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Program.usuario = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Program.pass = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Program.estado = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nusuario.Mostrar_Campo(cbCAMPO.Text,txtTEXTO.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nusuario.MostrarTodo();
        }

        private void frm_BUSCAR_USUARIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.id_usuario = "0";
        }

        private void frm_BUSCAR_USUARIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.id_usuario = "0";
        }
    }
}
