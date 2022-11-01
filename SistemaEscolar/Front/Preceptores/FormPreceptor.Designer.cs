namespace Front.Preceptores
{
    partial class FormPreceptor
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
            this.panelPreceptor = new System.Windows.Forms.Panel();
            this.btnLimpiarLista = new Front.Botones.Boton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new Front.Botones.Boton();
            this.btnActualizar = new Front.Botones.Boton();
            this.btnEliminar = new Front.Botones.Boton();
            this.btnModificar = new Front.Botones.Boton();
            this.btnBuscar = new Front.Botones.Boton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dtgPreceptores = new System.Windows.Forms.DataGridView();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelPreceptor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreceptores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPreceptor
            // 
            this.panelPreceptor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelPreceptor.Controls.Add(this.iconPictureBox3);
            this.panelPreceptor.Controls.Add(this.iconPictureBox2);
            this.panelPreceptor.Controls.Add(this.iconPictureBox1);
            this.panelPreceptor.Controls.Add(this.btnLimpiarLista);
            this.panelPreceptor.Controls.Add(this.rbtnNombre);
            this.panelPreceptor.Controls.Add(this.rbtnCodigo);
            this.panelPreceptor.Controls.Add(this.iconCurrentChildForm);
            this.panelPreceptor.Controls.Add(this.label1);
            this.panelPreceptor.Controls.Add(this.btnNuevo);
            this.panelPreceptor.Controls.Add(this.btnActualizar);
            this.panelPreceptor.Controls.Add(this.btnEliminar);
            this.panelPreceptor.Controls.Add(this.btnModificar);
            this.panelPreceptor.Controls.Add(this.btnBuscar);
            this.panelPreceptor.Controls.Add(this.txtBusqueda);
            this.panelPreceptor.Controls.Add(this.dtgPreceptores);
            this.panelPreceptor.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPreceptor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreceptor.Location = new System.Drawing.Point(0, 0);
            this.panelPreceptor.Name = "panelPreceptor";
            this.panelPreceptor.Size = new System.Drawing.Size(1008, 661);
            this.panelPreceptor.TabIndex = 4;
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
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbtnNombre.Location = new System.Drawing.Point(160, 134);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(79, 21);
            this.rbtnNombre.TabIndex = 25;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Listado de Preceptores";
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // dtgPreceptores
            // 
            this.dtgPreceptores.AllowUserToAddRows = false;
            this.dtgPreceptores.AllowUserToDeleteRows = false;
            this.dtgPreceptores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPreceptores.Location = new System.Drawing.Point(31, 231);
            this.dtgPreceptores.Name = "dtgPreceptores";
            this.dtgPreceptores.ReadOnly = true;
            this.dtgPreceptores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPreceptores.Size = new System.Drawing.Size(965, 218);
            this.dtgPreceptores.TabIndex = 0;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Tomato;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Tomato;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 39;
            this.iconPictureBox3.Location = new System.Drawing.Point(760, 482);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox3.TabIndex = 35;
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
            this.iconPictureBox2.Location = new System.Drawing.Point(413, 482);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox2.TabIndex = 34;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(40, 482);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 39);
            this.iconPictureBox1.TabIndex = 33;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormPreceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelPreceptor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPreceptor";
            this.Text = "Gestión de preceptores";
            this.Load += new System.EventHandler(this.FrmPreceptor_Load);
            this.panelPreceptor.ResumeLayout(false);
            this.panelPreceptor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreceptores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPreceptor;
        private Botones.Boton btnLimpiarLista;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label label1;
        private Botones.Boton btnNuevo;
        private Botones.Boton btnActualizar;
        private Botones.Boton btnEliminar;
        private Botones.Boton btnModificar;
        private Botones.Boton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dtgPreceptores;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}