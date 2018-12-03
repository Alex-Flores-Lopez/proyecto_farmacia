using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using CAPA_NEGOCIO;


namespace CAPA_PRESENTACION
{
    public partial class EXPORTAR_GENERAL : Form
    {
        public EXPORTAR_GENERAL()
        {
            InitializeComponent();
        }
        string resp = "";
        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            contador = 0;
        }

        private void EXPORTAR_GENERAL_Load(object sender, EventArgs e)
        {

        }
        public void visible(bool bandera)
        {
           
            pbCLIENTE.Visible = bandera;
            pbPRODUCTO.Visible = bandera;
          
            pbFUNCIONARIO.Visible = bandera;
            pbTIPO_PRODUCTO.Visible = bandera;
            pbLABORATORIO.Visible = bandera;
        }
        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                pbCLIENTE.Image = Properties.Resources.bien1;
                pbCLIENTE.Visible = true;
              this.dataGridView1.DataSource = Ntabla.Cliente();
               Guardar_archivo("ARCHIVOS/clientes.txt");
              



            }
            if (contador == 3)
            {
                pbPRODUCTO.Visible = true;

                pbPRODUCTO.Image = Properties.Resources.bien1;
                this.dataGridView1.DataSource = Ntabla.Productos();
              Guardar_archivo("ARCHIVOS/productos.txt");


            }
            if (contador == 5)
            {
                pbTIPO_PRODUCTO.Visible = true;

                pbTIPO_PRODUCTO.Image = Properties.Resources.bien1;
            this.dataGridView1.DataSource = Ntabla.Tipo_Producto();
            Guardar_archivo("ARCHIVOS/tipo_productos.txt");
            }

            if (contador == 7)
            {
                pbFUNCIONARIO.Visible = true;

                pbFUNCIONARIO.Image = Properties.Resources.bien1;
              Guardar_archivo("ARCHIVOS/funcionarios.txt");
               this.dataGridView1.DataSource = Ntabla.Productos();

            }
            if (contador == 9)
            {
                pbLABORATORIO.Visible = true;

                pbLABORATORIO.Image = Properties.Resources.bien1;
              this.dataGridView1.DataSource = Ntabla.Laboratorios();
               Guardar_archivo("ARCHIVOS/laboratorio.txt");

            }

            /*if (contador == 11)
            {
                pbTIEMPO.Visible = true;

                pbTIEMPO.Image = Properties.Resources.bien1;
              this.dataGridView1.DataSource = Ntabla.Tiempo_general();
               Guardar_archivo_tiempo("ARCHIVOS/tiempo.txt");
            }

            if (contador == 13)
            {
                pbVEN.Visible = true;
                pbVEN.Image = Properties.Resources.bien1;
              this.dataGridView1.DataSource = Ntabla.Hventa_general();
              Guardar_archivo_hventa("ARCHIVOS/venta.txt");

             

            }*/

            if (contador == 14)
            {
                timer1.Enabled = false;
                MessageBox.Show("Se ha exportado los datos correctamente");
                DateTime fecha = DateTime.Today;
           
                string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");

                resp = Nregistrar_DW.RegistrarDW(Program.id_usuario, "todo", "todo", hora, fecha_Actual);
                visible(false);

            }
        }



        public void Guardar_archivo(string pruta)
        {
            using (StreamWriter Oarchivo = File.CreateText(pruta))
            {
            }
            StreamWriter ESCRIBIR = File.AppendText(pruta);

            try
            {

                string Linea = "";
                for (int v = 0; v <= dataGridView1.RowCount; v++)
                {

                    Linea = dataGridView1.Rows[v].Cells[0].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[1].Value.ToString();
                    ESCRIBIR.WriteLine(Linea);
                }
                ESCRIBIR.Close();
            }
            catch (Exception)
            {
                ESCRIBIR.Close();
            }

        }
        public void Guardar_archivo_tiempo(string pruta)
        {
            using (StreamWriter Oarchivo = File.CreateText(pruta))
            {
            }
            StreamWriter ESCRIBIR = File.AppendText(pruta);

            try
            {

                string Linea = "";
                for (int v = 0; v <= dataGridView1.RowCount; v++)
                {

                    Linea = dataGridView1.Rows[v].Cells[0].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[1].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[2].Value.ToString();
                    ESCRIBIR.WriteLine(Linea);
                }
                ESCRIBIR.Close();
            }
            catch (Exception)
            {
                ESCRIBIR.Close();
            }

        }
        public void Guardar_archivo_hventa(string pruta)
        {
            using (StreamWriter Oarchivo = File.CreateText(pruta))
            {
            }
            StreamWriter ESCRIBIR = File.AppendText(pruta);

            try
            {

                string Linea = "";
                for (int v = 0; v <= dataGridView1.RowCount; v++)
                {

                    Linea = dataGridView1.Rows[v].Cells[0].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[1].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[2].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[3].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[4].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[5].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[6].Value.ToString() + "|" +
                            dataGridView1.Rows[v].Cells[7].Value.ToString();
                    Linea = Linea.Replace(",", ".");
                    ESCRIBIR.WriteLine(Linea);
                }
                MessageBox.Show(Linea);
                ESCRIBIR.Close();
            }
            catch (Exception)
            {
                ESCRIBIR.Close();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
