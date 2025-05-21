using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compass
{
    public class BitacoraBaseDeDatos : Bitacora 
    {
        public string Servidor { get; set; }
        public string Descripcion { get; set; }
        public string BaseDeDatos { get; set; }
        public string Tabla { get; set; }
        public bool  SeguridadIntegrada { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool EncriptarPassword { get; set; }
    }
}
