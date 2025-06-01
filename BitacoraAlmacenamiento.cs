using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compass
{
    /// <summary>
    /// Opciones de almacenamiento para una bitácora.-
    /// </summary>
    public enum BitacoraAlmacenamiento : int
    {
        /// <summary>
        /// Bitácora almacenada en base de datos.-
        /// </summary>
        BaseDeDatos = 1,
        
        /// <summary>
        /// Bitácora almacenada en archivos.-
        /// </summary>
        Archivo = 2
    }
}
