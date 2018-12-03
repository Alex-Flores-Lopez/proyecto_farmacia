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
    public partial class frm_IMPORTAR : Form
    {
        public frm_IMPORTAR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            btnACEPTAR.Enabled = false;
            visible(false);
            visiblelab(false);
            timer1.Enabled = true;
            contador = 0;
            bandera = false;
        }
        int contador = 0;
        bool bandera = false;
        private void timer1_Tick(object sender, EventArgs e)
        {

            contador++;


            if (contador == 1)
            {
                pbCLI.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\clientes.txt"))
                {

                    pbCLI.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbCLI.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }
            if (contador == 10)
            {
                pbPRO.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\productos.txt"))
                {

                    pbPRO.Image = Properties.Resources.bien1;


                }
                else
                {
                    pbPRO.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }
            if (contador == 15)
            {
                pbTIPO.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\tipo_productos.txt"))
                {

                    pbTIPO.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbTIPO.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }

            if (contador == 20)
            {
                pbFUN.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\funcionarios.txt"))
                {

                    pbFUN.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbFUN.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }
            if (contador == 25)
            {
                pbLAB.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\laboratorio.txt"))
                {

                    pbLAB.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbLAB.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }

            if (contador == 30)
            {
                pbTIEM.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\tiempo.txt"))
                {

                    pbTIEM.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbTIEM.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }

            if (contador == 35)
            {
                pbVEN.Visible = true;
                if (System.IO.File.Exists(@"ARCHIVOS\venta.txt"))
                {

                    pbVEN.Image = Properties.Resources.bien1;

                }
                else
                {
                    pbVEN.Image = Properties.Resources.mal;
                    bandera = true;
                }
            }

            if (contador == 35)
            {
                timer1.Enabled = false;
                if (bandera == true)
                {

                    MessageBox.Show("Error, Verifique los archivos para importar");
                    btnACEPTAR.Enabled = false;
                    visible(false);

                }
                else
                {
                    btnACEPTAR.Enabled = true;
                    btnCANCELAR.Enabled = true;
                }
            }
        }
        int contador2 = 0;
        string resp = "";
        private void timer2_Tick(object sender, EventArgs e)
        {
            contador2++;
            if (contador2 == 1)
            {

                resp = Nregistrar.Cargar("REGISTRAR_CLIENTES");
                lbCLI.Visible = true;
            }
            if (contador2 == 3)
            {
                resp = Nregistrar.Cargar("REGISTRAR_PRODUCTOS");
                lbPRO.Visible = true;
            }
            if (contador2 == 5)
            {
                resp = Nregistrar.Cargar("REGISTRAR_TIPO_PRODUCTO");
                lbTIPO.Visible = true;
            }
            if (contador2 == 7)
            {
                resp = Nregistrar.Cargar("REGISTRAR_FUNCIONARIO");
                lbFUN.Visible = true;
            }
            if (contador2 == 9)
            {
                resp = Nregistrar.Cargar("REGISTRAR_LABORATORIO");
                lbLAB.Visible = true;
            }

            if (contador2 == 11)
            {
                resp = Nregistrar.Cargar("REGISTRAR_TIEMPO");
                lbTIEM.Visible = true;
            }

            if (contador2 == 13)
            {
                resp = Nregistrar.Cargar("REGISTRAR_HVENTA");
                lbVEN.Visible = true;
            }

            if (contador2 == 14)
            {
                timer2.Enabled = false;
                MessageBox.Show("Se han importado los datos correctamente");

                visible(false);
                visiblelab(false);
                btnACEPTAR.Enabled = false;

                DateTime fecha = DateTime.Today;
                string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                resp = Nregistrar_DW_imp.RegistrarDW_imp(Program.id_usuario, hora, fecha_Actual);




            }
        }
        public void visible(bool bandera)
        {
            pbVEN.Visible = bandera;
            pbCLI.Visible = bandera;
            pbPRO.Visible = bandera;
            pbTIEM.Visible = bandera;
            pbFUN.Visible = bandera;
            pbTIPO.Visible = bandera;
            pbLAB.Visible = bandera;
        }
        public void visiblelab(bool bandera)
        {
            lbCLI.Visible = bandera;
            lbVEN.Visible = bandera;
            lbTIEM.Visible = bandera;
            lbLAB.Visible = bandera;
            lbFUN.Visible = bandera;
            lbPRO.Visible = bandera;
            lbTIPO.Visible = bandera;
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            contador2 = 0;
        }

        private void frm_IMPORTAR_Load(object sender, EventArgs e)
        {
            btnACEPTAR.Enabled = false;
        }
    }
}
