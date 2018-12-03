using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace CAPA_LOGICA
{
   public class Dusuario
    {
        private int _id_usuario;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _sexo;
        private string _observacion;
        private string _usuario;
        private string _password;
        private string _estado;



        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;


        public int Id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public DataTable Login(Dusuario usuario)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();


            try
            {
                SqlCn.ConnectionString = Conexion.cn;
                SqlCn.Open();

                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_Login";
                Sqlcmd.CommandType = CommandType.StoredProcedure;


                Sqlcmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                Sqlcmd.Parameters.AddWithValue("@password", usuario.Password);

                SqlDataAdapter Sqldat = new SqlDataAdapter(Sqlcmd);
                Sqldat.Fill(tablaResultados);

            }
            catch (Exception ex)
            {
                tablaResultados = null;
            }

            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                {
                    SqlCn.Close();
                }
            }

            return tablaResultados;

        }

        public string Registrar(Dusuario usuario)
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
                Sqlcmd.CommandText = "registrar_usuario";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                Sqlcmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                Sqlcmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                Sqlcmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
                Sqlcmd.Parameters.AddWithValue("@observacion", usuario.Observacion);
                Sqlcmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                Sqlcmd.Parameters.AddWithValue("@contraseña", usuario.Password);


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


        public string Editar(Dusuario usuario)
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
                Sqlcmd.CommandText = "modificar_usuario";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@id", usuario.Id_usuario);
                Sqlcmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                Sqlcmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                Sqlcmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                Sqlcmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
                Sqlcmd.Parameters.AddWithValue("@observacion", usuario.Observacion);
                Sqlcmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                Sqlcmd.Parameters.AddWithValue("@contraseña", usuario.Password);


                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo editar el registro.";


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


        public string Eliminar(Dusuario usuario)
        {
            string resp = "";
            SqlCn = new SqlConnection();
            try
            {

                SqlCn.ConnectionString = Conexion.cn;
                SqlCn.Open();

                Sqltra = SqlCn.BeginTransaction();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "eliminar_usuario";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@id", usuario.Id_usuario);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo eliminar el registro.";

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
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }
            return resp;
        }

        public DataTable MostrarTodo()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "mostrar_todo_usuario";

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



        public string CambiarEstado(Dusuario usuario)
        {
            string resp = "";
            SqlCn = new SqlConnection();
            try
            {

                SqlCn.ConnectionString = Conexion.cn;
                SqlCn.Open();

                Sqltra = SqlCn.BeginTransaction();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "cambiar_Estado_usuario";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                Sqlcmd.Parameters.AddWithValue("@estado", usuario.Estado);
                Sqlcmd.Parameters.AddWithValue("@id", usuario.Id_usuario);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo cambiar el estado.";

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
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }
            return resp;
        }


        public DataTable Mostrar_campo(string campo,string texto)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = Conexion.cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "buscar_usuario_Campo";

                Sqlcmd.Parameters.AddWithValue("@campo", campo);
                Sqlcmd.Parameters.AddWithValue("@texto", texto);


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
