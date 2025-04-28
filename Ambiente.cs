using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace compass
{
    public class Ambiente
    {
        #region atributos

        private string nombre;

        private string descripcion;

        private string servidor;

        private string baseDeDatos;

        private bool seguridadIntegrada;

        private string usuario;

        private string password;

        private bool encriptarPassword;

        #endregion

        #region propiedades

        public string Nombre
        {
            get { return nombre; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set {  Descripcion = value; }    
        }

        public string Servidor
        {
            get { return servidor; }
            set { Servidor = value; }
        }

        public string BaseDeDatos
        {
            get { return baseDeDatos; }
            set { baseDeDatos = value; }
        }

        public bool SeguridadIntegrada
        {
            get { return seguridadIntegrada; }
            set { seguridadIntegrada = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool EncriptarPassword
        {
            get { return encriptarPassword; }
            set { encriptarPassword = value; }
        }

        #endregion

        private const string C_NOMBRE_ARCHIVO_XML = "Ambientes.xml";
        private const string C_AMBIENTE = "Ambiente";
        private const string C_AMBIENTES = "Ambientes";
        private const string C_NOMBRE = "Nombre";
        private const string C_DESCRIPCION = "Descripcion";
        private const string C_SERVIDOR = "Servidor";
        private const string C_BASE_DE_DATOS = "BaseDeDatos";
        private const string C_SEGURIDAD_INTEGRADA = "SeguridadIntegrada";
        private const string C_USUARIO = "Usuario";
        private const string C_PASSWORD = "Password";
        private const string C_ENCRIPTAR_PASSWORD = "EncriptarPassword";

        /// <summary>
        /// Obtiene la lista de ambientes configurados.-
        /// </summary>
        /// <returns></returns>
        public static List<Ambiente> Obtener()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string? rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            List<Ambiente> listaParaDevolver = new List<Ambiente>();

            //Se verifica que exista el archivo de sistemas.
            if (File.Exists(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML))
            {
                // se Carga todo el XML en el objeto libro
                XDocument xmlAmbientes = XDocument.Load(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML);
                XElement? listaAmbientes = xmlAmbientes.Element("Ambientes");
                IEnumerable<XElement> ambientes = listaAmbientes.Descendants("Ambiente");

                //haz un foreach y por cada uno haz lo que tengas que hacer
                foreach (XElement a in ambientes)
                {
                    bool axSeguridadIntegrada = System.Convert.ToBoolean(a.Element(C_SEGURIDAD_INTEGRADA).Value.ToString());
                    Ambiente nuevoAmbiente;

                    if (axSeguridadIntegrada)
                        nuevoAmbiente = new Ambiente(a.Element(C_NOMBRE).Value.ToString(), a.Element(C_DESCRIPCION).Value.ToString(), a.Element(C_SERVIDOR).Value.ToString(), a.Element(C_BASE_DE_DATOS).Value.ToString());
                    else
                        nuevoAmbiente = new Ambiente(a.Element(C_NOMBRE).Value.ToString(), a.Element(C_DESCRIPCION).Value.ToString(), a.Element(C_SERVIDOR).Value.ToString(), a.Element(C_BASE_DE_DATOS).Value.ToString(), a.Element(C_USUARIO).Value.ToString(), a.Element(C_PASSWORD).Value.ToString(), System.Convert.ToBoolean(a.Element(C_ENCRIPTAR_PASSWORD).Value.ToString()));

                    listaParaDevolver.Add(nuevoAmbiente);
                }
            }

            return listaParaDevolver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreBuscado"></param>
        /// <exception cref="AmbienteNoEncontradoException"></exception>
        public Ambiente (string nombreBuscado)
        {
            List<Ambiente>? ambientesConfigurados = new List<Ambiente>();
            ambientesConfigurados = Ambiente.Obtener();

            int x = ambientesConfigurados.FindIndex(s => s.nombre == nombreBuscado);
            if (x == -1)
            {
                throw new AmbienteNoEncontradoException();
            }
            else
            {
                Ambiente ambienteEncontrado = ambientesConfigurados.Find(s => s.Nombre == nombreBuscado);
                this.nombre = ambienteEncontrado.nombre;
                this.descripcion = ambienteEncontrado.descripcion;
                this.servidor = ambienteEncontrado.Servidor;
                this.baseDeDatos = ambienteEncontrado.BaseDeDatos;
                this.seguridadIntegrada = ambienteEncontrado.SeguridadIntegrada;
                this.usuario = ambienteEncontrado.Usuario;
                this.password = ambienteEncontrado.Password;
                this.encriptarPassword= ambienteEncontrado.EncriptarPassword;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoNombre"></param>
        /// <param name="nuevaDescripcion"></param>
        /// <param name="nuevoServidor"></param>
        /// <param name="nuevaBaseDeDatos"></param>
        public Ambiente(string nuevoNombre, string nuevaDescripcion, string nuevoServidor, string nuevaBaseDeDatos)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.servidor = nuevoServidor;
            this.baseDeDatos = nuevaBaseDeDatos;
            this.seguridadIntegrada = true;
            this.usuario = "";
            this.password = "";
            this.encriptarPassword = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoNombre"></param>
        /// <param name="nuevaDescripcion"></param>
        /// <param name="nuevoServidor"></param>
        /// <param name="nuevaBaseDeDatos"></param>
        /// <param name="nuevoUsuario"></param>
        /// <param name="nuevaPassword"></param>
        /// <param name="nuevaEncriptarPassword"></param>
        public Ambiente(string nuevoNombre, string nuevaDescripcion, string nuevoServidor, string nuevaBaseDeDatos, string nuevoUsuario, string nuevaPassword, bool nuevaEncriptarPassword)
        {
            this.nombre = nuevoNombre;
            this.descripcion = nuevaDescripcion;
            this.servidor = nuevoServidor;
            this.baseDeDatos = nuevaBaseDeDatos;
            this.seguridadIntegrada = false;
            this.usuario = nuevoUsuario;
            this.password = nuevaPassword;
            this.encriptarPassword = nuevaEncriptarPassword;
        }


        /// <summary>
        /// 
        /// </summary>
        public static void GenerarArchivoINI()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoAmbiente"></param>
        public  static void Guardar( Ambiente ambienteParaGuardar)
        {
            List<Ambiente> ambientesExistentes = Ambiente.Obtener();
            ambientesExistentes.Add(ambienteParaGuardar);

            borrarArchivoXML();
            crearArchivoXML(ambientesExistentes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ambienteParaActualizar"></param>
        public static void Actualizar(Ambiente ambienteParaActualizar)
        {
            List<Ambiente> ambientesExistentes = Ambiente.Obtener();

            ambientesExistentes.RemoveAll(x => x.Nombre == ambienteParaActualizar.Nombre);
            ambientesExistentes.Add(ambienteParaActualizar);

            borrarArchivoXML();
            crearArchivoXML(ambientesExistentes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ambienteParaEliminar"></param>
        public static void Eliminar(Ambiente ambienteParaEliminar)
        {
            List<Ambiente> ambientesExistentes = Ambiente.Obtener();
            ambientesExistentes.RemoveAll(x => x.Nombre == ambienteParaEliminar.Nombre);

            borrarArchivoXML();
            crearArchivoXML(ambientesExistentes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ambientesExistentes"></param>
        private static void crearArchivoXML(List<Ambiente> ambientesExistentes)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string? rutaArchivo = Path.GetDirectoryName(myAssembly.Location);

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, C_AMBIENTES, string.Empty);
            doc.AppendChild(element1);

            foreach (Ambiente a in ambientesExistentes)
            {
                XmlElement ambiente = doc.CreateElement(string.Empty, C_AMBIENTE, string.Empty);
                element1.AppendChild(ambiente);

                XmlElement nombre = doc.CreateElement(string.Empty, C_NOMBRE, string.Empty);
                XmlElement descripcion = doc.CreateElement(string.Empty, C_DESCRIPCION, string.Empty);
                XmlElement servidor = doc.CreateElement(string.Empty, C_SERVIDOR, string.Empty);
                XmlElement baseDeDatos = doc.CreateElement(string.Empty, C_BASE_DE_DATOS, string.Empty);
                XmlElement seguridadIntegrada = doc.CreateElement(string.Empty, C_SEGURIDAD_INTEGRADA, string.Empty);
                XmlElement usuario = doc.CreateElement(string.Empty, C_USUARIO, string.Empty);
                XmlElement password = doc.CreateElement(string.Empty, C_PASSWORD, string.Empty);
                XmlElement encriptarPassword = doc.CreateElement(string.Empty, C_ENCRIPTAR_PASSWORD, string.Empty);

                ambiente.AppendChild(nombre);
                ambiente.AppendChild(descripcion);
                ambiente.AppendChild(servidor);
                ambiente.AppendChild(baseDeDatos);
                ambiente.AppendChild(seguridadIntegrada);
                ambiente.AppendChild(usuario);
                ambiente.AppendChild(password);
                ambiente.AppendChild(encriptarPassword);

                XmlText texto_Nombre = doc.CreateTextNode(a.Nombre);
                XmlText texto_Descripcion = doc.CreateTextNode(a.Descripcion);
                XmlText texto_Servidor = doc.CreateTextNode(a.Servidor);
                XmlText texto_BaseDeDatos = doc.CreateTextNode(a.BaseDeDatos);
                XmlText texto_SeguridadIntegrada = doc.CreateTextNode(a.SeguridadIntegrada.ToString());
                XmlText texto_Usuario = doc.CreateTextNode(a.Usuario);
                XmlText texto_Password = doc.CreateTextNode(a.Password);
                XmlText texto_EncriptarPassword = doc.CreateTextNode(a.encriptarPassword.ToString());

                nombre.AppendChild(texto_Nombre);
                descripcion.AppendChild(texto_Descripcion);
                servidor.AppendChild(texto_Servidor);
                baseDeDatos.AppendChild(texto_BaseDeDatos);
                seguridadIntegrada.AppendChild(texto_SeguridadIntegrada);
                usuario.AppendChild(texto_Usuario);
                password.AppendChild(texto_Password);
                encriptarPassword.AppendChild(texto_EncriptarPassword);
            }

            doc.Save(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void borrarArchivoXML()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string? rutaArchivo = Path.GetDirectoryName(myAssembly.Location);

            if (File.Exists(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML))
                File.Delete(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML);
        }
    }
}
