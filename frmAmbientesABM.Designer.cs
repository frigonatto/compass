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
            btnGenerarINI = new Button();
            chkBitacoras = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            fraBitacoraDatosAlmacenamiento1 = new GroupBox();
            fraBitacoraDatosAlmacenamiento2 = new GroupBox();
            label7 = new Label();
            fraBitacoraAlmacenamiento = new GroupBox();
            optBitacoraAlmacenamiento2 = new RadioButton();
            optBitacoraAlmacenamiento1 = new RadioButton();
            cmbBitacorasRegistradas = new ComboBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            fraBitacoraDatosAlmacenamiento1.SuspendLayout();
            fraBitacoraAlmacenamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslCantidadDeRegistros, tslModo, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel5 });
            statusStrip1.Location = new Point(0, 461);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1068, 24);
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
            lstAmbientes.Size = new Size(273, 461);
            lstAmbientes.TabIndex = 1;
            lstAmbientes.SelectedIndexChanged += lstAmbientes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombreAmbiente
            // 
            txtNombreAmbiente.Location = new Point(79, 20);
            txtNombreAmbiente.Name = "txtNombreAmbiente";
            txtNombreAmbiente.Size = new Size(100, 23);
            txtNombreAmbiente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 23);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripción:";
            // 
            // txtDescripcionAmbiente
            // 
            txtDescripcionAmbiente.Location = new Point(284, 20);
            txtDescripcionAmbiente.Name = "txtDescripcionAmbiente";
            txtDescripcionAmbiente.Size = new Size(339, 23);
            txtDescripcionAmbiente.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(293, 426);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(546, 426);
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
            label3.Location = new Point(22, 70);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Servidor:";
            // 
            // txtServidorAmbiente
            // 
            txtServidorAmbiente.Location = new Point(81, 67);
            txtServidorAmbiente.Name = "txtServidorAmbiente";
            txtServidorAmbiente.Size = new Size(257, 23);
            txtServidorAmbiente.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 70);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "Base De Datos:";
            // 
            // txtBaseDeDatosAmbiente
            // 
            txtBaseDeDatosAmbiente.Location = new Point(472, 67);
            txtBaseDeDatosAmbiente.Name = "txtBaseDeDatosAmbiente";
            txtBaseDeDatosAmbiente.Size = new Size(132, 23);
            txtBaseDeDatosAmbiente.TabIndex = 11;
            // 
            // chkSeguridadIntegrada
            // 
            chkSeguridadIntegrada.AutoSize = true;
            chkSeguridadIntegrada.Location = new Point(22, 118);
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
            label5.Location = new Point(227, 119);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 13;
            label5.Text = "Usuario:";
            // 
            // txtUsuarioAmbiente
            // 
            txtUsuarioAmbiente.Location = new Point(283, 116);
            txtUsuarioAmbiente.Name = "txtUsuarioAmbiente";
            txtUsuarioAmbiente.Size = new Size(130, 23);
            txtUsuarioAmbiente.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 156);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 15;
            label6.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(283, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(130, 23);
            txtPassword.TabIndex = 16;
            // 
            // chkEncriptarPassword
            // 
            chkEncriptarPassword.AutoSize = true;
            chkEncriptarPassword.Location = new Point(433, 155);
            chkEncriptarPassword.Name = "chkEncriptarPassword";
            chkEncriptarPassword.Size = new Size(136, 19);
            chkEncriptarPassword.TabIndex = 17;
            chkEncriptarPassword.Text = "Encriptar Contraseña";
            chkEncriptarPassword.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(807, 426);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGenerarINI
            // 
            btnGenerarINI.Location = new Point(22, 224);
            btnGenerarINI.Name = "btnGenerarINI";
            btnGenerarINI.Size = new Size(141, 23);
            btnGenerarINI.TabIndex = 19;
            btnGenerarINI.Text = "Generar Archivos INI";
            btnGenerarINI.UseVisualStyleBackColor = true;
            btnGenerarINI.Click += btnGenerarINI_Click;
            // 
            // chkBitacoras
            // 
            chkBitacoras.AutoSize = true;
            chkBitacoras.Location = new Point(26, 23);
            chkBitacoras.Name = "chkBitacoras";
            chkBitacoras.Size = new Size(172, 19);
            chkBitacoras.TabIndex = 21;
            chkBitacoras.Text = "Habilitar el uso de Bitácoras";
            chkBitacoras.UseVisualStyleBackColor = true;
            chkBitacoras.CheckedChanged += chkBitacoras_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(279, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 397);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtServidorAmbiente);
            tabPage1.Controls.Add(btnGenerarINI);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtNombreAmbiente);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtDescripcionAmbiente);
            tabPage1.Controls.Add(chkEncriptarPassword);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtBaseDeDatosAmbiente);
            tabPage1.Controls.Add(txtUsuarioAmbiente);
            tabPage1.Controls.Add(chkSeguridadIntegrada);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 369);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos Generales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(fraBitacoraDatosAlmacenamiento2);
            tabPage2.Controls.Add(fraBitacoraDatosAlmacenamiento1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(fraBitacoraAlmacenamiento);
            tabPage2.Controls.Add(cmbBitacorasRegistradas);
            tabPage2.Controls.Add(chkBitacoras);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 369);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bitácoras";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fraBitacoraDatosAlmacenamiento1
            // 
            fraBitacoraDatosAlmacenamiento1.Controls.Add(label12);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(numericUpDown1);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(label11);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(textBox3);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(label10);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(textBox2);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(label9);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(textBox1);
            fraBitacoraDatosAlmacenamiento1.Controls.Add(label8);
            fraBitacoraDatosAlmacenamiento1.Location = new Point(26, 129);
            fraBitacoraDatosAlmacenamiento1.Name = "fraBitacoraDatosAlmacenamiento1";
            fraBitacoraDatosAlmacenamiento1.Size = new Size(580, 213);
            fraBitacoraDatosAlmacenamiento1.TabIndex = 24;
            fraBitacoraDatosAlmacenamiento1.TabStop = false;
            fraBitacoraDatosAlmacenamiento1.Text = "Configuración de archivos";
            // 
            // fraBitacoraDatosAlmacenamiento2
            // 
            fraBitacoraDatosAlmacenamiento2.Location = new Point(22, 129);
            fraBitacoraDatosAlmacenamiento2.Name = "fraBitacoraDatosAlmacenamiento2";
            fraBitacoraDatosAlmacenamiento2.Size = new Size(580, 213);
            fraBitacoraDatosAlmacenamiento2.TabIndex = 25;
            fraBitacoraDatosAlmacenamiento2.TabStop = false;
            fraBitacoraDatosAlmacenamiento2.Text = "Configuración de Base de Datos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 27);
            label7.Name = "label7";
            label7.Size = new Size(121, 15);
            label7.TabIndex = 23;
            label7.Text = "Bitacoras Registradas:";
            // 
            // fraBitacoraAlmacenamiento
            // 
            fraBitacoraAlmacenamiento.Controls.Add(optBitacoraAlmacenamiento2);
            fraBitacoraAlmacenamiento.Controls.Add(optBitacoraAlmacenamiento1);
            fraBitacoraAlmacenamiento.Location = new Point(26, 66);
            fraBitacoraAlmacenamiento.Name = "fraBitacoraAlmacenamiento";
            fraBitacoraAlmacenamiento.Size = new Size(337, 57);
            fraBitacoraAlmacenamiento.TabIndex = 22;
            fraBitacoraAlmacenamiento.TabStop = false;
            fraBitacoraAlmacenamiento.Text = "Almacenamiento";
            // 
            // optBitacoraAlmacenamiento2
            // 
            optBitacoraAlmacenamiento2.AutoSize = true;
            optBitacoraAlmacenamiento2.Location = new Point(161, 25);
            optBitacoraAlmacenamiento2.Name = "optBitacoraAlmacenamiento2";
            optBitacoraAlmacenamiento2.Size = new Size(98, 19);
            optBitacoraAlmacenamiento2.TabIndex = 1;
            optBitacoraAlmacenamiento2.TabStop = true;
            optBitacoraAlmacenamiento2.Text = "Base de Datos";
            optBitacoraAlmacenamiento2.UseVisualStyleBackColor = true;
            // 
            // optBitacoraAlmacenamiento1
            // 
            optBitacoraAlmacenamiento1.AutoSize = true;
            optBitacoraAlmacenamiento1.Location = new Point(15, 25);
            optBitacoraAlmacenamiento1.Name = "optBitacoraAlmacenamiento1";
            optBitacoraAlmacenamiento1.Size = new Size(66, 19);
            optBitacoraAlmacenamiento1.TabIndex = 0;
            optBitacoraAlmacenamiento1.TabStop = true;
            optBitacoraAlmacenamiento1.Text = "Archivo";
            optBitacoraAlmacenamiento1.UseVisualStyleBackColor = true;
            optBitacoraAlmacenamiento1.CheckedChanged += optBitacoraAlmacenamiento1_CheckedChanged;
            // 
            // cmbBitacorasRegistradas
            // 
            cmbBitacorasRegistradas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBitacorasRegistradas.FormattingEnabled = true;
            cmbBitacorasRegistradas.Location = new Point(369, 21);
            cmbBitacorasRegistradas.Name = "cmbBitacorasRegistradas";
            cmbBitacorasRegistradas.Size = new Size(306, 23);
            cmbBitacorasRegistradas.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 34);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 0;
            label8.Text = "Ruta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 75);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 2;
            label9.Text = "Nombre del archivo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 115);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 4;
            label10.Text = "Extensión:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(61, 23);
            textBox3.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(177, 115);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 6;
            label11.Text = "Límite:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(226, 112);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.BlueViolet;
            label12.Location = new Point(286, 115);
            label12.Name = "label12";
            label12.Size = new Size(26, 15);
            label12.TabIndex = 8;
            label12.Text = "MB";
            // 
            // frmAmbientesABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 485);
            Controls.Add(tabControl1);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            fraBitacoraDatosAlmacenamiento1.ResumeLayout(false);
            fraBitacoraDatosAlmacenamiento1.PerformLayout();
            fraBitacoraAlmacenamiento.ResumeLayout(false);
            fraBitacoraAlmacenamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button btnGenerarINI;
        private CheckBox chkBitacoras;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbBitacorasRegistradas;
        private GroupBox fraBitacoraAlmacenamiento;
        private RadioButton optBitacoraAlmacenamiento2;
        private RadioButton optBitacoraAlmacenamiento1;
        private Label label7;
        private GroupBox fraBitacoraDatosAlmacenamiento1;
        private GroupBox fraBitacoraDatosAlmacenamiento2;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Label label11;
    }
}