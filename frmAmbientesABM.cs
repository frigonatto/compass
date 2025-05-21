using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace compass
{
    public partial class frmAmbientesABM : Form
    {
        private bool modoEdicion;
        private bool modoEdicionBitacora;
        private bool cargaEnProgreso;
        private Ambiente? ambienteActual;
        private Bitacora? bitacoraActual;
        private List<Ambiente>? listaDeAmbientes;
        private List<Bitacora>? listaDeBitacoras;
        private const string C_TITULO_MESSAGE_BOX = "Mantenimiento de Ambientes";

        public frmAmbientesABM()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                if (ambienteActual.Descripcion != txtDescripcionAmbiente.Text)
                    ambienteActual.Descripcion = txtDescripcionAmbiente.Text;

                if (ambienteActual.Usuario != txtUsuarioAmbiente.Text)
                    ambienteActual.Usuario = txtUsuarioAmbiente.Text;

                if (ambienteActual.Password != txtPassword.Text)
                    ambienteActual.Password = txtPassword.Text;

                if (ambienteActual.Servidor != txtServidorAmbiente.Text)
                    ambienteActual.Servidor = txtServidorAmbiente.Text;

                if (ambienteActual.BaseDeDatos != txtBaseDeDatosAmbiente.Text)
                    ambienteActual.BaseDeDatos = txtBaseDeDatosAmbiente.Text;

                if (ambienteActual.SeguridadIntegrada != chkSeguridadIntegrada.Checked)
                    ambienteActual.SeguridadIntegrada = chkSeguridadIntegrada.Checked;

                if (ambienteActual.EncriptarPassword != chkEncriptarPassword.Checked)
                    ambienteActual.EncriptarPassword = chkEncriptarPassword.Checked;

                Ambiente.Actualizar(ambienteActual);

            }
            else
            {
                Ambiente? nuevoAmbiente;
                if (chkSeguridadIntegrada.Checked)
                {
                    nuevoAmbiente = new Ambiente(txtNombreAmbiente.Text, txtDescripcionAmbiente.Text, txtServidorAmbiente.Text, txtNombreAmbiente.Text);
                }
                else
                {
                    nuevoAmbiente = new Ambiente(txtNombreAmbiente.Text, txtDescripcionAmbiente.Text, txtServidorAmbiente.Text, txtNombreAmbiente.Text, txtUsuarioAmbiente.Text, txtPassword.Text, chkEncriptarPassword.Checked);
                }

                Ambiente.Guardar(nuevoAmbiente);

                cargarAmbientes();
                configurarGUI();
            }
        }

        private void btnBitacoraAceptar_Click(object sender, EventArgs e)
        {
            if (modoEdicionBitacora)
            {
                //actualizar la bitácora actual
            }
            else
            {
                if (optBitacoraAlmacenamiento1.Checked)
                {
                    //base de datos
                    string axUsuario = txtBitacoraUsuario.Text;
                    string axPassword = txtBitacoraPassword.Text;

                    if (chkSeguridadIntegrada.Checked)
                    {
                        axUsuario = "";
                        axPassword = "";
                    }

                    BitacoraBaseDeDatos nuevaBitacora = new BitacoraBaseDeDatos
                    {
                        Almacenamiento = 1,
                        Nombre = txtBitacoraNombre.Text,
                        Servidor = txtBitacoraServidor.Text,
                        BaseDeDatos = txtBitacoraBaseDeDatos.Text,
                        Tabla = txtBitacoraTabla.Text,
                        SeguridadIntegrada = chkSeguridadIntegrada.Checked,
                        Usuario = axUsuario,
                        Password = axPassword,
                        EncriptarPassword = chkEncriptarPassword.Checked
                    };

                    listaDeBitacoras.Add(nuevaBitacora);
                }
                else
                {
                    BitacoraArchivo nuevaBitacora = new BitacoraArchivo
                    {
                        Almacenamiento = 2,
                        Nombre = txtBitacoraNombre.Text,
                        Ruta = txtBitacoraRuta.Text,
                        NombreArchivo = txtBitacoraNombreArchivo.Text,
                        Extension = txtBitacoraExtension.Text,
                        Separador = txtBitacoraSeparador.Text,
                        Limite = System.Convert.ToInt32(nudBitacoraLimiteMB.Value),
                    };

                    listaDeBitacoras.Add(nuevaBitacora);
                }

            }
        }

        private void btnBitacoraCancelar_Click(object sender, EventArgs e)
        {
            modoEdicionBitacora = true;
            configurarBitacoraGUI();
        }

        private void btnBitacoraNueva_Click(object sender, EventArgs e)
        {
            modoEdicionBitacora = false;
            configurarBitacoraGUI();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modoEdicion = true;
            configurarGUI();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realmente eliminar el ambiente seleccionado?", C_TITULO_MESSAGE_BOX, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ambiente.Eliminar(ambienteActual);
                cargarAmbientes();
            }
        }

        private void btnGenerarINI_Click(object sender, EventArgs e)
        {
            if (ambienteActual != null)
            {
                try
                {
                    ambienteActual.GenerarArchivosINI();
                    MessageBox.Show("Archivo TrinidadDb.ini generado con éxito.-", C_TITULO_MESSAGE_BOX, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, C_TITULO_MESSAGE_BOX, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cmbBitacorasRegistradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargaEnProgreso)
            {
                if (listaDeBitacoras[cmbBitacorasRegistradas.SelectedIndex].Almacenamiento == 1)
                    mostrarBitacora((BitacoraBaseDeDatos)listaDeBitacoras[cmbBitacorasRegistradas.SelectedIndex]);
                else
                    mostrarBitacora((BitacoraArchivo)listaDeBitacoras[cmbBitacorasRegistradas.SelectedIndex]);
            }
        }

        private void frmAmbientesABM_Load(object sender, EventArgs e)
        {
            tslCantidadDeRegistros.Text = "0";

            cargarAmbientes();

            modoEdicion = true;
            configurarGUI();
        }

        private void frmAmbientesABM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (!modoEdicion)
                {
                    modoEdicion = true;
                    configurarGUI();
                }
            }

            if (e.KeyCode == Keys.F5)
            {
                cargarAmbientes();
            }

            if (e.KeyCode == Keys.F6)
            {
                if (modoEdicion)
                {
                    modoEdicion = false;
                    configurarGUI();
                }
            }
        }

        private void chkBitacoras_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkSeguridadIntegrada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeguridadIntegrada.Checked)
            {
                txtPassword.Text = "";
                txtUsuarioAmbiente.Text = "";
                txtPassword.Enabled = false;
                txtUsuarioAmbiente.Enabled = false;
                chkEncriptarPassword.Enabled = false;
            }
            else
            {
                txtPassword.Text = "";
                txtUsuarioAmbiente.Text = "";
                txtPassword.Enabled = true;
                txtUsuarioAmbiente.Enabled = true;
                chkEncriptarPassword.Enabled = true;
            }
        }

        private void lstAmbientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargaEnProgreso)
            {
                ambienteActual = listaDeAmbientes[lstAmbientes.SelectedIndex];
                mostrarAmbienteActual();
            }
        }


        /*****************************************************************************************/

        /// <summary>
        /// 
        /// </summary>
        private void cargarAmbientes()
        {
            cargaEnProgreso = true;
            lstAmbientes.Items.Clear();
            listaDeAmbientes = Ambiente.Obtener();
            listaDeAmbientes = listaDeAmbientes.OrderBy(x => x.Nombre).ToList();

            foreach (Ambiente a in listaDeAmbientes)
                lstAmbientes.Items.Add(a.Nombre);

            if (listaDeAmbientes.Count > 0)
            {
                lstAmbientes.SelectedIndex = 0;
                ambienteActual = listaDeAmbientes[0];
                tslCantidadDeRegistros.Text = listaDeAmbientes.Count.ToString();
                mostrarAmbienteActual();
            }
            else
            {
                ambienteActual = null;
                tslCantidadDeRegistros.Text = "0";
            }
            cargaEnProgreso = false;
        }

        /// <summary>
        /// 
        /// </summary>
        private void mostrarAmbienteActual()
        {
            if (ambienteActual != null)
            {
                txtNombreAmbiente.Text = ambienteActual.Nombre;
                txtDescripcionAmbiente.Text = ambienteActual.Descripcion;
                txtBaseDeDatosAmbiente.Text = ambienteActual.BaseDeDatos;
                txtServidorAmbiente.Text = ambienteActual.Servidor;
                chkEncriptarPassword.Checked = ambienteActual.EncriptarPassword;
                chkSeguridadIntegrada.Checked = ambienteActual.SeguridadIntegrada;
                txtPassword.Text = ambienteActual.Password;
                txtUsuarioAmbiente.Text = ambienteActual.Usuario;
                txtDescripcionAmbiente.Focus();

                cmbBitacorasRegistradas.Items.Clear();

                listaDeBitacoras = ambienteActual.MisBitacoras;
                foreach (Bitacora b in listaDeBitacoras)
                    cmbBitacorasRegistradas.Items.Add(b.Nombre);

                

                modoEdicionBitacora = true;
                configurarBitacoraGUI();
                
                
                //mostrar bitacora actual
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void configurarGUI()
        {
            if (modoEdicion)
            {
                btnAceptar.Text = "Actualizar";
                btnCancelar.Visible = false;
                btnEliminar.Visible = true;
                tslModo.Text = "Editar";
                lstAmbientes.Enabled = true;
                txtNombreAmbiente.ReadOnly = true;
                mostrarAmbienteActual();
            }
            else
            {
                txtNombreAmbiente.Text = "";
                txtDescripcionAmbiente.Text = "";
                txtServidorAmbiente.Text = "";
                txtBaseDeDatosAmbiente.Text = "";
                txtUsuarioAmbiente.Text = "";
                txtPassword.Text = "";
                chkEncriptarPassword.Checked = false;
                chkSeguridadIntegrada.Checked = false;
                txtNombreAmbiente.ReadOnly = false;

                btnAceptar.Text = "Agregar";
                btnCancelar.Visible = true;
                btnEliminar.Visible = false;
                tslModo.Text = "Agregar";
                lstAmbientes.Enabled = false;
            }
        }

        private void mostrarBitacora(BitacoraBaseDeDatos bitacora)
        {
            fraBitacoraDatosAlmacenamiento1.Visible = true;
            fraBitacoraDatosAlmacenamiento2.Visible = false;
            optBitacoraAlmacenamiento1.Checked = true;

            txtBitacoraNombre.Text = bitacora.Nombre;
            txtBitacoraServidor.Text = bitacora.Servidor;
            txtBitacoraBaseDeDatos.Text = bitacora.BaseDeDatos;
            txtBitacoraTabla.Text = bitacora.Tabla;

            chkBitacoraSeguridadIntegrada.Checked = bitacora.SeguridadIntegrada;
            if (bitacora.SeguridadIntegrada)
            {
                txtBitacoraUsuario.Text = "";
                txtBitacoraPassword.Text = "";
            }
            else
            {
                txtBitacoraUsuario.Text = bitacora.Usuario;
                txtBitacoraPassword.Text = bitacora.Password;
            }

            chkBitacoraEncriptarPassword.Checked = bitacora.EncriptarPassword;
        }

        private void mostrarBitacora(BitacoraArchivo bitacora)
        {
            fraBitacoraDatosAlmacenamiento2.Visible = true;
            fraBitacoraDatosAlmacenamiento1.Visible = false;
            optBitacoraAlmacenamiento2.Checked = true;

            txtBitacoraNombre.Text = bitacora.Nombre;
            txtBitacoraRuta.Text = bitacora.Ruta;
            txtBitacoraNombreArchivo.Text = bitacora.NombreArchivo;
            txtBitacoraExtension.Text = bitacora.Extension;
            nudBitacoraLimiteMB.Value = bitacora.Limite;
        }

        private void configurarBitacoraGUI()
        {
            txtBitacoraNombre.Text = "";
            txtBitacoraServidor.Text = "";
            txtBitacoraBaseDeDatos.Text = "";
            txtBitacoraTabla.Text = "";
            txtBitacoraUsuario.Text = "";
            txtBitacoraPassword.Text = "";

            txtBitacoraNombre.Text = "";
            txtBitacoraRuta.Text = "";
            txtBitacoraNombreArchivo.Text = "";
            txtBitacoraExtension.Text = "";
            nudBitacoraLimiteMB.Value = 0;

            chkBitacoraSeguridadIntegrada.Checked = false;
            chkBitacoraEncriptarPassword.Checked = false;
            optBitacoraAlmacenamiento1.Checked = true;
            mostrarDatosDeAlmacenamiento("base");

            if (modoEdicionBitacora)
            {
                btnBitacoraEliminar.Enabled = true;
                btnBitacoraNueva.Visible = true;
                btnBitacoraCancelar.Visible = false;
                txtBitacoraNombre.ReadOnly = true;
                fraBitacoraAlmacenamiento.Enabled = false;
                lblBitacoraModo.Text = "Edición";
                lblBitacoraModo.ForeColor = Color.CadetBlue;
            }
            else
            {
                btnBitacoraEliminar.Enabled = false;
                btnBitacoraNueva.Visible = false;
                btnBitacoraCancelar.Visible = true;
                txtBitacoraNombre.ReadOnly = false;
                fraBitacoraAlmacenamiento.Enabled = true;
                lblBitacoraModo.Text = "Alta";
                lblBitacoraModo.ForeColor = Color.Crimson;
                optBitacoraAlmacenamiento1.Checked = true;
            }
        }

        private void optBitacoras_CheckedChanged(object sender, EventArgs e)
        {
            if (!cargaEnProgreso)
            {
                if (optBitacoraAlmacenamiento1.Checked)
                    mostrarDatosDeAlmacenamiento("base");
                else
                    mostrarDatosDeAlmacenamiento("archivo");
            }
        }

        private void mostrarDatosDeAlmacenamiento(string almacenamiento)
        {
            if (almacenamiento == "base")
            {
                fraBitacoraDatosAlmacenamiento1.Visible = true;
                fraBitacoraDatosAlmacenamiento1.Location = new Point(16, 129);

                fraBitacoraDatosAlmacenamiento2.Visible = false;
            }
            else
            {
                fraBitacoraDatosAlmacenamiento1.Visible = false;
                fraBitacoraDatosAlmacenamiento1.Location = new Point(602, 129);

                fraBitacoraDatosAlmacenamiento2.Visible = true;
            }
        }

    }
}
