namespace compass
{
    partial class frmAmbientesABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmbientesABM));
            statusStrip1 = new StatusStrip();
            tslCantidadDeRegistros = new ToolStripStatusLabel();
            tslModo = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            lstAmbientes = new ListBox();
            label1 = new Label();
            txtNombreAmbiente = new TextBox();
            label2 = new Label();
            txtDescripcionAmbiente = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtServidorAmbiente = new TextBox();
            label4 = new Label();
            txtBaseDeDatosAmbiente = new TextBox();
            chkSeguridadIntegrada = new CheckBox();
            label5 = new Label();
            txtUsuarioAmbiente = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            chkEncriptarPassword = new CheckBox();
            btnEliminar = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslCantidadDeRegistros, tslModo, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5 });
            statusStrip1.Location = new Point(0, 296);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(903, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslCantidadDeRegistros
            // 
            tslCantidadDeRegistros.AutoSize = false;
            tslCantidadDeRegistros.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslCantidadDeRegistros.BorderStyle = Border3DStyle.Sunken;
            tslCantidadDeRegistros.Name = "tslCantidadDeRegistros";
            tslCantidadDeRegistros.Size = new Size(122, 19);
            tslCantidadDeRegistros.Text = "...";
            // 
            // tslModo
            // 
            tslModo.AutoSize = false;
            tslModo.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tslModo.BorderStyle = Border3DStyle.Sunken;
            tslModo.Name = "tslModo";
            tslModo.Size = new Size(122, 19);
            tslModo.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.AutoSize = false;
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(122, 19);
            toolStripStatusLabel3.Text = "...";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.AutoSize = false;
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(122, 19);
            toolStripStatusLabel4.Text = "...";
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.AutoSize = false;
            toolStripStatusLabel5.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            toolStripStatusLabel5.BorderStyle = Border3DStyle.Sunken;
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(122, 19);
            toolStripStatusLabel5.Text = "...";
            // 
            // lstAmbientes
            // 
            lstAmbientes.Dock = DockStyle.Left;
            lstAmbientes.FormattingEnabled = true;
            lstAmbientes.ItemHeight = 15;
            lstAmbientes.Location = new Point(0, 0);
            lstAmbientes.Name = "lstAmbientes";
            lstAmbientes.Size = new Size(273, 296);
            lstAmbientes.TabIndex = 1;
            lstAmbientes.SelectedIndexChanged += lstAmbientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombreAmbiente
            // 
            txtNombreAmbiente.Location = new Point(347, 34);
            txtNombreAmbiente.Name = "txtNombreAmbiente";
            txtNombreAmbiente.Size = new Size(100, 23);
            txtNombreAmbiente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 37);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción:";
            // 
            // txtDescripcionAmbiente
            // 
            txtDescripcionAmbiente.Location = new Point(552, 34);
            txtDescripcionAmbiente.Name = "txtDescripcionAmbiente";
            txtDescripcionAmbiente.Size = new Size(339, 23);
            txtDescripcionAmbiente.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(302, 251);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "button1";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(555, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 84);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Servidor:";
            // 
            // txtServidorAmbiente
            // 
            txtServidorAmbiente.Location = new Point(349, 81);
            txtServidorAmbiente.Name = "txtServidorAmbiente";
            txtServidorAmbiente.Size = new Size(257, 23);
            txtServidorAmbiente.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 84);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "Base De Datos:";
            // 
            // txtBaseDeDatosAmbiente
            // 
            txtBaseDeDatosAmbiente.Location = new Point(740, 81);
            txtBaseDeDatosAmbiente.Name = "txtBaseDeDatosAmbiente";
            txtBaseDeDatosAmbiente.Size = new Size(132, 23);
            txtBaseDeDatosAmbiente.TabIndex = 11;
            // 
            // chkSeguridadIntegrada
            // 
            chkSeguridadIntegrada.AutoSize = true;
            chkSeguridadIntegrada.Location = new Point(294, 133);
            chkSeguridadIntegrada.Name = "chkSeguridadIntegrada";
            chkSeguridadIntegrada.Size = new Size(132, 19);
            chkSeguridadIntegrada.TabIndex = 12;
            chkSeguridadIntegrada.Text = "Seguridad Integrada";
            chkSeguridadIntegrada.UseVisualStyleBackColor = true;
            chkSeguridadIntegrada.CheckedChanged += chkSeguridadIntegrada_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(499, 134);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 13;
            label5.Text = "Usuario:";
            // 
            // txtUsuarioAmbiente
            // 
            txtUsuarioAmbiente.Location = new Point(555, 131);
            txtUsuarioAmbiente.Name = "txtUsuarioAmbiente";
            txtUsuarioAmbiente.Size = new Size(130, 23);
            txtUsuarioAmbiente.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 171);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(555, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(130, 23);
            txtPassword.TabIndex = 16;
            // 
            // chkEncriptarPassword
            // 
            chkEncriptarPassword.AutoSize = true;
            chkEncriptarPassword.Location = new Point(705, 170);
            chkEncriptarPassword.Name = "chkEncriptarPassword";
            chkEncriptarPassword.Size = new Size(136, 19);
            chkEncriptarPassword.TabIndex = 17;
            chkEncriptarPassword.Text = "Encriptar Contraseña";
            chkEncriptarPassword.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(816, 251);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmAmbientesABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 320);
            Controls.Add(btnEliminar);
            Controls.Add(chkEncriptarPassword);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtUsuarioAmbiente);
            Controls.Add(label5);
            Controls.Add(chkSeguridadIntegrada);
            Controls.Add(txtBaseDeDatosAmbiente);
            Controls.Add(label4);
            Controls.Add(txtServidorAmbiente);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcionAmbiente);
            Controls.Add(label2);
            Controls.Add(txtNombreAmbiente);
            Controls.Add(label1);
            Controls.Add(lstAmbientes);
            Controls.Add(statusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmAmbientesABM";
            Text = "Mantenimiento de Ambientes";
            Load += frmAmbientesABM_Load;
            KeyUp += frmAmbientesABM_KeyUp;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslCantidadDeRegistros;
        private ToolStripStatusLabel tslModo;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ListBox lstAmbientes;
        private Label label1;
        private TextBox txtNombreAmbiente;
        private Label label2;
        private TextBox txtDescripcionAmbiente;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtServidorAmbiente;
        private Label label4;
        private TextBox txtBaseDeDatosAmbiente;
        private CheckBox chkSeguridadIntegrada;
        private Label label5;
        private TextBox txtUsuarioAmbiente;
        private Label label6;
        private TextBox txtPassword;
        private CheckBox chkEncriptarPassword;
        private Button btnEliminar;
    }
}