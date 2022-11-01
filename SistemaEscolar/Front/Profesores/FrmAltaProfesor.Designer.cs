namespace Front.Profesores
{
    partial class FrmAltaProfesor
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
            this.cmbReemplazante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipodoc = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtLocalidadAlumno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiobtnF = new System.Windows.Forms.RadioButton();
            this.radiobtnM = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.dtmAlumno = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.lblNuevoAlumno = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEspecializacion = new System.Windows.Forms.TextBox();
            this.dtmFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNivelCat = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.icnbtnAtras = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.txtNivelCat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtmFechaInicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEspecializacion);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbReemplazante);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.icnbtnAtras);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblNuevoAlumno);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 661);
            this.panel1.TabIndex = 33;
            // 
            // cmbReemplazante
            // 
            this.cmbReemplazante.FormattingEnabled = true;
            this.cmbReemplazante.Items.AddRange(new object[] {
            "A",
            "B ",
            "C"});
            this.cmbReemplazante.Location = new System.Drawing.Point(578, 270);
            this.cmbReemplazante.Name = "cmbReemplazante";
            this.cmbReemplazante.Size = new System.Drawing.Size(192, 21);
            this.cmbReemplazante.TabIndex = 40;
            this.cmbReemplazante.SelectedIndexChanged += new System.EventHandler(this.cmbDivisiones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(574, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Reemplazante:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(574, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Especialización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "TipoDoc.";
            // 
            // cmbTipodoc
            // 
            this.cmbTipodoc.FormattingEnabled = true;
            this.cmbTipodoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipodoc.Location = new System.Drawing.Point(45, 113);
            this.cmbTipodoc.Name = "cmbTipodoc";
            this.cmbTipodoc.Size = new System.Drawing.Size(193, 21);
            this.cmbTipodoc.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(261, 293);
            this.txtDireccion.MaxLength = 25;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 27);
            this.txtDireccion.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Gainsboro;
            this.label26.Location = new System.Drawing.Point(257, 269);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 21);
            this.label26.TabIndex = 32;
            this.label26.Text = "Dirección:";
            // 
            // txtLocalidadAlumno
            // 
            this.txtLocalidadAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidadAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtLocalidadAlumno.Location = new System.Drawing.Point(43, 293);
            this.txtLocalidadAlumno.MaxLength = 20;
            this.txtLocalidadAlumno.Multiline = true;
            this.txtLocalidadAlumno.Name = "txtLocalidadAlumno";
            this.txtLocalidadAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtLocalidadAlumno.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(41, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Localidad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 5);
            this.panel2.TabIndex = 27;
            // 
            // radiobtnF
            // 
            this.radiobtnF.AutoSize = true;
            this.radiobtnF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnF.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnF.Location = new System.Drawing.Point(237, 345);
            this.radiobtnF.Name = "radiobtnF";
            this.radiobtnF.Size = new System.Drawing.Size(87, 20);
            this.radiobtnF.TabIndex = 23;
            this.radiobtnF.TabStop = true;
            this.radiobtnF.Text = "Femenino";
            this.radiobtnF.UseVisualStyleBackColor = true;
            // 
            // radiobtnM
            // 
            this.radiobtnM.AutoSize = true;
            this.radiobtnM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnM.ForeColor = System.Drawing.SystemColors.Control;
            this.radiobtnM.Location = new System.Drawing.Point(135, 345);
            this.radiobtnM.Name = "radiobtnM";
            this.radiobtnM.Size = new System.Drawing.Size(92, 20);
            this.radiobtnM.TabIndex = 9;
            this.radiobtnM.TabStop = true;
            this.radiobtnM.Text = "Masculino";
            this.radiobtnM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radiobtnM.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(261, 239);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlumno.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(43, 239);
            this.txtTelefonoAlumno.MaxLength = 15;
            this.txtTelefonoAlumno.Multiline = true;
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(192, 27);
            this.txtTelefonoAlumno.TabIndex = 5;
            // 
            // dtmAlumno
            // 
            this.dtmAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmAlumno.Location = new System.Drawing.Point(43, 180);
            this.dtmAlumno.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtmAlumno.Name = "dtmAlumno";
            this.dtmAlumno.Size = new System.Drawing.Size(410, 23);
            this.dtmAlumno.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(53, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Sexo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(39, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "Fecha de nacimiento:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(257, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 12;
            this.label19.Text = "Correo:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(41, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 21);
            this.label20.TabIndex = 11;
            this.label20.Text = "Teléfono:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(257, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Nro Doc.:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDoc.ForeColor = System.Drawing.Color.Black;
            this.txtNroDoc.Location = new System.Drawing.Point(261, 107);
            this.txtNroDoc.MaxLength = 9;
            this.txtNroDoc.Multiline = true;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(192, 27);
            this.txtNroDoc.TabIndex = 3;
            // 
            // lblNuevoAlumno
            // 
            this.lblNuevoAlumno.AutoSize = true;
            this.lblNuevoAlumno.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAlumno.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNuevoAlumno.Location = new System.Drawing.Point(697, 19);
            this.lblNuevoAlumno.Name = "lblNuevoAlumno";
            this.lblNuevoAlumno.Size = new System.Drawing.Size(293, 44);
            this.lblNuevoAlumno.TabIndex = 6;
            this.lblNuevoAlumno.Text = "Nuevo profesor";
            this.lblNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radiobtnF);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.radiobtnM);
            this.panel3.Controls.Add(this.txtDireccion);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtLocalidadAlumno);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtmAlumno);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.cmbTipodoc);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.txtNroDoc);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtTelefonoAlumno);
            this.panel3.Location = new System.Drawing.Point(14, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 392);
            this.panel3.TabIndex = 54;
            // 
            // txtEspecializacion
            // 
            this.txtEspecializacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecializacion.ForeColor = System.Drawing.Color.Black;
            this.txtEspecializacion.Location = new System.Drawing.Point(578, 134);
            this.txtEspecializacion.MaxLength = 15;
            this.txtEspecializacion.Multiline = true;
            this.txtEspecializacion.Name = "txtEspecializacion";
            this.txtEspecializacion.Size = new System.Drawing.Size(192, 27);
            this.txtEspecializacion.TabIndex = 55;
            // 
            // dtmFechaInicio
            // 
            this.dtmFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaInicio.Location = new System.Drawing.Point(578, 345);
            this.dtmFechaInicio.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtmFechaInicio.Name = "dtmFechaInicio";
            this.dtmFechaInicio.Size = new System.Drawing.Size(259, 23);
            this.dtmFechaInicio.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(574, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(576, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nivel/Cat.";
            // 
            // txtNivelCat
            // 
            this.txtNivelCat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelCat.ForeColor = System.Drawing.Color.Black;
            this.txtNivelCat.Location = new System.Drawing.Point(578, 201);
            this.txtNivelCat.MaxLength = 15;
            this.txtNivelCat.Multiline = true;
            this.txtNivelCat.Name = "txtNivelCat";
            this.txtNivelCat.Size = new System.Drawing.Size(192, 27);
            this.txtNivelCat.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(569, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 290);
            this.panel4.TabIndex = 58;
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
            // FrmAltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaProfesor";
            this.Text = "FrmAltaProfesor";
            this.Load += new System.EventHandler(this.FrmAltaProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbReemplazante;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icnbtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipodoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtLocalidadAlumno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radiobtnF;
        private System.Windows.Forms.RadioButton radiobtnM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.DateTimePicker dtmAlumno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblNuevoAlumno;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtmFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEspecializacion;
        private System.Windows.Forms.TextBox txtNivelCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
    }
}