using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CAPA_LOGICA
{
   public  class Dtabla
    {

        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
      
        DataTable tablaResultados;
        public DataTable Funcionarios()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_FUNCIONARIOS";
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

        public DataTable Productos()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_PRODUCTOS";
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
        public DataTable Laboratorios()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_LABORATORIO";
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
        public DataTable Tipo_Producto()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_TIPO_PRODUCTO";
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

        public DataTable Cliente()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_CLIENTES";
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
        public DataTable Tiempo(int mes, int año)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_TIEMPO";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@MES", mes);
                Sqlcmd.Parameters.AddWithValue("@AÑO", año);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;

        }

        public DataTable Tiempo_general()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_TIEMPO_GENERAL";
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
        public DataTable Hventa(int mes, int año)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_HVENTA";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@MES", mes);
                Sqlcmd.Parameters.AddWithValue("@AÑO", año);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;

        }

        public DataTable Hventa_general()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "SELECCIONAR_HVENTA_GENERAL";
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
