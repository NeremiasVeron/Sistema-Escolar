using System.Drawing;

namespace Front
{
    partial class FormAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAlumnos = new System.Windows.Forms.Panel();
            this.lblContadorAlumnos = new System.Windows.Forms.Label();
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.rbtnDocumento = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnMatricula = new System.Windows.Forms.RadioButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matAprobadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matDesaprobadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.persistenciadedatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.principalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiarLista = new Front.Botones.Boton();
            this.btnNuevoAlumno = new Front.Botones.Boton();
            this.btnActualizar = new Front.Botones.Boton();
            this.btnEliminarAlumno = new Front.Botones.Boton();
            this.btnModificarAlumno = new Front.Botones.Boton();
            this.btnBuscar = new Front.Botones.Boton();
            this.cmbTipodoc = new System.Windows.Forms.ComboBox();
            this.panelAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistenciadedatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelAlumnos.Controls.Add(this.cmbTipodoc);
            this.panelAlumnos.Controls.Add(this.lblContadorAlumnos);
            this.panelAlumnos.Controls.Add(this.gridAlumnos);
            this.panelAlumnos.Controls.Add(this.iconPictureBox4);
            this.panelAlumnos.Controls.Add(this.iconPictureBox5);
            this.panelAlumnos.Controls.Add(this.iconPictureBox6);
            this.panelAlumnos.Controls.Add(this.btnLimpiarLista);
            this.panelAlumnos.Controls.Add(this.rbtnDocumento);
            this.panelAlumnos.Controls.Add(this.rbtnNombre);
            this.panelAlumnos.Controls.Add(this.rbtnMatricula);
            this.panelAlumnos.Controls.Add(this.iconCurrentChildForm);
            this.panelAlumnos.Controls.Add(this.label1);
            this.panelAlumnos.Controls.Add(this.btnNuevoAlumno);
            this.panelAlumnos.Controls.Add(this.btnActualizar);
            this.panelAlumnos.Controls.Add(this.btnEliminarAlumno);
            this.panelAlumnos.Controls.Add(this.btnModificarAlumno);
            this.panelAlumnos.Controls.Add(this.btnBuscar);
            this.panelAlumnos.Controls.Add(this.txtBusqueda);
            this.panelAlumnos.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlumnos.Location = new System.Drawing.Point(0, 0);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(1008, 661);
            this.panelAlumnos.TabIndex = 2;
            this.panelAlumnos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlumnos_Paint);
            // 
            // lblContadorAlumnos
            // 
            this.lblContadorAlumnos.AutoSize = true;
            this.lblContadorAlumnos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblContadorAlumnos.Location = new System.Drawing.Point(237, 189);
            this.lblContadorAlumnos.Name = "lblContadorAlumnos";
            this.lblContadorAlumnos.Size = new System.Drawing.Size(21, 23);
            this.lblContadorAlumnos.TabIndex = 40;
            this.lblContadorAlumnos.Text = "0";
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.AllowUserToAddRows = false;
            this.gridAlumnos.AllowUserToDeleteRows = false;
            this.gridAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAlumnos.AutoGenerateColumns = false;
            this.gridAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.gridAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.idCursoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.tipoDocDataGridViewTextBoxColumn,
            this.numeroDocDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.nroTelefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.matAprobadasDataGridViewTextBoxColumn,
            this.matDesaprobadasDataGridViewTextBoxColumn,
            this.condicionDataGridViewCheckBoxColumn});
            this.gridAlumnos.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAlumnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridAlumnos.EnableHeadersVisualStyles = false;
            this.gridAlumnos.GridColor = System.Drawing.Color.Gainsboro;
            this.gridAlumnos.Location = new System.Drawing.Point(31, 230);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.ReadOnly = true;
            this.gridAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAlumnos.RowHeadersVisible = false;
            this.gridAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlumnos.Size = new System.Drawing.Size(965, 218);
            this.gridAlumnos.TabIndex = 39;
            this.gridAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAlumnos_CellContentClick);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 39;
            this.iconPictureBox4.Location = new System.Drawing.Point(760, 480);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox4.TabIndex = 38;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox5.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 39;
            this.iconPictureBox5.Location = new System.Drawing.Point(410, 480);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox5.TabIndex = 37;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 39;
            this.iconPictureBox6.Location = new System.Drawing.Point(31, 480);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox6.TabIndex = 36;
            this.iconPictureBox6.TabStop = false;
            // 
            // rbtnDocumento
            // 
            this.rbtnDocumento.AutoSize = true;
            this.rbtnDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDocumento.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnDocumento.Location = new System.Drawing.Point(311, 135);
            this.rbtnDocumento.Name = "rbtnDocumento";
            this.rbtnDocumento.Size = new System.Drawing.Size(104, 21);
            this.rbtnDocumento.TabIndex = 27;
            this.rbtnDocumento.TabStop = true;
            this.rbtnDocumento.Text = "Documento";
            this.rbtnDocumento.UseVisualStyleBackColor = true;
            this.rbtnDocumento.CheckedChanged += new System.EventHandler(this.rbtnDocumento_CheckedChanged);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnNombre.Location = new System.Drawing.Point(207, 134);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnNombre.TabIndex = 25;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            this.rbtnNombre.CheckedChanged += new System.EventHandler(this.rbtnNombre_CheckedChanged);
            // 
            // rbtnMatricula
            // 
            this.rbtnMatricula.AutoSize = true;
            this.rbtnMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMatricula.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnMatricula.Location = new System.Drawing.Point(101, 134);
            this.rbtnMatricula.Name = "rbtnMatricula";
            this.rbtnMatricula.Size = new System.Drawing.Size(86, 21);
            this.rbtnMatricula.TabIndex = 24;
            this.rbtnMatricula.TabStop = true;
            this.rbtnMatricula.Text = "Matricula";
            this.rbtnMatricula.UseVisualStyleBackColor = true;
            this.rbtnMatricula.CheckedChanged += new System.EventHandler(this.rbtnMatricula_CheckedChanged);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(31, 74);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(41, 39);
            this.iconCurrentChildForm.TabIndex = 23;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado de Alumnos:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.Location = new System.Drawing.Point(73, 80);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(571, 27);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "IDCurso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocDataGridViewTextBoxColumn
            // 
            this.tipoDocDataGridViewTextBoxColumn.DataPropertyName = "tipoDoc";
            this.tipoDocDataGridViewTextBoxColumn.HeaderText = "TipoDoc.";
            this.tipoDocDataGridViewTextBoxColumn.Name = "tipoDocDataGridViewTextBoxColumn";
            this.tipoDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDocDataGridViewTextBoxColumn
            // 
            this.numeroDocDataGridViewTextBoxColumn.DataPropertyName = "numeroDoc";
            this.numeroDocDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.numeroDocDataGridViewTextBoxColumn.Name = "numeroDocDataGridViewTextBoxColumn";
            this.numeroDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nroTelefonoDataGridViewTextBoxColumn
            // 
            this.nroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "nroTelefono";
            this.nroTelefonoDataGridViewTextBoxColumn.HeaderText = "Tel.";
            this.nroTelefonoDataGridViewTextBoxColumn.Name = "nroTelefonoDataGridViewTextBoxColumn";
            this.nroTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direc.";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNac.";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matAprobadasDataGridViewTextBoxColumn
            // 
            this.matAprobadasDataGridViewTextBoxColumn.DataPropertyName = "matAprobadas";
            this.matAprobadasDataGridViewTextBoxColumn.HeaderText = "MatApro.";
            this.matAprobadasDataGridViewTextBoxColumn.Name = "matAprobadasDataGridViewTextBoxColumn";
            this.matAprobadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matDesaprobadasDataGridViewTextBoxColumn
            // 
            this.matDesaprobadasDataGridViewTextBoxColumn.DataPropertyName = "matDesaprobadas";
            this.matDesaprobadasDataGridViewTextBoxColumn.HeaderText = "MatDesapro.";
            this.matDesaprobadasDataGridViewTextBoxColumn.Name = "matDesaprobadasDataGridViewTextBoxColumn";
            this.matDesaprobadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // condicionDataGridViewCheckBoxColumn
            // 
            this.condicionDataGridViewCheckBoxColumn.DataPropertyName = "condicion";
            this.condicionDataGridViewCheckBoxColumn.HeaderText = "Condicion";
            this.condicionDataGridViewCheckBoxColumn.Name = "condicionDataGridViewCheckBoxColumn";
            this.condicionDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Logica.Alumno);
            // 
            // persistenciadedatosBindingSource
            // 
            this.persistenciadedatosBindingSource.DataSource = typeof(Logica.Persistenciadedatos);
            this.persistenciadedatosBindingSource.CurrentChanged += new System.EventHandler(this.persistenciadedatosBindingSource_CurrentChanged);
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataSource = typeof(Logica.Principal);
            this.principalBindingSource.CurrentChanged += new System.EventHandler(this.principalBindingSource_CurrentChanged);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiarLista.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiarLista.BorderColor = System.Drawing.Color.Lime;
            this.btnLimpiarLista.BorderRadius = 0;
            this.btnLimpiarLista.BorderSize = 0;
            this.btnLimpiarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarLista.FlatAppearance.BorderSize = 0;
            this.btnLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarLista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarLista.Location = new System.Drawing.Point(251, 573);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(550, 35);
            this.btnLimpiarLista.TabIndex = 29;
            this.btnLimpiarLista.Text = "Limpiar lista completa";
            this.btnLimpiarLista.TextColor = System.Drawing.Color.Black;
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click_1);
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevoAlumno.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevoAlumno.BorderColor = System.Drawing.Color.Lime;
            this.btnNuevoAlumno.BorderRadius = 0;
            this.btnNuevoAlumno.BorderSize = 0;
            this.btnNuevoAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoAlumno.FlatAppearance.BorderSize = 0;
            this.btnNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoAlumno.Location = new System.Drawing.Point(31, 468);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(243, 65);
            this.btnNuevoAlumno.TabIndex = 14;
            this.btnNuevoAlumno.Text = "Agregar";
            this.btnNuevoAlumno.TextColor = System.Drawing.Color.Black;
            this.btnNuevoAlumno.UseVisualStyleBackColor = false;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnActualizar.BorderRadius = 40;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(823, 74);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(155, 39);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.Black;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminarAlumno.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminarAlumno.BorderColor = System.Drawing.Color.Lime;
            this.btnEliminarAlumno.BorderRadius = 0;
            this.btnEliminarAlumno.BorderSize = 0;
            this.btnEliminarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAlumno.FlatAppearance.BorderSize = 0;
            this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(753, 468);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(243, 65);
            this.btnEliminarAlumno.TabIndex = 12;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.TextColor = System.Drawing.Color.Black;
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificarAlumno.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificarAlumno.BorderColor = System.Drawing.Color.Lime;
            this.btnModificarAlumno.BorderRadius = 0;
            this.btnModificarAlumno.BorderSize = 0;
            this.btnModificarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAlumno.FlatAppearance.BorderSize = 0;
            this.btnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.ForeColor = System.Drawing.Color.Black;
            this.btnModificarAlumno.Location = new System.Drawing.Point(401, 468);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(243, 65);
            this.btnModificarAlumno.TabIndex = 11;
            this.btnModificarAlumno.Text = "Modificar";
            this.btnModificarAlumno.TextColor = System.Drawing.Color.Black;
            this.btnModificarAlumno.UseVisualStyleBackColor = false;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscar.BorderRadius = 40;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(662, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 39);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.Black;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbTipodoc
            // 
            this.cmbTipodoc.FormattingEnabled = true;
            this.cmbTipodoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbTipodoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Libreta Enrolamiento",
            "Libreta Civica",
            "Libreta Verde"});
            this.cmbTipodoc.Location = new System.Drawing.Point(451, 136);
            this.cmbTipodoc.Name = "cmbTipodoc";
            this.cmbTipodoc.Size = new System.Drawing.Size(193, 21);
            this.cmbTipodoc.TabIndex = 41;
            this.cmbTipodoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipodoc_SelectedIndexChanged);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumnos";
            this.Text = "Gestion de alumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            this.panelAlumnos.ResumeLayout(false);
            this.panelAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistenciadedatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlumnos;
        private Botones.Boton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private Botones.Boton btnEliminarAlumno;
        private Botones.Boton btnModificarAlumno;
        private Botones.Boton btnActualizar;
        private Botones.Boton btnNuevoAlumno;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.BindingSource persistenciadedatosBindingSource;
        private System.Windows.Forms.BindingSource principalBindingSource;
        private System.Windows.Forms.RadioButton rbtnDocumento;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnMatricula;
        private Botones.Boton btnLimpiarLista;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matAprobadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matDesaprobadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn condicionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblContadorAlumnos;
        private System.Windows.Forms.ComboBox cmbTipodoc;
    }
}