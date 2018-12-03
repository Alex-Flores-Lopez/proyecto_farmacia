using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_LOGICA;

using System.Data;


namespace CAPA_NEGOCIO
{
   public class Nregistrar_DW
    {
        public static string RegistrarDW(string id_usuario, string mes, string año, string hora, string fecha)
        {
            DregistrarDW obj = new DregistrarDW();
            obj.Id_usuario = id_usuario;
            obj.Mes = mes;
            obj.Año = año;
            obj.Hora = hora;
            obj.Fecha = fecha;
            return obj.RegistrarDW(obj);

        }

        public static DataTable Mostrar()
        {
            return new DregistrarDW().Mostrar();
        }
        public static DataTable Mostrar_ULTI()
        {
            return new DregistrarDW().Mostrar_ULTI();
        }
        public static DataTable Mostrar_campo(DateTime desde, DateTime hasta)
        {
            return new DregistrarDW().Mostrar_Campo(desde,hasta);
        }

    }
}
