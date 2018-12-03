using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
         public static string id_usuario ="0";
        public static string nombre = "";
        public static string apellido = "";
        public static string telefono = "";
        public static string sexo = "";
        public static string observacion = "";
        public static string usuario = "";
        public static string pass = "";
        public static string estado = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
