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
    public partial class frm_PRINCIPAL : Form
    {
        private int childFormNumber = 0;

        public frm_PRINCIPAL()
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

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_PRINCIPAL_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode.Text== "Exportacion de datos      ")
            {

                new EXPORTAR_PRINCIPAL().Show();
                this.Hide();
            }
            if(treeView1.SelectedNode.Text == "Importacion de datos para DW       ")
            {
                new IMPORTAR_PRINCIPAL().Show();
                this.Hide();
            }
            if (treeView1.SelectedNode.Text == "Usuario      ")
            {
                new frm_PRINCIPAL_ADMINISTRADOR().Show();
                this.Hide();
            }
            if (treeView1.SelectedNode.Text == "Consultas de DW     ")
            {
                new frm_CONSULTA_DW().Show();
                this.Hide();
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void exportacionDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EXPORTAR_PRINCIPAL().Show();
            this.Hide();
        }

        private void importacionDeDatosParaDWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IMPORTAR_PRINCIPAL().Show();
            this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_PRINCIPAL_ADMINISTRADOR().Show();
            this.Hide();
        }

        private void consultasDeDWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_CONSULTA_DW().Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Close();
        }
    }
}
