using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_LOGICA;

using System.Data;


namespace CAPA_NEGOCIO
{
   public class Nregistrar_DW_imp
    {
        public static string RegistrarDW_imp(string id_usuario, string hora, string fecha)
        {
            DregistrarDW_imp obj = new DregistrarDW_imp();
            obj.Id_usuario = id_usuario;
        
            obj.Hora = hora;
            obj.Fecha = fecha;
            return obj.RegistrarDW_imp(obj);

        }

        public static DataTable Mostrar()
        {
            return new DregistrarDW_imp().Mostrar();
        }
       
        public static DataTable Mostrar_campo(DateTime desde, DateTime hasta)
        {
            return new DregistrarDW_imp().Mostrar_Campo(desde,hasta);
        }

    }
}
