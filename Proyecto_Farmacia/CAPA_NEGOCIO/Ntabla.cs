using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CAPA_LOGICA;

namespace CAPA_NEGOCIO
{
   public class Ntabla
    {

        public static DataTable Funcionarios()
        {
            return new Dtabla().Funcionarios();
        }
        public static DataTable Productos()
        {
            return new Dtabla().Productos();
        }

        public static DataTable Laboratorios()
        {
            return new Dtabla().Laboratorios();
        }

        public static DataTable Tipo_Producto()
        {
            return new Dtabla().Tipo_Producto();
        }
        public static DataTable Cliente()
        {
            return new Dtabla().Cliente();
        }
        public static DataTable Tiempo(int mes, int año)
        {
            return new Dtabla().Tiempo(mes, año);
        }
        public static DataTable Tiempo_general()
        {
            return new Dtabla().Tiempo_general();
        }
        public static DataTable Hventa(int mes, int año)
        {
            return new Dtabla().Hventa(mes, año);
        }
        public static DataTable Hventa_general()
        {
            return new Dtabla().Hventa_general();
        }

    }
}
