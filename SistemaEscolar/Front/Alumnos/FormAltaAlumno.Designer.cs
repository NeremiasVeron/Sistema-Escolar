namespace Front.Forms
{
    partial class FormAltaAlumno
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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblNuevoAlumno = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtmAlumno = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLocalidadAlumno = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDivisiones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipodoc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.icnbtnAtras = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.radiobtnM = new System.Windows.Forms.RadioButton();
            this.radiobtnF = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(59, 134);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(277, 134);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 27);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Gainsboro;
            this.label25.Location = new System.Drawing.Point(55, 110);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 21);
            this.label25.TabIndex = 4;
            this.label25.Text = "Nombre:";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(273, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 21);
            this.label24.TabIndex = 5;
            this.label24.Text = "Apellido:";
            // 
            // lblNuevoAlumno
            // 
            this.lblNuevoAlumno.AutoSize = true;
            this.lblNuevoAlumno.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAlumno.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNuevoAlumno.Location = new System.Drawing.Point(697, 19);
            this.lblNuevoAlumno.Name = "lblNuevoAlumno";
            this.lblNuevoAlumno.Size = new System.Drawing.Size(283, 44);
            this.lblNuevoAlumno.TabIndex = 6;
            this.lblNuevoAlumno.Text = "Nuevo alumno";
            this.lblNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNuevoAlumno.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDoc.ForeColor = System.Drawing.Color.Black;
            this.txtNroDoc.Location = new System.Drawing.Point(277, 211);
            this.txtNroDoc.MaxLength = 9;
            this.txtNroDoc.Multiline = true;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(192, 27);
            this.txtNroDoc.TabIndex = 3;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.txtNroDoc_TextChanged);
            this.txtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDoc_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(273, 179);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Nro Doc.:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(57, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 11;
            this.label20.Text = "Teléfono:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(273, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 12;
            this.label19.Text = "Correo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(486, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Fecha de nacimiento:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // dtmAlumno
            // 
            this.dtmAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmAlumno.Location = new System.Drawing.Point(490, 215);
            this.dtmAlumno.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtmAlumno.Name = "dtmAlumno";
            this.dtmAlumno.Size = new System.Drawing.Size(265, 23);
            this.dtmAlumno.TabIndex = 4;
            this.dtmAlumno.ValueChanged += new System.EventHandler(this.dtmAlumno_ValueChanged);
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(59, 276);
            this.txtTelefonoAlumno.MaxLength = 15;
            this.txtTelefonoAlumno.Multiline = true;
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtTelefonoAlumno.TabIndex = 5;
            this.txtTelefonoAlumno.TextChanged += new System.EventHandler(this.txtTelefonoAlumno_TextChanged);
            this.txtTelefonoAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoAlumno_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(277, 276);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 5);
            this.panel2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(57, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Localidad:";
            // 
            // txtLocalidadAlumno
            // 
            this.txtLocalidadAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtLocalidadAlumno.Location = new System.Drawing.Point(59, 341);
            this.txtLocalidadAlumno.MaxLength = 20;
            this.txtLocalidadAlumno.Multiline = true;
            this.txtLocalidadAlumno.Name = "txtLocalidadAlumno";
            this.txtLocalidadAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtLocalidadAlumno.TabIndex = 7;
            this.txtLocalidadAlumno.TextChanged += new System.EventHandler(this.txtLocalidadAlumno_TextChanged);
            this.txtLocalidadAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidadAlumno_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Gainsboro;
            this.label26.Location = new System.Drawing.Point(273, 317);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 21);
            this.label26.TabIndex = 32;
            this.label26.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(277, 341);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 27);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDirección_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbDivisiones);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCursos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.icnbtnAtras);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbTipodoc);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.txtLocalidadAlumno);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radiobtnF);
            this.panel1.Controls.Add(this.radiobtnM);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefonoAlumno);
            this.panel1.Controls.Add(this.dtmAlumno);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtNroDoc);
            this.panel1.Controls.Add(this.lblNuevoAlumno);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 661);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbDivisiones
            // 
            this.cmbDivisiones.FormattingEnabled = true;
            this.cmbDivisiones.Items.AddRange(new object[] {
            "A",
            "B ",
            "C"});
            this.cmbDivisiones.Location = new System.Drawing.Point(868, 395);
            this.cmbDivisiones.Name = "cmbDivisiones";
            this.cmbDivisiones.Size = new System.Drawing.Size(112, 21);
            this.cmbDivisiones.TabIndex = 40;
            this.cmbDivisiones.SelectedIndexChanged += new System.EventHandler(this.cmbDivisiones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(800, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "División:";
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto"});
            this.cmbCursos.Location = new System.Drawing.Point(673, 394);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(121, 21);
            this.cmbCursos.TabIndex = 38;
            this.cmbCursos.SelectedIndexChanged += new System.EventHandler(this.cmbCursos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(530, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Curso Asignado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(55, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "TipoDoc.";
            // 
            // cmbTipodoc
            // 
            this.cmbTipodoc.FormattingEnabled = true;
            this.cmbTipodoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipodoc.Location = new System.Drawing.Point(59, 213);
            this.cmbTipodoc.Name = "cmbTipodoc";
            this.cmbTipodoc.Size = new System.Drawing.Size(193, 21);
            this.cmbTipodoc.TabIndex = 2;
            this.cmbTipodoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipodoc_SelectedIndexChanged_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(14, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 359);
            this.panel3.TabIndex = 54;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(14, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(334, 56);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(624, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(334, 56);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // icnbtnAtras
            // 
            this.icnbtnAtras.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.icnbtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnAtras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtnAtras.IconChar = FontAwesome.Sharp.IconChar.CircleLeft;
            this.icnbtnAtras.IconColor = System.Drawing.Color.Black;
            this.icnbtnAtras.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.icnbtnAtras.IconSize = 32;
            this.icnbtnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnbtnAtras.Location = new System.Drawing.Point(23, 23);
            this.icnbtnAtras.Name = "icnbtnAtras";
            this.icnbtnAtras.Size = new System.Drawing.Size(228, 40);
            this.icnbtnAtras.TabIndex = 36;
            this.icnbtnAtras.Text = "Atrás";
            this.icnbtnAtras.UseVisualStyleBackColor = false;
            this.icnbtnAtras.Click += new System.EventHandler(this.icnbtnAtras_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(54, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Sexo";
            // 
            // radiobtnM
            // 
            this.radiobtnM.AutoSize = true;
            this.radiobtnM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnM.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnM.Location = new System.Drawing.Point(136, 391);
            this.radiobtnM.Name = "radiobtnM";
            this.radiobtnM.Size = new System.Drawing.Size(92, 20);
            this.radiobtnM.TabIndex = 9;
            this.radiobtnM.TabStop = true;
            this.radiobtnM.Text = "Masculino";
            this.radiobtnM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radiobtnM.UseVisualStyleBackColor = true;
            this.radiobtnM.CheckedChanged += new System.EventHandler(this.radiobtnM_CheckedChanged);
            // 
            // radiobtnF
            // 
            this.radiobtnF.AutoSize = true;
            this.radiobtnF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnF.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnF.Location = new System.Drawing.Point(238, 391);
            this.radiobtnF.Name = "radiobtnF";
            this.radiobtnF.Size = new System.Drawing.Size(87, 20);
            this.radiobtnF.TabIndex = 23;
            this.radiobtnF.TabStop = true;
            this.radiobtnF.Text = "Femenino";
            this.radiobtnF.UseVisualStyleBackColor = true;
            this.radiobtnF.CheckedChanged += new System.EventHandler(this.radiobtnF_CheckedChanged);
            // 
            // FormAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaAlumno";
            this.Text = "FormAltaAlumno";
            this.Load += new System.EventHandler(this.FormAltaAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblNuevoAlumno;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtmAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLocalidadAlumno;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipodoc;
        private FontAwesome.Sharp.IconButton icnbtnAtras;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.ComboBox cmbDivisiones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radiobtnF;
        private System.Windows.Forms.RadioButton radiobtnM;
        private System.Windows.Forms.Label label15;
    }
}