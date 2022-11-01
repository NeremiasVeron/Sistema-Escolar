namespace Front.FrmCursos
{
    partial class FormAltaCursos
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
            this.dtgMateriasSeleccionadas = new System.Windows.Forms.DataGridView();
            this.btnQuitarMaterias = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.icnbtnAtras = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreceptorCargo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblNuevoCurso = new System.Windows.Forms.Label();
            this.txtCantCupos = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lblCantCupos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriasSeleccionadas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelCursos.Controls.Add(this.cmbDivision);
            this.panelCursos.Controls.Add(this.btnGuardar);
            this.panelCursos.Controls.Add(this.btnCancelar);
            this.panelCursos.Controls.Add(this.dtgMateriasSeleccionadas);
            this.panelCursos.Controls.Add(this.btnQuitarMaterias);
            this.panelCursos.Controls.Add(this.label2);
            this.panelCursos.Controls.Add(this.cmbMaterias);
            this.panelCursos.Controls.Add(this.txtNombre);
            this.panelCursos.Controls.Add(this.label4);
            this.panelCursos.Controls.Add(this.label3);
            this.panelCursos.Controls.Add(this.icnbtnAtras);
            this.panelCursos.Controls.Add(this.label1);
            this.panelCursos.Controls.Add(this.cmbPreceptorCargo);
            this.panelCursos.Controls.Add(this.panel2);
            this.panelCursos.Controls.Add(this.txtDescripcion);
            this.panelCursos.Controls.Add(this.label21);
            this.panelCursos.Controls.Add(this.lblNuevoCurso);
            this.panelCursos.Controls.Add(this.txtCantCupos);
            this.panelCursos.Controls.Add(this.panel3);
            this.panelCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCursos.Location = new System.Drawing.Point(0, 0);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(992, 622);
            this.panelCursos.TabIndex = 33;
            this.panelCursos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCursos_Paint);
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDivision.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbDivision.Location = new System.Drawing.Point(154, 135);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(110, 21);
            this.cmbDivision.TabIndex = 55;
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
            this.btnGuardar.Location = new System.Drawing.Point(23, 543);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(334, 56);
            this.btnGuardar.TabIndex = 7;
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
            this.btnCancelar.Location = new System.Drawing.Point(633, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(334, 56);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtgMateriasSeleccionadas
            // 
            this.dtgMateriasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMateriasSeleccionadas.Location = new System.Drawing.Point(23, 334);
            this.dtgMateriasSeleccionadas.Name = "dtgMateriasSeleccionadas";
            this.dtgMateriasSeleccionadas.Size = new System.Drawing.Size(944, 193);
            this.dtgMateriasSeleccionadas.TabIndex = 53;
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
            this.btnQuitarMaterias.Location = new System.Drawing.Point(781, 287);
            this.btnQuitarMaterias.Name = "btnQuitarMaterias";
            this.btnQuitarMaterias.Size = new System.Drawing.Size(186, 40);
            this.btnQuitarMaterias.TabIndex = 52;
            this.btnQuitarMaterias.Text = "Quitar materias";
            this.btnQuitarMaterias.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(29, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Seleccione las materias:";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbMaterias.Location = new System.Drawing.Point(229, 299);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(496, 21);
            this.cmbMaterias.TabIndex = 50;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(283, 129);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 27);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(279, 105);
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
            this.label3.Location = new System.Drawing.Point(154, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "División:";
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
            this.label1.Location = new System.Drawing.Point(647, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Preceptor a cargo:";
            // 
            // cmbPreceptorCargo
            // 
            this.cmbPreceptorCargo.FormattingEnabled = true;
            this.cmbPreceptorCargo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbPreceptorCargo.Location = new System.Drawing.Point(651, 135);
            this.cmbPreceptorCargo.Name = "cmbPreceptorCargo";
            this.cmbPreceptorCargo.Size = new System.Drawing.Size(323, 21);
            this.cmbPreceptorCargo.TabIndex = 5;
            this.cmbPreceptorCargo.SelectedIndexChanged += new System.EventHandler(this.cmbPreceptorCargo_SelectedIndexChanged);
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
            this.txtDescripcion.Location = new System.Drawing.Point(92, 185);
            this.txtDescripcion.MaxLength = 35;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(729, 61);
            this.txtDescripcion.TabIndex = 40;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(88, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Descripción:";
            // 
            // lblNuevoCurso
            // 
            this.lblNuevoCurso.AutoSize = true;
            this.lblNuevoCurso.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCurso.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNuevoCurso.Location = new System.Drawing.Point(697, 19);
            this.lblNuevoCurso.Name = "lblNuevoCurso";
            this.lblNuevoCurso.Size = new System.Drawing.Size(250, 44);
            this.lblNuevoCurso.TabIndex = 6;
            this.lblNuevoCurso.Text = "Nuevo Curso";
            this.lblNuevoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantCupos
            // 
            this.txtCantCupos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCupos.ForeColor = System.Drawing.Color.Black;
            this.txtCantCupos.Location = new System.Drawing.Point(451, 129);
            this.txtCantCupos.MaxLength = 2;
            this.txtCantCupos.Multiline = true;
            this.txtCantCupos.Name = "txtCantCupos";
            this.txtCantCupos.Size = new System.Drawing.Size(121, 27);
            this.txtCantCupos.TabIndex = 4;
            this.txtCantCupos.TextChanged += new System.EventHandler(this.txtCantCupos_TextChanged);
            this.txtCantCupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCupos_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtAño);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.lblCantCupos);
            this.panel3.Location = new System.Drawing.Point(7, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 169);
            this.panel3.TabIndex = 56;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.ForeColor = System.Drawing.Color.Black;
            this.txtAño.Location = new System.Drawing.Point(3, 30);
            this.txtAño.MaxLength = 10;
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(116, 27);
            this.txtAño.TabIndex = 1;
            this.txtAño.TextChanged += new System.EventHandler(this.txtAño_TextChanged);
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Gainsboro;
            this.label25.Location = new System.Drawing.Point(-1, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 21);
            this.label25.TabIndex = 4;
            this.label25.Text = "Año:";
            // 
            // lblCantCupos
            // 
            this.lblCantCupos.AutoSize = true;
            this.lblCantCupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCupos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCantCupos.Location = new System.Drawing.Point(438, 6);
            this.lblCantCupos.Name = "lblCantCupos";
            this.lblCantCupos.Size = new System.Drawing.Size(97, 21);
            this.lblCantCupos.TabIndex = 5;
            this.lblCantCupos.Text = "Lím. Cupos:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAltaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 622);
            this.Controls.Add(this.panelCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaCursos";
            this.Text = "Gestion de cursos";
            this.Load += new System.EventHandler(this.FormAltaCursos_Load);
            this.panelCursos.ResumeLayout(false);
            this.panelCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMateriasSeleccionadas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCursos;
        private FontAwesome.Sharp.IconButton icnbtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPreceptorCargo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblNuevoCurso;
        private System.Windows.Forms.Label lblCantCupos;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCantCupos;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnQuitarMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.DataGridView dtgMateriasSeleccionadas;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}