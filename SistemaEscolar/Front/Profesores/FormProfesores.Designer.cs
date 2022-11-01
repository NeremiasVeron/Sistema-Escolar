namespace Front.Profesores
{
    partial class FormProfesores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelProfesores = new System.Windows.Forms.Panel();
            this.btnLimpiarLista = new Front.Botones.Boton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnDocumento = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnNroLegajo = new System.Windows.Forms.RadioButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoAlumno = new Front.Botones.Boton();
            this.btnActualizar = new Front.Botones.Boton();
            this.btnEliminarAlumno = new Front.Botones.Boton();
            this.btnModificarAlumno = new Front.Botones.Boton();
            this.btnBuscar = new Front.Botones.Boton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.gridProfesores = new System.Windows.Forms.DataGridView();
            this.nroLegajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especializacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antiguedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reemplazanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.panelProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfesores
            // 
            this.panelProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelProfesores.Controls.Add(this.iconPictureBox4);
            this.panelProfesores.Controls.Add(this.iconPictureBox5);
            this.panelProfesores.Controls.Add(this.btnLimpiarLista);
            this.panelProfesores.Controls.Add(this.iconPictureBox6);
            this.panelProfesores.Controls.Add(this.radioButton1);
            this.panelProfesores.Controls.Add(this.rbtnDocumento);
            this.panelProfesores.Controls.Add(this.rbtnNombre);
            this.panelProfesores.Controls.Add(this.rbtnNroLegajo);
            this.panelProfesores.Controls.Add(this.iconCurrentChildForm);
            this.panelProfesores.Controls.Add(this.label1);
            this.panelProfesores.Controls.Add(this.btnNuevoAlumno);
            this.panelProfesores.Controls.Add(this.btnActualizar);
            this.panelProfesores.Controls.Add(this.btnEliminarAlumno);
            this.panelProfesores.Controls.Add(this.btnModificarAlumno);
            this.panelProfesores.Controls.Add(this.btnBuscar);
            this.panelProfesores.Controls.Add(this.txtBusqueda);
            this.panelProfesores.Controls.Add(this.gridProfesores);
            this.panelProfesores.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfesores.Location = new System.Drawing.Point(0, 0);
            this.panelProfesores.Name = "panelProfesores";
            this.panelProfesores.Size = new System.Drawing.Size(1008, 661);
            this.panelProfesores.TabIndex = 3;
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
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(316, 134);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 21);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Apellido";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnDocumento
            // 
            this.rbtnDocumento.AutoSize = true;
            this.rbtnDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDocumento.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnDocumento.Location = new System.Drawing.Point(401, 134);
            this.rbtnDocumento.Name = "rbtnDocumento";
            this.rbtnDocumento.Size = new System.Drawing.Size(104, 21);
            this.rbtnDocumento.TabIndex = 27;
            this.rbtnDocumento.TabStop = true;
            this.rbtnDocumento.Text = "Documento";
            this.rbtnDocumento.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnNombre.Location = new System.Drawing.Point(231, 134);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnNombre.TabIndex = 25;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnNroLegajo
            // 
            this.rbtnNroLegajo.AutoSize = true;
            this.rbtnNroLegajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNroLegajo.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnNroLegajo.Location = new System.Drawing.Point(119, 134);
            this.rbtnNroLegajo.Name = "rbtnNroLegajo";
            this.rbtnNroLegajo.Size = new System.Drawing.Size(93, 21);
            this.rbtnNroLegajo.TabIndex = 24;
            this.rbtnNroLegajo.TabStop = true;
            this.rbtnNroLegajo.Text = "NroLegajo";
            this.rbtnNroLegajo.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado de Profesores";
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
            // 
            // gridProfesores
            // 
            this.gridProfesores.AllowUserToAddRows = false;
            this.gridProfesores.AllowUserToDeleteRows = false;
            this.gridProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProfesores.AutoGenerateColumns = false;
            this.gridProfesores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.gridProfesores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridProfesores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroLegajoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.tipoDocDataGridViewTextBoxColumn,
            this.numeroDocDataGridViewTextBoxColumn,
            this.especializacionDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.antiguedadDataGridViewTextBoxColumn,
            this.reemplazanteDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.nroTelefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.gridProfesores.DataSource = this.profesorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProfesores.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProfesores.EnableHeadersVisualStyles = false;
            this.gridProfesores.GridColor = System.Drawing.Color.Gainsboro;
            this.gridProfesores.Location = new System.Drawing.Point(31, 231);
            this.gridProfesores.Name = "gridProfesores";
            this.gridProfesores.ReadOnly = true;
            this.gridProfesores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProfesores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProfesores.RowHeadersVisible = false;
            this.gridProfesores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfesores.Size = new System.Drawing.Size(965, 218);
            this.gridProfesores.TabIndex = 0;
            // 
            // nroLegajoDataGridViewTextBoxColumn
            // 
            this.nroLegajoDataGridViewTextBoxColumn.DataPropertyName = "nroLegajo";
            this.nroLegajoDataGridViewTextBoxColumn.HeaderText = "NroLegajo";
            this.nroLegajoDataGridViewTextBoxColumn.Name = "nroLegajoDataGridViewTextBoxColumn";
            this.nroLegajoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.numeroDocDataGridViewTextBoxColumn.HeaderText = "NroDoc.";
            this.numeroDocDataGridViewTextBoxColumn.Name = "numeroDocDataGridViewTextBoxColumn";
            this.numeroDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especializacionDataGridViewTextBoxColumn
            // 
            this.especializacionDataGridViewTextBoxColumn.DataPropertyName = "especializacion";
            this.especializacionDataGridViewTextBoxColumn.HeaderText = "Esp.";
            this.especializacionDataGridViewTextBoxColumn.Name = "especializacionDataGridViewTextBoxColumn";
            this.especializacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // antiguedadDataGridViewTextBoxColumn
            // 
            this.antiguedadDataGridViewTextBoxColumn.DataPropertyName = "antiguedad";
            this.antiguedadDataGridViewTextBoxColumn.HeaderText = "Antiguedad";
            this.antiguedadDataGridViewTextBoxColumn.Name = "antiguedadDataGridViewTextBoxColumn";
            this.antiguedadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reemplazanteDataGridViewTextBoxColumn
            // 
            this.reemplazanteDataGridViewTextBoxColumn.DataPropertyName = "reemplazante";
            this.reemplazanteDataGridViewTextBoxColumn.HeaderText = "Reemplazante";
            this.reemplazanteDataGridViewTextBoxColumn.Name = "reemplazanteDataGridViewTextBoxColumn";
            this.reemplazanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNac.";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
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
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(Logica.Profesor);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 39;
            this.iconPictureBox4.Location = new System.Drawing.Point(760, 483);
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
            this.iconPictureBox5.Location = new System.Drawing.Point(406, 483);
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
            this.iconPictureBox6.Location = new System.Drawing.Point(33, 483);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox6.TabIndex = 36;
            this.iconPictureBox6.TabStop = false;
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesores";
            this.Text = "Gestión profesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            this.panelProfesores.ResumeLayout(false);
            this.panelProfesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProfesores;
        private Botones.Boton btnLimpiarLista;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtnDocumento;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnNroLegajo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label label1;
        private Botones.Boton btnNuevoAlumno;
        private Botones.Boton btnActualizar;
        private Botones.Boton btnEliminarAlumno;
        private Botones.Boton btnModificarAlumno;
        private Botones.Boton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView gridProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroLegajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especializacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antiguedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reemplazanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
    }
}