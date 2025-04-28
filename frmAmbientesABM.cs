using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compass
{
    public partial class frmAmbientesABM : Form
    {
        private bool modoEdicion;
        private Ambiente? ambienteActual;
        private const string C_TITULO_MESSAGE_BOX = "Mantenimiento de Ambientes";

        public frmAmbientesABM()
        {
            InitializeComponent();
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


        private void frmAmbientesABM_Load(object sender, EventArgs e)
        {
            tslCantidadDeRegistros.Text = "0";

            cargarAmbientes();

            modoEdicion = true;
            configurarGUI();
        }

        private void cargarAmbientes()
        {
            lstAmbientes.Items.Clear();
            List<Ambiente> l = Ambiente.Obtener();
            List<Ambiente> listaDeAmbientes = l.OrderBy(x => x.Nombre).ToList();

            foreach (Ambiente a in listaDeAmbientes)
                lstAmbientes.Items.Add(a.Nombre);

            if (listaDeAmbientes.Count > 0)
            {
                lstAmbientes.SelectedIndex = 0;
                ambienteActual = new Ambiente(lstAmbientes.SelectedItems[0].ToString());
                tslCantidadDeRegistros.Text = listaDeAmbientes.Count.ToString();
                mostrarAmbienteActual();
            }
            else
            {
                ambienteActual = null;
                tslCantidadDeRegistros.Text = "0";
            }


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

        private void lstAmbientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ambienteActual = new Ambiente(lstAmbientes.SelectedItem.ToString());
            mostrarAmbienteActual();
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
    }
}
