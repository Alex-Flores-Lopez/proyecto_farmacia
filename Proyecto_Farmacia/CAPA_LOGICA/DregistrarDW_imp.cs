using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace CAPA_LOGICA
{
   public class DregistrarDW_imp
    {
        private string _idusuario;
        private string _hora;
        private string _fecha;



        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;



        public string Id_usuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }


        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string RegistrarDW_imp(DregistrarDW_imp registrarDW_imp)
        {
            string resp = "";

            try
            {

                SqlCn = new SqlConnection();
                Sqlcmd = new SqlCommand();

                SqlCn.ConnectionString = Conexion.cn;
                SqlCn.Open();

                Sqltra = SqlCn.BeginTransaction();

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "registrar_dw_imp";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@id_usuario", registrarDW_imp.Id_usuario);
                Sqlcmd.Parameters.AddWithValue("@hora", registrarDW_imp.Hora);
                Sqlcmd.Parameters.AddWithValue("@fecha", registrarDW_imp.Fecha);
 


                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo registrar";


                if (resp.Equals("ok"))
                {
                    Sqltra.Commit();
                }
                else
                {
                    Sqltra.Rollback();
                }
            }

            catch (Exception ex)
            {
                resp = ex.Message;

            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;

        }

        public DataTable Mostrar()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "obtener_registroDW_imp";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
        
        public DataTable Mostrar_Campo(DateTime desde, DateTime hasta)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.Parameters.AddWithValue("@desde", desde);
                Sqlcmd.Parameters.AddWithValue("@hasta", hasta);
                Sqlcmd.CommandText = "buscar_registroDW_imp";

                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
    }
}
