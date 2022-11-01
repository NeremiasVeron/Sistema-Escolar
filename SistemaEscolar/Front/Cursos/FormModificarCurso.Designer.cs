namespace Front.FrmCursos
{
    partial class FormModificarCurso
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
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnQuitarMaterias = new FontAwesome.Sharp.IconButton();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgMateriasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.icnbtnAtras = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreceptorCargo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblModificarCurso = new System.Windows.Forms.Label();
            this.lblCantCupos = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtCantCupos = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriasSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelCursos.Controls.Add(this.cmbDivision);
            this.panelCursos.Controls.Add(this.btnGuardar);
            this.panelCursos.Controls.Add(this.btnCancelar);
            this.panelCursos.Controls.Add(this.btnQuitarMaterias);
            this.panelCursos.Controls.Add(this.txtIdCurso);
            this.panelCursos.Controls.Add(this.label5);
            this.panelCursos.Controls.Add(this.txtNombre);
            this.panelCursos.Controls.Add(this.label4);
            this.panelCursos.Controls.Add(this.label3);
            this.panelCursos.Controls.Add(this.label2);
            this.panelCursos.Controls.Add(this.cmbMaterias);
            this.panelCursos.Controls.Add(this.panel3);
            this.panelCursos.Controls.Add(this.dtgMateriasSeleccionadas);
            this.panelCursos.Controls.Add(this.icnbtnAtras);
            this.panelCursos.Controls.Add(this.label1);
            this.panelCursos.Controls.Add(this.cmbPreceptorCargo);
            this.panelCursos.Controls.Add(this.panel2);
            this.panelCursos.Controls.Add(this.txtDescripcion);
            this.panelCursos.Controls.Add(this.label21);
            this.panelCursos.Controls.Add(this.lblModificarCurso);
            this.panelCursos.Controls.Add(this.lblCantCupos);
            this.panelCursos.Controls.Add(this.label25);
            this.panelCursos.Controls.Add(this.txtCantCupos);
            this.panelCursos.Controls.Add(this.txtAño);
            this.panelCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCursos.Location = new System.Drawing.Point(0, 0);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(1008, 661);
            this.panelCursos.TabIndex = 34;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDivision.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbDivision.Location = new System.Drawing.Point(267, 135);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(110, 21);
            this.cmbDivision.TabIndex = 56;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
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
            this.btnGuardar.Location = new System.Drawing.Point(30, 532);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(334, 56);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            this.btnCancelar.Location = new System.Drawing.Point(640, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(334, 56);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitarMaterias
            // 
            this.btnQuitarMaterias.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarMaterias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMaterias.ForeColor = System.Drawing.Color.Black;
            this.btnQuitarMaterias.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.btnQuitarMaterias.IconColor = System.Drawing.Color.Black;
            this.btnQuitarMaterias.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnQuitarMaterias.IconSize = 32;
            this.btnQuitarMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarMaterias.Location = new System.Drawing.Point(788, 269);
            this.btnQuitarMaterias.Name = "btnQuitarMaterias";
            this.btnQuitarMaterias.Size = new System.Drawing.Size(186, 40);
            this.btnQuitarMaterias.TabIndex = 49;
            this.btnQuitarMaterias.Text = "Quitar materias";
            this.btnQuitarMaterias.UseVisualStyleBackColor = false;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCurso.ForeColor = System.Drawing.Color.Black;
            this.txtIdCurso.Location = new System.Drawing.Point(43, 129);
            this.txtIdCurso.MaxLength = 2;
            this.txtIdCurso.Multiline = true;
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(81, 27);
            this.txtIdCurso.TabIndex = 48;
            this.txtIdCurso.TextChanged += new System.EventHandler(this.txtIdCurso_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(39, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 47;
            this.label5.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(379, 129);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 27);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(375, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(263, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "División:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(39, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Seleccione las materias:";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMaterias.Location = new System.Drawing.Point(239, 277);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(496, 21);
            this.cmbMaterias.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 5);
            this.panel3.TabIndex = 28;
            // 
            // dtgMateriasSeleccionadas
            // 
            this.dtgMateriasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriasSeleccionadas.Location = new System.Drawing.Point(30, 323);
            this.dtgMateriasSeleccionadas.Name = "dtgMateriasSeleccionadas";
            this.dtgMateriasSeleccionadas.Size = new System.Drawing.Size(944, 193);
            this.dtgMateriasSeleccionadas.TabIndex = 38;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(652, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Preceptor a cargo:";
            // 
            // cmbPreceptorCargo
            // 
            this.cmbPreceptorCargo.FormattingEnabled = true;
            this.cmbPreceptorCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPreceptorCargo.ItemHeight = 13;
            this.cmbPreceptorCargo.Location = new System.Drawing.Point(651, 135);
            this.cmbPreceptorCargo.Name = "cmbPreceptorCargo";
            this.cmbPreceptorCargo.Size = new System.Drawing.Size(323, 21);
            this.cmbPreceptorCargo.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 5);
            this.panel2.TabIndex = 27;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(267, 182);
            this.txtDescripcion.MaxLength = 35;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(729, 61);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(157, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Descripción:";
            // 
            // lblModificarCurso
            // 
            this.lblModificarCurso.AutoSize = true;
            this.lblModificarCurso.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCurso.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblModificarCurso.Location = new System.Drawing.Point(697, 19);
            this.lblModificarCurso.Name = "lblModificarCurso";
            this.lblModificarCurso.Size = new System.Drawing.Size(301, 44);
            this.lblModificarCurso.TabIndex = 6;
            this.lblModificarCurso.Text = "Modificar Curso";
            this.lblModificarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantCupos
            // 
            this.lblCantCupos.AutoSize = true;
            this.lblCantCupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCupos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantCupos.Location = new System.Drawing.Point(511, 105);
            this.lblCantCupos.Name = "lblCantCupos";
            this.lblCantCupos.Size = new System.Drawing.Size(135, 21);
            this.lblCantCupos.TabIndex = 5;
            this.lblCantCupos.Text = "Límite de cupos:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Gainsboro;
            this.label25.Location = new System.Drawing.Point(141, 105);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 21);
            this.label25.TabIndex = 4;
            this.label25.Text = "Año:";
            // 
            // txtCantCupos
            // 
            this.txtCantCupos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCupos.ForeColor = System.Drawing.Color.Black;
            this.txtCantCupos.Location = new System.Drawing.Point(515, 129);
            this.txtCantCupos.MaxLength = 2;
            this.txtCantCupos.Multiline = true;
            this.txtCantCupos.Name = "txtCantCupos";
            this.txtCantCupos.Size = new System.Drawing.Size(121, 27);
            this.txtCantCupos.TabIndex = 5;
            this.txtCantCupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCupos_KeyPress);
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.Color.Black;
            this.txtAño.Location = new System.Drawing.Point(145, 129);
            this.txtAño.MaxLength = 10;
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(116, 27);
            this.txtAño.TabIndex = 2;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormModificarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModificarCurso";
            this.Text = "FormModificarCurso";
            this.Load += new System.EventHandler(this.FormModificarCurso_Load);
            this.panelCursos.ResumeLayout(false);
            this.panelCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriasSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgMateriasSeleccionadas;
        private FontAwesome.Sharp.IconButton icnbtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblModificarCurso;
        private System.Windows.Forms.Label lblCantCupos;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.ComboBox cmbPreceptorCargo;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCantCupos;
        public System.Windows.Forms.TextBox txtAño;
        public System.Windows.Forms.TextBox txtIdCurso;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnQuitarMaterias;
        public System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}