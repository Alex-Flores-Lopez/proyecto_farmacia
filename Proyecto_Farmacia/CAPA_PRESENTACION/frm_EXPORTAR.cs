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
    public partial class frm_EXPORTAR : Form
    {
        public frm_EXPORTAR()
        {
            InitializeComponent();
        }
        string resp = "";
        private void button1_Click(object sender, EventArgs e)
        {

            if (lbMES.Text == "Mes" || txtAÑOEX.Text == "")
            {
                MessageBox.Show("Error, Verifique los campos para exportar");
            }
            else
            {


                int mes = Convert.ToInt16(txtMESEX.Text);
                int año = Convert.ToInt16(txtAÑOEX.Text); ;

                this.dataGridView1.DataSource = Ntabla.Funcionarios();
                Guardar_archivo("ARCHIVOS/funcionarios.txt");
                this.dataGridView1.DataSource = Ntabla.Productos();
                Guardar_archivo("ARCHIVOS/productos.txt");
                this.dataGridView1.DataSource = Ntabla.Laboratorios();
                Guardar_archivo("ARCHIVOS/laboratorio.txt");
                this.dataGridView1.DataSource = Ntabla.Tipo_Producto();
                Guardar_archivo("ARCHIVOS/tipo_productos.txt");
                this.dataGridView1.DataSource = Ntabla.Cliente();
                Guardar_archivo("ARCHIVOS/clientes.txt");
                this.dataGridView1.DataSource = Ntabla.Tiempo(mes, año);
                Guardar_archivo_tiempo("ARCHIVOS/tiempo.txt");
                this.dataGridView1.DataSource = Ntabla.Hventa(mes, año);
                Guardar_archivo_hventa("ARCHIVOS/venta.txt");

                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Error, No se ha encontrado datos en el periodo para exportar");
                }
                else
                {
                    DateTime fecha = DateTime.Today;
                   string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                   string hora= DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                
                    MessageBox.Show("Datos exportados correctamente");

                    resp = Nregistrar_DW.RegistrarDW(Program.id_usuario, lbMES.Text, txtAÑOEX.Text, hora, fecha_Actual);
                    ultimo_exportado();
                    sugerir();
                    cambiar_mes();

                }
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
                      Linea= Linea.Replace(",", ".");
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtMESEX_TextChanged(object sender, EventArgs e)
        {
            string mes = txtMESEX.Text;
            if (mes == "1")
                lbMES.Text = "Enero";
            else if (mes == "2")
                lbMES.Text = "Febrero";
            else if(mes == "3")
                lbMES.Text = "Marzo";
            else if(mes == "4")
                lbMES.Text = "Abril";
            else if(mes == "5")
                lbMES.Text = "Mayo";
            else if(mes == "6")
                lbMES.Text = "Junio";
            else if(mes == "7")
                lbMES.Text = "Julio";
            else if(mes == "8")
                lbMES.Text = "Agosto";
            else if(mes == "9")
                lbMES.Text = "Septiembre";
            else if(mes == "10")
                lbMES.Text = "Octubre";
            else if(mes == "11")
                lbMES.Text = "Noviembre";
            else if(mes == "12")
                lbMES.Text = "Diciembre";
            else
                lbMES.Text = "Mes";
        }

        public void cambiar_mes() {
            string mes = txtMESEX.Text;
            if (mes == "1")
                lbMES.Text = "Enero";
            else if (mes == "2")
                lbMES.Text = "Febrero";
            else if (mes == "3")
                lbMES.Text = "Marzo";
            else if (mes == "4")
                lbMES.Text = "Abril";
            else if (mes == "5")
                lbMES.Text = "Mayo";
            else if (mes == "6")
                lbMES.Text = "Junio";
            else if (mes == "7")
                lbMES.Text = "Julio";
            else if (mes == "8")
                lbMES.Text = "Agosto";
            else if (mes == "9")
                lbMES.Text = "Septiembre";
            else if (mes == "10")
                lbMES.Text = "Octubre";
            else if (mes == "11")
                lbMES.Text = "Noviembre";
            else if (mes == "12")
                lbMES.Text = "Diciembre";
            else
                lbMES.Text = "Mes";
        }
        private void frm_EXPORTAR_Load(object sender, EventArgs e)
        {
            ultimo_exportado();
            sugerir();
            cambiar_mes();

        }
        public void ultimo_exportado() {
            this.dataGridView1.DataSource = Nregistrar_DW.Mostrar_ULTI();
            txtAÑO.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string mes = dataGridView1.Rows[0].Cells[2].Value.ToString();
            if (mes == "Enero")
            {
                txtMES.Text = "1";
                lbMES2.Text = "Enero";
            }
            else if (mes == "Febrero")
            {
                txtMES.Text = "2";
                lbMES2.Text = "Febrero";
            }
            else if (mes == "Marzo")
            {
                txtMES.Text = "3";
                lbMES2.Text = "Marzo";
            }
            else if (mes == "Abril")
            {
                txtMES.Text = "4";
                lbMES2.Text = "Abril";
            }
            else if (mes == "Mayo")
            {
                txtMES.Text = "5";
                lbMES2.Text = "Mayo";
            }
            else if (mes == "Junio")
            {
                txtMES.Text = "6";
                lbMES2.Text = "Junio";
            }
            else if (mes == "Julio")
            {
                txtMES.Text = "7";
                lbMES2.Text = "Julio";
            }
            else if (mes == "Agosto")
            {
                txtMES.Text = "8";
                lbMES2.Text = "Agosto";
            }
            else if (mes == "Septiembre")
            {
                txtMES.Text = "9";
                lbMES2.Text = "Septiembre";
            }
            else if (mes == "Octubre")
            {
                txtMES.Text = "10";
                lbMES2.Text = "Octubre";
            }
            else if (mes == "Noviembre")
            {
                txtMES.Text = "11";
                lbMES2.Text = "Noviembre";
            }
            else if (mes == "Diciembre")
            {
                txtMES.Text = "12";
                lbMES2.Text = "Diciembre";
            }
            else
                txtMES.Text = "Mes";
        }

        public void sugerir() {

            int año =Convert.ToInt16( txtAÑO.Text);
            int mes= Convert.ToInt16(txtMES.Text);

            if (mes == 12)
            {
                año = año + 1;
                mes = 1;
            }
            else {
                mes = mes + 1;
            }

            txtAÑOEX.Text = año.ToString();
            txtMESEX.Text = mes.ToString();

        }
    }
}
