namespace Front.FrmCursos
{
    partial class FormCursos
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
            this.panelCursos = new System.Windows.Forms.Panel();
            this.btnAsignarMaterias = new Front.Botones.Boton();
            this.rbtnAñoDivision = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new Front.Botones.Boton();
            this.btnActualizar = new Front.Botones.Boton();
            this.btnEliminar = new Front.Botones.Boton();
            this.btnModificar = new Front.Botones.Boton();
            this.btnBuscar = new Front.Botones.Boton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dtgCursos = new System.Windows.Forms.DataGridView();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantAlumnosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelCursos.Controls.Add(this.iconPictureBox3);
            this.panelCursos.Controls.Add(this.iconPictureBox2);
            this.panelCursos.Controls.Add(this.iconPictureBox1);
            this.panelCursos.Controls.Add(this.btnAsignarMaterias);
            this.panelCursos.Controls.Add(this.rbtnAñoDivision);
            this.panelCursos.Controls.Add(this.rbtnCodigo);
            this.panelCursos.Controls.Add(this.iconCurrentChildForm);
            this.panelCursos.Controls.Add(this.label1);
            this.panelCursos.Controls.Add(this.btnNuevo);
            this.panelCursos.Controls.Add(this.btnActualizar);
            this.panelCursos.Controls.Add(this.btnEliminar);
            this.panelCursos.Controls.Add(this.btnModificar);
            this.panelCursos.Controls.Add(this.btnBuscar);
            this.panelCursos.Controls.Add(this.txtBusqueda);
            this.panelCursos.Controls.Add(this.dtgCursos);
            this.panelCursos.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCursos.Location = new System.Drawing.Point(0, 0);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(1008, 661);
            this.panelCursos.TabIndex = 3;
            this.panelCursos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCursos_Paint);
            // 
            // btnAsignarMaterias
            // 
            this.btnAsignarMaterias.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAsignarMaterias.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAsignarMaterias.BorderColor = System.Drawing.Color.Lime;
            this.btnAsignarMaterias.BorderRadius = 0;
            this.btnAsignarMaterias.BorderSize = 0;
            this.btnAsignarMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarMaterias.FlatAppearance.BorderSize = 0;
            this.btnAsignarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarMaterias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarMaterias.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarMaterias.Location = new System.Drawing.Point(251, 573);
            this.btnAsignarMaterias.Name = "btnAsignarMaterias";
            this.btnAsignarMaterias.Size = new System.Drawing.Size(550, 35);
            this.btnAsignarMaterias.TabIndex = 29;
            this.btnAsignarMaterias.Text = "Asignar materias";
            this.btnAsignarMaterias.TextColor = System.Drawing.Color.Black;
            this.btnAsignarMaterias.UseVisualStyleBackColor = false;
            this.btnAsignarMaterias.Click += new System.EventHandler(this.btnAsignarMaterias_Click);
            // 
            // rbtnAñoDivision
            // 
            this.rbtnAñoDivision.AutoSize = true;
            this.rbtnAñoDivision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAñoDivision.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnAñoDivision.Location = new System.Drawing.Point(160, 134);
            this.rbtnAñoDivision.Name = "rbtnAñoDivision";
            this.rbtnAñoDivision.Size = new System.Drawing.Size(114, 21);
            this.rbtnAñoDivision.TabIndex = 25;
            this.rbtnAñoDivision.TabStop = true;
            this.rbtnAñoDivision.Text = "Año y división";
            this.rbtnAñoDivision.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCodigo.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnCodigo.Location = new System.Drawing.Point(73, 134);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(76, 21);
            this.rbtnCodigo.TabIndex = 24;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado de Cursos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevo.BorderColor = System.Drawing.Color.Lime;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.BorderSize = 0;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Location = new System.Drawing.Point(31, 468);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(243, 65);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Agregar";
            this.btnNuevo.TextColor = System.Drawing.Color.Black;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminar.BorderColor = System.Drawing.Color.Lime;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(753, 468);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 65);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.Black;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificar.BorderColor = System.Drawing.Color.Lime;
            this.btnModificar.BorderRadius = 0;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(401, 468);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(243, 65);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.Black;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            // dtgCursos
            // 
            this.dtgCursos.AllowUserToAddRows = false;
            this.dtgCursos.AllowUserToDeleteRows = false;
            this.dtgCursos.AutoGenerateColumns = false;
            this.dtgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCursoDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.nombreCursoDataGridViewTextBoxColumn,
            this.cantAlumnosDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dtgCursos.DataSource = this.cursoBindingSource;
            this.dtgCursos.Location = new System.Drawing.Point(31, 231);
            this.dtgCursos.Name = "dtgCursos";
            this.dtgCursos.ReadOnly = true;
            this.dtgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCursos.Size = new System.Drawing.Size(965, 218);
            this.dtgCursos.TabIndex = 0;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 39;
            this.iconPictureBox3.Location = new System.Drawing.Point(758, 480);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox3.TabIndex = 38;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(411, 480);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox2.TabIndex = 37;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 480);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox1.TabIndex = 36;
            this.iconPictureBox1.TabStop = false;
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
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(Logica.Curso);
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            this.idCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCursoDataGridViewTextBoxColumn
            // 
            this.nombreCursoDataGridViewTextBoxColumn.DataPropertyName = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.HeaderText = "nombreCurso";
            this.nombreCursoDataGridViewTextBoxColumn.Name = "nombreCursoDataGridViewTextBoxColumn";
            this.nombreCursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantAlumnosDataGridViewTextBoxColumn
            // 
            this.cantAlumnosDataGridViewTextBoxColumn.DataPropertyName = "cantAlumnos";
            this.cantAlumnosDataGridViewTextBoxColumn.HeaderText = "cantAlumnos";
            this.cantAlumnosDataGridViewTextBoxColumn.Name = "cantAlumnosDataGridViewTextBoxColumn";
            this.cantAlumnosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCursos";
            this.Text = "Gestión de cursos";
            this.Activated += new System.EventHandler(this.FormCursos_Activated);
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.panelCursos.ResumeLayout(false);
            this.panelCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCursos;
        private Botones.Boton btnAsignarMaterias;
        private System.Windows.Forms.RadioButton rbtnAñoDivision;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label label1;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnActualizar;
        private Botones.Boton btnEliminar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dtgCursos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantAlumnosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cursoBindingSource;
    }
}