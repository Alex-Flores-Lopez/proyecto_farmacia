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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        DataTable Tabla;
        private void button1_Click(object sender, EventArgs e)
        {
            Tabla = Nusuario.Login(txtUSUARIO.Text, txtPASSWORD.Text);

            if (txtUSUARIO.Text == "" && txtPASSWORD.Text == "")
            {
                MessageBox.Show("COMPLETE LOS CAMPOS ", "System DW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Tabla != null)
            {
                if (Tabla.Rows.Count > 0)
                {
                    Program.id_usuario= Tabla.Rows[0][0].ToString();
                    new frm_PRINCIPAL().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("NO TIENE ACCESO AL SISTEMA ", "System DW", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("NO TIENE ACCESO AL SISTEMA ", "System DW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
