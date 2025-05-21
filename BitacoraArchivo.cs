using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace compass
{
    public class BitacoraArchivo : Bitacora
    {
		public string Ruta { get; set; }
		public string NombreArchivo { get; set; }
        public string Extension { get; set; }
        public string Separador { get; set; }
		public int Limite { get; set; }	
    }
}
