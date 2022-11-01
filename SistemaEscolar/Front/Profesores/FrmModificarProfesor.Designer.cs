namespace Front.Profesores
{
    partial class FrmModificarProfesor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.radiobtnM = new System.Windows.Forms.RadioButton();
            this.radiobtnF = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtmAlumno = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLocalidadAlumno = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icnbtnAtras = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panelModificarProfesor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNivelCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspecializacion = new System.Windows.Forms.TextBox();
            this.cmbReemplazante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelModificarProfesor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radiobtnF);
            this.panel1.Controls.Add(this.radiobtnM);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(8, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 428);
            this.panel1.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(9, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 78;
            this.label15.Text = "Sexo";
            // 
            // radiobtnM
            // 
            this.radiobtnM.AutoSize = true;
            this.radiobtnM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnM.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnM.Location = new System.Drawing.Point(91, 376);
            this.radiobtnM.Name = "radiobtnM";
            this.radiobtnM.Size = new System.Drawing.Size(92, 20);
            this.radiobtnM.TabIndex = 77;
            this.radiobtnM.TabStop = true;
            this.radiobtnM.Text = "Masculino";
            this.radiobtnM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radiobtnM.UseVisualStyleBackColor = true;
            // 
            // radiobtnF
            // 
            this.radiobtnF.AutoSize = true;
            this.radiobtnF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnF.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnF.Location = new System.Drawing.Point(193, 376);
            this.radiobtnF.Name = "radiobtnF";
            this.radiobtnF.Size = new System.Drawing.Size(87, 20);
            this.radiobtnF.TabIndex = 79;
            this.radiobtnF.TabStop = true;
            this.radiobtnF.Text = "Femenino";
            this.radiobtnF.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label23.Location = new System.Drawing.Point(543, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(453, 44);
            this.label23.TabIndex = 28;
            this.label23.Text = "Modificar datos profesor";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Gainsboro;
            this.label25.Location = new System.Drawing.Point(12, 128);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 21);
            this.label25.TabIndex = 34;
            this.label25.Text = "Nombre:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(232, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 21);
            this.label24.TabIndex = 35;
            this.label24.Text = "Apellido:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(232, 195);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 21);
            this.label21.TabIndex = 37;
            this.label21.Text = "Nro Doc:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(12, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 38;
            this.label20.Text = "Teléfono:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(232, 309);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 39;
            this.label19.Text = "Correo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(12, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 21);
            this.label18.TabIndex = 40;
            this.label18.Text = "Fecha de nacimiento:";
            // 
            // dtmAlumno
            // 
            this.dtmAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dtmAlumno.Location = new System.Drawing.Point(236, 261);
            this.dtmAlumno.Name = "dtmAlumno";
            this.dtmAlumno.Size = new System.Drawing.Size(274, 23);
            this.dtmAlumno.TabIndex = 41;
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(16, 333);
            this.txtTelefonoAlumno.MaxLength = 15;
            this.txtTelefonoAlumno.Multiline = true;
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtTelefonoAlumno.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(236, 333);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 27);
            this.txtEmail.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(12, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 44;
            this.label13.Text = "Localidad:";
            // 
            // txtLocalidadAlumno
            // 
            this.txtLocalidadAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtLocalidadAlumno.Location = new System.Drawing.Point(16, 398);
            this.txtLocalidadAlumno.MaxLength = 20;
            this.txtLocalidadAlumno.Multiline = true;
            this.txtLocalidadAlumno.Name = "txtLocalidadAlumno";
            this.txtLocalidadAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtLocalidadAlumno.TabIndex = 45;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Gainsboro;
            this.label26.Location = new System.Drawing.Point(232, 374);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 21);
            this.label26.TabIndex = 46;
            this.label26.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(236, 398);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 27);
            this.txtDireccion.TabIndex = 47;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(16, 152);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 27);
            this.txtNombre.TabIndex = 48;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(236, 152);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(192, 27);
            this.txtApellido.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(123, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.Black;
            this.txtMatricula.Location = new System.Drawing.Point(127, 98);
            this.txtMatricula.MaxLength = 15;
            this.txtMatricula.Multiline = true;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(192, 27);
            this.txtMatricula.TabIndex = 51;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDoc.ForeColor = System.Drawing.Color.Black;
            this.txtNroDoc.Location = new System.Drawing.Point(236, 219);
            this.txtNroDoc.MaxLength = 15;
            this.txtNroDoc.Multiline = true;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(192, 27);
            this.txtNroDoc.TabIndex = 52;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Libreta Enrolamiento",
            "Libreta Civica",
            "Libreta Verde"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(16, 225);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(192, 24);
            this.cmbTipoDoc.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "TipoDoc.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(5, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 5);
            this.panel2.TabIndex = 66;
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
            this.icnbtnAtras.Location = new System.Drawing.Point(16, 12);
            this.icnbtnAtras.Name = "icnbtnAtras";
            this.icnbtnAtras.Size = new System.Drawing.Size(228, 40);
            this.icnbtnAtras.TabIndex = 67;
            this.icnbtnAtras.Text = "Atrás";
            this.icnbtnAtras.UseVisualStyleBackColor = false;
            this.icnbtnAtras.Click += new System.EventHandler(this.icnbtnAtras_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(626, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(334, 56);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(16, 527);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(334, 56);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelModificarProfesor
            // 
            this.panelModificarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelModificarProfesor.Controls.Add(this.panel4);
            this.panelModificarProfesor.Controls.Add(this.btnGuardar);
            this.panelModificarProfesor.Controls.Add(this.btnCancelar);
            this.panelModificarProfesor.Controls.Add(this.icnbtnAtras);
            this.panelModificarProfesor.Controls.Add(this.panel2);
            this.panelModificarProfesor.Controls.Add(this.label6);
            this.panelModificarProfesor.Controls.Add(this.cmbTipoDoc);
            this.panelModificarProfesor.Controls.Add(this.txtNroDoc);
            this.panelModificarProfesor.Controls.Add(this.txtMatricula);
            this.panelModificarProfesor.Controls.Add(this.label1);
            this.panelModificarProfesor.Controls.Add(this.txtApellido);
            this.panelModificarProfesor.Controls.Add(this.txtNombre);
            this.panelModificarProfesor.Controls.Add(this.txtDireccion);
            this.panelModificarProfesor.Controls.Add(this.label26);
            this.panelModificarProfesor.Controls.Add(this.txtLocalidadAlumno);
            this.panelModificarProfesor.Controls.Add(this.label13);
            this.panelModificarProfesor.Controls.Add(this.txtEmail);
            this.panelModificarProfesor.Controls.Add(this.txtTelefonoAlumno);
            this.panelModificarProfesor.Controls.Add(this.dtmAlumno);
            this.panelModificarProfesor.Controls.Add(this.label18);
            this.panelModificarProfesor.Controls.Add(this.label19);
            this.panelModificarProfesor.Controls.Add(this.label20);
            this.panelModificarProfesor.Controls.Add(this.label21);
            this.panelModificarProfesor.Controls.Add(this.label24);
            this.panelModificarProfesor.Controls.Add(this.label25);
            this.panelModificarProfesor.Controls.Add(this.label23);
            this.panelModificarProfesor.Controls.Add(this.panel1);
            this.panelModificarProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModificarProfesor.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.panelModificarProfesor.Location = new System.Drawing.Point(0, 0);
            this.panelModificarProfesor.Name = "panelModificarProfesor";
            this.panelModificarProfesor.Size = new System.Drawing.Size(1008, 661);
            this.panelModificarProfesor.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtNivelCat);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtmFechaInicio);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtEspecializacion);
            this.panel4.Controls.Add(this.cmbReemplazante);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(643, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 318);
            this.panel4.TabIndex = 76;
            // 
            // txtNivelCat
            // 
            this.txtNivelCat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelCat.ForeColor = System.Drawing.Color.Black;
            this.txtNivelCat.Location = new System.Drawing.Point(28, 118);
            this.txtNivelCat.MaxLength = 15;
            this.txtNivelCat.Multiline = true;
            this.txtNivelCat.Name = "txtNivelCat";
            this.txtNivelCat.Size = new System.Drawing.Size(192, 27);
            this.txtNivelCat.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nivel/Cat.";
            // 
            // dtmFechaInicio
            // 
            this.dtmFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaInicio.Location = new System.Drawing.Point(28, 262);
            this.dtmFechaInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtmFechaInicio.Name = "dtmFechaInicio";
            this.dtmFechaInicio.Size = new System.Drawing.Size(259, 23);
            this.dtmFechaInicio.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(24, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // txtEspecializacion
            // 
            this.txtEspecializacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecializacion.ForeColor = System.Drawing.Color.Black;
            this.txtEspecializacion.Location = new System.Drawing.Point(28, 51);
            this.txtEspecializacion.MaxLength = 15;
            this.txtEspecializacion.Multiline = true;
            this.txtEspecializacion.Name = "txtEspecializacion";
            this.txtEspecializacion.Size = new System.Drawing.Size(192, 27);
            this.txtEspecializacion.TabIndex = 63;
            // 
            // cmbReemplazante
            // 
            this.cmbReemplazante.FormattingEnabled = true;
            this.cmbReemplazante.Items.AddRange(new object[] {
            "A",
            "B ",
            "C"});
            this.cmbReemplazante.Location = new System.Drawing.Point(28, 187);
            this.cmbReemplazante.Name = "cmbReemplazante";
            this.cmbReemplazante.Size = new System.Drawing.Size(192, 24);
            this.cmbReemplazante.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Reemplazante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Especialización:";
            // 
            // FrmModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelModificarProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarProfesor";
            this.Text = "FrmModificarProfesor";
            this.Load += new System.EventHandler(this.FrmModificarProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelModificarProfesor.ResumeLayout(false);
            this.panelModificarProfesor.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radiobtnF;
        private System.Windows.Forms.RadioButton radiobtnM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.DateTimePicker dtmAlumno;
        public System.Windows.Forms.TextBox txtTelefonoAlumno;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtLocalidadAlumno;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMatricula;
        public System.Windows.Forms.TextBox txtNroDoc;
        public System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icnbtnAtras;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        public System.Windows.Forms.Panel panelModificarProfesor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNivelCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecializacion;
        private System.Windows.Forms.ComboBox cmbReemplazante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}