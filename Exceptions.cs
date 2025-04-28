using System;
using System.Collections.Generic;
using System.Text;

namespace compass
{
    /// <summary>
    /// Excepción que se produce cuando no se puede encontrar un ambiente.-
    /// </summary>
    public class AmbienteNoEncontradoException : Exception
    {
        public AmbienteNoEncontradoException()
            : base("No se ha podido encontrar el ambiente.-")
        {
        }

        public AmbienteNoEncontradoException(string mensaje)
            : base(mensaje)
        {
        }

        public AmbienteNoEncontradoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando no se puede crear un ambiente.-
    /// </summary>
    public class AmbienteNoCreadoException : Exception
    {
        public AmbienteNoCreadoException()
            : base("No se ha podido crear el ambiente.-")
        {
        }

        public AmbienteNoCreadoException(string mensaje)
            : base(mensaje)
        {
        }

        public AmbienteNoCreadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

    /// <summary>
    /// Excepción que se produce cuando se encuentra un ambiente con datos no válidos.-
    /// </summary>
    public class AmbienteNoValidoException : Exception
    {
        public AmbienteNoValidoException()
            : base("El ambiente recuperado contiene datos no válidos.-")
        {
        }

        public AmbienteNoValidoException(string mensaje)
            : base(mensaje)
        {
        }

        public AmbienteNoValidoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }


    /// <summary>
    /// Excepción que se produce cuando no se puede cambiar un ambiente.-
    /// </summary>
    public class AmbienteNoCambiadoException : Exception
    {
        public AmbienteNoCambiadoException()
            : base("No se ha podido cambiar el ambiente.-")
        {
        }

        public AmbienteNoCambiadoException(string mensaje)
            : base(mensaje)
        {
        }

        public AmbienteNoCambiadoException(string mensaje, Exception interna)
            : base(mensaje, interna)
        {
        }
    }

}
