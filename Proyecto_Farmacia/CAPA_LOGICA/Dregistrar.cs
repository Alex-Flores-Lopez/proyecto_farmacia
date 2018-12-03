using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CAPA_LOGICA
{
  public  class Dregistrar
    {
        SqlCommand Sqlcmd;
        SqlConnection SqlCn;

        public string Cargar(string nombre)
        {
            string rpta = "";
            SqlCn = new SqlConnection();
            try
            {

                SqlCn.ConnectionString = Conexion.cn;
                SqlCn.Open();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = nombre;
                Sqlcmd.CommandType = CommandType.StoredProcedure;

            

                rpta = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "NO se Elimino el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }
            return rpta;
        }

    }

}
