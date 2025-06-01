using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace compass
{
    /// <summary>
    /// Modela un ambiente.-
    /// </summary>
    public class Ambiente
    {
        #region atributos

        /// <summary>
        /// Nombre del ambiente.-
        /// </summary>
        private string nombre;

        /// <summary>
        /// Descripción del ambiente.-
        /// </summary>
        private string descripcion;

        /// <summary>
        /// Servidor del ambiente.-
        /// </summary>
        private string servidor;

        /// <summary>
        /// Nombre de la base de datos del ambiente.-
        /// </summary>
        private string baseDeDatos;

        /// <summary>
        /// Indica si el ambiente usa la seguridad integrada para la conexión al mismo.-
        /// </summary>
        private bool seguridadIntegrada;

        /// <summary>
        /// Nombre del usuario para la conexión al ambiente.-
        /// </summary>
        private string usuario;

        /// <summary>
        /// Contraseña para la conexión al ambiente.-
        /// </summary>
        private string password;

        /// <summary>
        /// Indica si la contraseña para el acceso al ambiente está encriptada o no.-
        /// </summary>
        private bool encriptarPassword;

        /// <summary>
        /// Lista de las bitácoras del ambiente.-
        /// </summary>
        List<Bitacora>? misBitacoras;

        #endregion

        #region propiedades

        /// <summary>
        /// Obtiene el nombre del ambiente.-
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
        }

        /// <summary>
        /// Obtiene la descripción del ambiente.-
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set {  descripcion = value; }    
        }

        /// <summary>
        /// Obtiene el nombre del servidor del ambiente.-
        /// </summary>
        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        /// <summary>
        /// Obtiene la base de datos a utilizar para el ambiente.-
        /// </summary>
        public string BaseDeDatos
        {
            get { return baseDeDatos; }
            set { baseDeDatos = value; }
        }

        /// <summary>
        /// Obtiene el valor que indica si el ambiente utiliza Seguridad Integrada o no.-
        /// </summary>
        public bool SeguridadIntegrada
        {
            get { return seguridadIntegrada; }
            set { seguridadIntegrada = value; }
        }

        /// <summary>
        /// Obtiene el nombre del usuario para la conexión con el ambiente.-
        /// </summary>
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        /// <summary>
        /// Obtiene la contraseña para la conexión con el ambiente.-
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Obtiene el valor que indica si debe o no encriptarse la contraseña para la conexión con el ambiente.- 
        /// </summary>
        public bool EncriptarPassword
        {
            get { return encriptarPassword; }
            set { encriptarPassword = value; }
        }

        /// <summary>
        /// Lista de las bitácoras asociadas al ambiente.-
        /// </summary>
        public List<Bitacora> MisBitacoras
        {
            get { return misBitacoras ; }
            set { misBitacoras = value; }
        }

        #endregion

        #region constantes

        private const string C_ALMACENAMIENTO = "Almacenamiento";
        private const string C_AMBIENTE = "Ambiente";
        private const string C_AMBIENTES = "Ambientes";
        private const string C_BASE_DE_DATOS = "BaseDeDatos";
        private const string C_BITACORA = "Bitacora";
        private const string C_BITACORAS = "Bitacoras";
        private const string C_DESCRIPCION = "Descripcion";
        private const string C_ENCRIPTAR_PASSWORD = "EncriptarPassword";
        private const string C_EXTENSION = "Extension";
        private const string C_LIMITE = "Limite";
        private const string C_NOMBRE = "Nombre";
        private const string C_NOMBRE_ARCHIVO = "NombreArchivo";
        private const string C_NOMBRE_ARCHIVO_XML = "Ambientes.xml";
        private const string C_SEGURIDAD_INTEGRADA = "SeguridadIntegrada";
        private const string C_SEPARADOR = "Separador";
        private const string C_SERVIDOR = "Servidor";
        private const string C_USUARIO = "Usuario";
        private const string C_PASSWORD = "Password";
        private const string C_RUTA = "Ruta";
        private const string C_TABLA = "Tabla";
        private const string C_NOMBRE_ARCHIVO_INI = "TrinidadDb.ini";
        private const string C_NOMBRE_ARCHIVO_BITACORAS = "Bitacora.ini";

        #endregion

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
                //Se carga todo el XML en el objeto xmlAmbientes
                XDocument xmlAmbientes = XDocument.Load(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML);
                XElement? listaAmbientes = xmlAmbientes.Element(C_AMBIENTES);
                IEnumerable<XElement> ambientes = listaAmbientes.Descendants(C_AMBIENTE);

                //Se cicla por cada elemento y se cada uno haz lo que tengas que hacer
                foreach (XElement a in ambientes)
                    listaParaDevolver.Add(new Ambiente(a));
            }

            return listaParaDevolver;
        }

        /// <summary>
        /// Obtiene los nombres de los ambientes configurados.-
        /// </summary>
        /// <returns></returns>
        public static List<string> ObtenerNombres()
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string? rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            List<string> listaParaDevolver = new List<string>();

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
                    listaParaDevolver.Add(a.Element(C_NOMBRE).Value.ToString());
                }
            }

            return listaParaDevolver;
        }

        /// <summary>
        /// Constructor: genera un ambiente nuevo con los datos contenidos en el elemento XML recibido por parámetro.-
        /// </summary>
        /// <param name="ambienteRecuperado">Elemento XML con los datos para armar un nuevo ambiente.-</param>
        private Ambiente(XElement ambienteRecuperado)
        {
            this.nombre = ambienteRecuperado.Element(C_NOMBRE).Value.ToString();
            this.descripcion = ambienteRecuperado.Element(C_DESCRIPCION).Value.ToString();
            this.servidor = ambienteRecuperado.Element(C_SERVIDOR).Value.ToString();
            this.baseDeDatos = ambienteRecuperado.Element(C_BASE_DE_DATOS).Value.ToString();
            this.seguridadIntegrada = System.Convert.ToBoolean(ambienteRecuperado.Element(C_SEGURIDAD_INTEGRADA).Value.ToString());
            this.encriptarPassword = System.Convert.ToBoolean(ambienteRecuperado.Element(C_ENCRIPTAR_PASSWORD).Value.ToString());
            this.usuario = ambienteRecuperado.Element(C_USUARIO).Value.ToString();
            this.password = ambienteRecuperado.Element(C_PASSWORD).Value.ToString();

            this.misBitacoras = new List<Bitacora>(); 

            IEnumerable<XElement> bitacoras = ambienteRecuperado.Descendants("Bitacoras");
            if (bitacoras != null)
            {
                IEnumerable<XElement> bitacora = bitacoras.Descendants("Bitacora");
                foreach (XElement x in bitacora)
                {
                    if (x.Element("Almacenamiento").Value.ToString() == "1")
                    {
                        BitacoraBaseDeDatos bit_base = new BitacoraBaseDeDatos
                        {
                            Almacenamiento = BitacoraAlmacenamiento.BaseDeDatos,
                            Nombre = x.Element(C_NOMBRE).Value.ToString(),
                            Servidor = x.Element(C_SERVIDOR).Value.ToString(),
                            BaseDeDatos = x.Element(C_BASE_DE_DATOS).Value.ToString(),
                            Tabla = x.Element(C_TABLA).Value.ToString(),
                            SeguridadIntegrada = System.Convert.ToBoolean(x.Element(C_SEGURIDAD_INTEGRADA).Value),
                            Usuario = x.Element(C_USUARIO).Value.ToString(),
                            Password = x.Element(C_PASSWORD).Value.ToString(),
                            EncriptarPassword = System.Convert.ToBoolean(x.Element(C_ENCRIPTAR_PASSWORD).Value)
                        };

                        misBitacoras.Add(bit_base);
                    }

                    if (x.Element("Almacenamiento").Value.ToString() == "2")
                    {
                        BitacoraArchivo bit_archivo = new BitacoraArchivo
                        {
                            Almacenamiento = BitacoraAlmacenamiento.Archivo,
                            Nombre = x.Element("Nombre").Value.ToString(),
                            Ruta = x.Element("Ruta").Value.ToString(),
                            NombreArchivo = x.Element(C_NOMBRE_ARCHIVO).Value.ToString(),
                            Extension = x.Element(C_EXTENSION).Value.ToString(),
                            Separador = x.Element(C_SEPARADOR).Value.ToString(),
                            Limite = System.Convert.ToInt32(x.Element(C_LIMITE).Value),
                        };

                        misBitacoras.Add(bit_archivo);
                    }
                }
            }
        }

        /// <summary>
        /// Constructor: obtiene el ambiente cuyo nombre coincida con el recibido como parámetro.-
        /// </summary>
        /// <param name="nombreBuscado">Nombre del ambiente a buscar.-</param>
        /// <exception cref="AmbienteNoEncontradoException">Excepción que se produce cuando no se encuentra el ambiente buscado.-</exception>
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
        /// Constructor: genera un nuevo ambiente a partir de los datos recibidos por parámetro.-
        /// </summary>
        /// <param name="nuevoNombre">Nombre para el nuevo ambiente.-</param>
        /// <param name="nuevaDescripcion">Descripción para el nuevo ambiente.-</param>
        /// <param name="nuevoServidor">Nombre del servidor para el nuevo ambiente.-</param>
        /// <param name="nuevaBaseDeDatos">Nombre de la base de datos para el nuevo ambiente.-</param>
        public Ambiente(string nuevoNombre, string nuevaDescripcion, string nuevoServidor, string nuevaBaseDeDatos)
        {
            //Se valida que se ingrese el nombre del ambiente.-
            if (nuevoNombre.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado el nombre para el nuevo ambiente.-");

            //Se valida que la descripción no quede vacía.-
            if (nuevaDescripcion.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado la descripción para el nuevo ambiente.-");

            //Se valida el nombre del servidor para el ambiente.-
            if (nuevoServidor.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado el servidor para el nuevo ambiente.-");

            //Se valida que el nombre de la base de datos esté informado.-
            if (nuevaBaseDeDatos.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado la base de datos para el nuevo ambiente.-");

            //Se valida que no exista otro ambiente con el mismo nombre.-
            List<string> nombres =  Ambiente.ObtenerNombres();
            if (nombres.Contains(nuevoNombre))
                throw new Exception($"Ya existe un ambiente con el nombre {nuevoNombre}.-");

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
        /// Constructor: genera un nuevo ambiente a partir de los datos recibidos por parámetro.-
        /// </summary>
        /// <param name="nuevoNombre">Nombre para el nuevo ambiente.-</param>
        /// <param name="nuevaDescripcion">Descripción para el nuevo ambiente.-</param>
        /// <param name="nuevoServidor">Nombre del servidor para el nuevo ambiente.-</param>
        /// <param name="nuevaBaseDeDatos">Nombre de la base de datos para el nuevo ambiente.-</param>
        /// <param name="nuevoUsuario">Id del usuario para el nuevo ambiente.-</param>
        /// <param name="nuevaPassword">Password para el nuevo ambiente.-</param>
        /// <param name="nuevaEncriptarPassword">Valor que indica si debe encriptarse la password para acceso al nuevo ambiente.-</param>
        public Ambiente(string nuevoNombre, string nuevaDescripcion, string nuevoServidor, string nuevaBaseDeDatos, string nuevoUsuario, string nuevaPassword, bool nuevaEncriptarPassword)
        {
            //Se valida que se ingrese el nombre del ambiente.-
            if (nuevoNombre.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado el nombre para el nuevo ambiente.-");

            //Se valida que la descripción no quede vacía.-
            if (nuevaDescripcion.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado la descripción para el nuevo ambiente.-");

            //Se valida el nombre del servidor para el ambiente.-
            if (nuevoServidor.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado el servidor para el nuevo ambiente.-");

            //Se valida que el nombre de la base de datos esté informado.-
            if (nuevaBaseDeDatos.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado la base de datos para el nuevo ambiente.-");

            //Se valida que el usuario se informe.-
            if (nuevoUsuario.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado el usuario para la conexión con el nuevo ambiente.-");

            //Se valida que se ingrese la contraseña para el usuario.-
            if (nuevaPassword.Length <= 0)
                throw new AmbienteNoValidoException("No se ha especificado la contraseña para ingresar al nuevo ambiente.-");

            //Se valida que no exista otro ambiente con el mismo nombre.-
            List<string> nombres = Ambiente.ObtenerNombres();
            if (nombres.Contains(nuevoNombre))
                throw new Exception($"Ya existe un ambiente con el nombre {nuevoNombre}.-");

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
        /// Genera el archivo INI para el acceso a datos y el correspondiente para acceso a bitácoras si es que el ambiente las tiene.-
        /// </summary>
        public void GenerarArchivosINI()
        {
            StreamWriter sr;
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string? rutaArchivo = Path.GetDirectoryName(myAssembly.Location);
            string nombreArchivo = C_NOMBRE_ARCHIVO_INI;
            string usr = "#########";
            string pwd = "#########";

            if (!seguridadIntegrada)
            {
                usr = this.Usuario;
                pwd = this.Password;
            }

            sr = new StreamWriter($"{rutaArchivo}{Path.DirectorySeparatorChar}{nombreArchivo}");
            sr.WriteLine("[DbInfo]");
            sr.WriteLine($"DataSource={this.Servidor}");
            sr.WriteLine($"Catalog={this.BaseDeDatos}");
            sr.WriteLine($"IntegratedSecurity={this.SeguridadIntegrada}");
            sr.WriteLine($"User={usr}");
            sr.WriteLine($"Pwd={pwd}");
            sr.WriteLine($"EncryptPwd={this.EncriptarPassword}");
            sr.Close();
            
            //Bitacoras
            nombreArchivo = C_NOMBRE_ARCHIVO_BITACORAS;
            sr = new StreamWriter($"{rutaArchivo}{Path.DirectorySeparatorChar}{nombreArchivo}");

            foreach (Bitacora b in misBitacoras)
            {
                sr.WriteLine($"[{b.Nombre}]");
                sr.WriteLine($"{C_ALMACENAMIENTO}={(int) b.Almacenamiento}");

                if (b.Almacenamiento == BitacoraAlmacenamiento.BaseDeDatos)
                {
                    BitacoraBaseDeDatos b1 = (BitacoraBaseDeDatos)b;
                    sr.WriteLine($"DataSource={b1.Servidor}");
                    sr.WriteLine($"Catalog={b1.BaseDeDatos}");
                    sr.WriteLine($"Table={b1.Tabla}");
                    sr.WriteLine($"IntegratedSecurity={b1.SeguridadIntegrada}");
                    sr.WriteLine($"User={b1.Usuario}");
                    sr.WriteLine($"Pwd={b1.Password}");
                    sr.WriteLine($"EncryptPwd={b1.EncriptarPassword}");
                }
                else
                {
                    BitacoraArchivo b2 = (BitacoraArchivo)b;
                    sr.WriteLine($"Ruta={b2.Ruta}");
                    sr.WriteLine($"Archivo={b2.NombreArchivo}");
                    sr.WriteLine($"Extension={b2.Extension}");
                    sr.WriteLine($"Separador={b2.Separador}");
                    sr.WriteLine($"LimiteMB={b2.Limite}");
                    sr.WriteLine($"UltimoId=0");
                    sr.WriteLine($"UltimoVolumen=0");
                }

                sr.WriteLine("");
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda el ambiente recibido como parámetro, en la lista de ambientes del sistema.-
        /// </summary>
        /// <param name="nuevoAmbiente">Ambiente nuevo para guardar en la lista.-</param>
        public  static void Guardar(Ambiente ambienteParaGuardar)
        {
            List<Ambiente> ambientesExistentes = Ambiente.Obtener();
            ambientesExistentes.Add(ambienteParaGuardar);

            borrarArchivoXML();
            crearArchivoXML(ambientesExistentes);
        }

        /// <summary>
        /// Actualiza en la lista de ambientes aquel cuyo nombre coincida con el del ambiente recibido como parámetro.-
        /// </summary>
        /// <param name="ambienteParaActualizar">Ambiente para actualizar en la lista.-</param>
        public static void Actualizar(Ambiente ambienteParaActualizar)
        {
            List<Ambiente> ambientesExistentes = Ambiente.Obtener();

            ambientesExistentes.RemoveAll(x => x.Nombre == ambienteParaActualizar.Nombre);
            ambientesExistentes.Add(ambienteParaActualizar);

            borrarArchivoXML();
            crearArchivoXML(ambientesExistentes);
        }

        /// <summary>
        /// Elimina de la lista de ambientes del sistema, el que se recibe como parámetro.-
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
        /// Crea el archivo XML donde se almacenan todos los ambientes del sistema.-
        /// </summary>
        /// <param name="ambientesExistentes">Lista de los ambientes con los que se deben crear el archivo XML.-</param>
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
                XmlText texto_EncriptarPassword = doc.CreateTextNode(a.EncriptarPassword.ToString());

                nombre.AppendChild(texto_Nombre);
                descripcion.AppendChild(texto_Descripcion);
                servidor.AppendChild(texto_Servidor);
                baseDeDatos.AppendChild(texto_BaseDeDatos);
                seguridadIntegrada.AppendChild(texto_SeguridadIntegrada);
                usuario.AppendChild(texto_Usuario);
                password.AppendChild(texto_Password);
                encriptarPassword.AppendChild(texto_EncriptarPassword);

                //Bitacoras
                if (a.MisBitacoras != null)
                {
                    XmlElement coleccionDeBitacoras = doc.CreateElement(string.Empty, C_BITACORAS, string.Empty);

                    foreach (Bitacora b in a.misBitacoras)
                    {
                        XmlElement unaBitacora = doc.CreateElement(string.Empty, C_BITACORA, string.Empty);
                        XmlElement almacenamientoBitacora = doc.CreateElement(string.Empty, C_ALMACENAMIENTO, string.Empty);
                        XmlElement nombreBitacora = doc.CreateElement(string.Empty, "Nombre", string.Empty);

                        XmlText texto_almacenamientoBitacora = doc.CreateTextNode(((int)b.Almacenamiento).ToString());
                        XmlText texto_nombreBitacora = doc.CreateTextNode(b.Nombre);

                        almacenamientoBitacora.AppendChild(texto_almacenamientoBitacora);
                        nombreBitacora.AppendChild(texto_nombreBitacora);

                        unaBitacora.AppendChild(almacenamientoBitacora);
                        unaBitacora.AppendChild(nombreBitacora);

                        if (b.Almacenamiento == BitacoraAlmacenamiento.BaseDeDatos)
                        {
                            BitacoraBaseDeDatos bitacoraAuxiliar = (BitacoraBaseDeDatos) b;
                            XmlElement bitacoraServidor = doc.CreateElement(string.Empty, C_SERVIDOR, string.Empty);
                            XmlElement bitacoraBaseDeDatos = doc.CreateElement(string.Empty, C_BASE_DE_DATOS, string.Empty);
                            XmlElement bitacoraTabla = doc.CreateElement(string.Empty, C_TABLA, string.Empty);
                            XmlElement bitacoraSeguridadIntegrada = doc.CreateElement(string.Empty, C_SEGURIDAD_INTEGRADA, string.Empty);
                            XmlElement bitacoraUsuario = doc.CreateElement(string.Empty, C_USUARIO, string.Empty);
                            XmlElement bitacoraPassword = doc.CreateElement(string.Empty, C_PASSWORD, string.Empty);
                            XmlElement bitacoraEncriptarPassword = doc.CreateElement(string.Empty, C_ENCRIPTAR_PASSWORD, string.Empty);

                            XmlText texto_bitacoraServidor = doc.CreateTextNode(bitacoraAuxiliar.Servidor);
                            XmlText texto_bitacoraBaseDeDatos = doc.CreateTextNode(bitacoraAuxiliar.BaseDeDatos);
                            XmlText texto_bitacoraTabla = doc.CreateTextNode(bitacoraAuxiliar.Tabla);
                            XmlText texto_bitacoraSeguridadIntegrada = doc.CreateTextNode(bitacoraAuxiliar.SeguridadIntegrada.ToString());
                            XmlText texto_bitacoraUsuario = doc.CreateTextNode(bitacoraAuxiliar.Usuario);
                            XmlText texto_bitacoraPassword = doc.CreateTextNode(bitacoraAuxiliar.Password);
                            XmlText texto_bitacoraEncriptarPassword = doc.CreateTextNode(bitacoraAuxiliar.EncriptarPassword.ToString());

                            bitacoraServidor.AppendChild(texto_bitacoraServidor);
                            bitacoraBaseDeDatos.AppendChild(texto_bitacoraBaseDeDatos);
                            bitacoraTabla.AppendChild(texto_bitacoraTabla);
                            bitacoraSeguridadIntegrada.AppendChild(texto_bitacoraSeguridadIntegrada);
                            bitacoraUsuario.AppendChild(texto_bitacoraUsuario);
                            bitacoraPassword.AppendChild(texto_bitacoraPassword);
                            bitacoraEncriptarPassword.AppendChild(texto_bitacoraEncriptarPassword);

                            unaBitacora.AppendChild(bitacoraServidor);
                            unaBitacora.AppendChild(bitacoraBaseDeDatos);
                            unaBitacora.AppendChild(bitacoraTabla);
                            unaBitacora.AppendChild(bitacoraSeguridadIntegrada);
                            unaBitacora.AppendChild(bitacoraUsuario);
                            unaBitacora.AppendChild(bitacoraPassword);
                            unaBitacora.AppendChild(bitacoraEncriptarPassword);
                        }
                        else
                        {
                            BitacoraArchivo bitacoraAuxiliar = (BitacoraArchivo)b;
                            XmlElement bitacoraRuta = doc.CreateElement(string.Empty, C_RUTA, string.Empty);
                            XmlElement bitacoraNombreArchivo = doc.CreateElement(string.Empty, C_NOMBRE_ARCHIVO, string.Empty);
                            XmlElement bitacoraExtension = doc.CreateElement(string.Empty, C_EXTENSION, string.Empty);
                            XmlElement bitacoraSeparador = doc.CreateElement(string.Empty, C_SEPARADOR, string.Empty);
                            XmlElement bitacoraLimite = doc.CreateElement(string.Empty, C_LIMITE, string.Empty);

                            XmlText texto_bitacoraRuta = doc.CreateTextNode(bitacoraAuxiliar.Ruta);
                            XmlText texto_bitacoraNombreArchivo = doc.CreateTextNode(bitacoraAuxiliar.NombreArchivo);
                            XmlText texto_bitacoraExtension = doc.CreateTextNode(bitacoraAuxiliar.Extension);
                            XmlText texto_bitacoraSeparador = doc.CreateTextNode(bitacoraAuxiliar.Separador);
                            XmlText texto_bitacoraLimite = doc.CreateTextNode(bitacoraAuxiliar.Limite.ToString());

                            bitacoraRuta.AppendChild(texto_bitacoraRuta);
                            bitacoraNombreArchivo.AppendChild(texto_bitacoraNombreArchivo);
                            bitacoraExtension.AppendChild(texto_bitacoraExtension);
                            bitacoraSeparador.AppendChild(texto_bitacoraSeparador);
                            bitacoraLimite.AppendChild(texto_bitacoraLimite);

                            unaBitacora.AppendChild(bitacoraRuta);
                            unaBitacora.AppendChild(bitacoraNombreArchivo);
                            unaBitacora.AppendChild(bitacoraExtension);
                            unaBitacora.AppendChild(bitacoraSeparador);
                            unaBitacora.AppendChild(bitacoraLimite);
                        }

                        coleccionDeBitacoras.AppendChild(unaBitacora);
                    }

                    ambiente.AppendChild(coleccionDeBitacoras);
                }
            }

            doc.Save(rutaArchivo + Path.DirectorySeparatorChar + C_NOMBRE_ARCHIVO_XML);
        }

        /// <summary>
        /// Borra el archivo XML que contiene los ambientes del sistema.-
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
