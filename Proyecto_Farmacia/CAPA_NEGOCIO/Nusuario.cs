using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CAPA_LOGICA;
using System.Data.SqlClient;
using System.Data;

namespace CAPA_NEGOCIO
{
   public class Nusuario
    {





        public static DataTable Login(string usuario, string password)
        {
            Dusuario obj = new Dusuario();
            obj.Usuario = usuario;
            obj.Password = password;//CifrarCadena(password);

            return obj.Login(obj);
        }



        public static string Registrar(string nombre, string apellido, string telefono, string sexo, string observacion, string usuario, string contraseña)
        {
            Dusuario obj = new Dusuario();
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Telefono = telefono;
            obj.Sexo = sexo;
            obj.Observacion = observacion;
            obj.Usuario = usuario;
            obj.Password = contraseña;
            return obj.Registrar(obj);

        }



        public static string Editar(int id,string nombre, string apellido, string telefono, string sexo, string observacion, string usuario, string contraseña)
        {
            Dusuario obj = new Dusuario();
            obj.Id_usuario = id;
            obj.Nombre = nombre;
            obj.Apellido = apellido;
            obj.Telefono = telefono;
            obj.Sexo = sexo;
            obj.Observacion = observacion;
            obj.Usuario = usuario;
            obj.Password = contraseña;
            return obj.Editar(obj);

        }



        public static string Eliminar(int id)
        {
            Dusuario obj = new Dusuario();
            obj.Id_usuario = id;

            return obj.Eliminar(obj);
        }



        public static DataTable MostrarTodo()
        {
            return new Dusuario().MostrarTodo();
        }

        public static string Cambiar_Estado(string estado, int id)
        {
            Dusuario obj = new Dusuario();
            obj.Estado = estado;
            obj.Id_usuario = id;

            return obj.CambiarEstado(obj);
        }
        public static DataTable Mostrar_Campo(string campo,string texto)
        {
            return new Dusuario().Mostrar_campo(campo,texto);
        }
    }
}
