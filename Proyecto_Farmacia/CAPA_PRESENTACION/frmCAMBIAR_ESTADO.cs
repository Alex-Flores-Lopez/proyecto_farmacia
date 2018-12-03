﻿using System;
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
    public partial class frmCAMBIAR_ESTADO : Form
    {
        public frmCAMBIAR_ESTADO()
        {
            InitializeComponent();
        }
        private string resp = "";
        private void frmCAMBIAR_ESTADO_Load(object sender, EventArgs e)
        {
            if (Program.estado == "Inactivo")
            {
                comboBox1.Text = "Activo";
            }
            else {
                comboBox1.Text = "Inactivo";
            }

            txtID.Text = Program.id_usuario;
            txtNOMBRE.Text = Program.nombre;
            txtAPELLIDO.Text = Program.apellido;
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "System DW", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resp = Nusuario.Cambiar_Estado(comboBox1.Text, Convert.ToUInt16(Program.id_usuario));
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
