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
    public partial class frm_USUARIO_REGISTRAR : Form
    {
        public frm_USUARIO_REGISTRAR()
        {
            InitializeComponent();
        }
        private string resp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                MensajeOk("Complete los datos");

            }
            else
            {

                resp = Nusuario.Registrar(txtNOMBRE.Text, txtAPELLIDO.Text, txtTELEFONO.Text, comboBox1.Text, txtOBSERVACION.Text, txtUSUARIO.Text, txtCONTRASEÑA.Text);
                if (resp.Equals("ok"))
                {
                    MensajeOk("Se realizo la operacion correctamente.");
                    this.Close();
                    Form frm = frm_PRINCIPAL_ADMINISTRADOR.ActiveForm.MdiChildren.FirstOrDefault(X => X is frm_BUSCAR_USUARIO);
                    frm_BUSCAR_USUARIO o = new frm_BUSCAR_USUARIO();
                    if (frm != null)
                    {
                        frm.Close();
                        frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
                        obj.MdiParent = frm_PRINCIPAL_ADMINISTRADOR.ActiveForm;
                        obj.Show();
                        return;
                    }
                    frm_BUSCAR_USUARIO obj2 = new frm_BUSCAR_USUARIO();
                    obj2.MdiParent = frm_PRINCIPAL_ADMINISTRADOR.ActiveForm;

                    obj2.Show();
                }
                else
                {

                    MensajeOk("No se realizo la operacion");

                }
            }
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "System DW", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool validar()
        {
            bool bandera = false;
            if (txtNOMBRE.Text == "" || txtAPELLIDO.Text == "" || txtTELEFONO.Text == "" || txtUSUARIO.Text == "" || txtCONTRASEÑA.Text == "")
            {
                bandera = true;
            }
            return bandera;
        }
    }
}

