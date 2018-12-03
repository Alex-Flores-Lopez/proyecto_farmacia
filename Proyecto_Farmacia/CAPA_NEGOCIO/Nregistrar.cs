using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_LOGICA;
using System.Windows.Forms;

using System.Data;

namespace CAPA_NEGOCIO
{
   public class Nregistrar
    {
        public static string Cargar(string nombre)
        {
            return new Dregistrar().Cargar(nombre);
        }
    }
}
