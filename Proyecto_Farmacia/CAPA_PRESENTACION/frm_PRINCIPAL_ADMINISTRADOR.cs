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
    public partial class frm_PRINCIPAL_ADMINISTRADOR : Form
    {
        private int childFormNumber = 0;

        public frm_PRINCIPAL_ADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(y => y is frm_USUARIO_REGISTRAR);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm_USUARIO_REGISTRAR obj = new frm_USUARIO_REGISTRAR();
            obj.MdiParent = this;
            obj.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(y => y is frm_BUSCAR_USUARIO);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
            obj.MdiParent = this;
            obj.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.id_usuario == "0")
            {
                MessageBox.Show("Seleccione un usuario");
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_BUSCAR_USUARIO);
                frm_BUSCAR_USUARIO o = new frm_BUSCAR_USUARIO();
                if (frm != null)
                {
                    frm.Close();
                    frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
                    obj.MdiParent = this;

                    obj.Show();
                    return;
                }
                frm_BUSCAR_USUARIO obj2 = new frm_BUSCAR_USUARIO();
                obj2.MdiParent = this;

                obj2.Show();
            }
            else
            {
                Form frm = this.MdiChildren.FirstOrDefault(y => y is frm_USUARIO_MODIFICAR);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frm_USUARIO_MODIFICAR obj = new frm_USUARIO_MODIFICAR();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.id_usuario == "0")
            {
                MessageBox.Show("Seleccione un usuario");
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_BUSCAR_USUARIO);
                frm_BUSCAR_USUARIO o = new frm_BUSCAR_USUARIO();
                if (frm != null)
                {
                    frm.Close();
                    frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
                    obj.MdiParent = this;

                    obj.Show();
                    return;
                }
                frm_BUSCAR_USUARIO obj2 = new frm_BUSCAR_USUARIO();
                obj2.MdiParent = this;

                obj2.Show();
            }
            else
            {
                Form frm = this.MdiChildren.FirstOrDefault(y => y is frmELIMINAR_USUARIO);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frmELIMINAR_USUARIO obj = new frmELIMINAR_USUARIO();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void cambiarEstadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Program.id_usuario == "0")
            {
                MessageBox.Show("Seleccione un usuario");
                Form frm = this.MdiChildren.FirstOrDefault(X => X is frm_BUSCAR_USUARIO);
                frm_BUSCAR_USUARIO o = new frm_BUSCAR_USUARIO();
                if (frm != null)
                {
                    frm.Close();
                    frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
                    obj.MdiParent = this;

                    obj.Show();
                    return;
                }
                frm_BUSCAR_USUARIO obj2 = new frm_BUSCAR_USUARIO();
                obj2.MdiParent = this;

                obj2.Show();
            }
            else
            {
                Form frm = this.MdiChildren.FirstOrDefault(y => y is frmCAMBIAR_ESTADO);
                if (frm != null)
                {
                    frm.BringToFront();
                    return;
                }
                frmCAMBIAR_ESTADO obj = new frmCAMBIAR_ESTADO();
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_PRINCIPAL().Show();
            this.Close();
        }

        private void frm_PRINCIPAL_ADMINISTRADOR_Load(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(y => y is frm_BUSCAR_USUARIO);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm_BUSCAR_USUARIO obj = new frm_BUSCAR_USUARIO();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
