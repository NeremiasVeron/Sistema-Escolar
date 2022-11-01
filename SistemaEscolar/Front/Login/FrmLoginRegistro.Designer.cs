namespace Front.Login
{
    partial class FrmLoginRegistro
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevoAlumno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new Front.Botones.Boton();
            this.btnIRegistrar = new Front.Botones.Boton();
            this.panelLogin.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelLogin.Controls.Add(this.txtContraseña);
            this.panelLogin.Controls.Add(this.lblNuevoAlumno);
            this.panelLogin.Controls.Add(this.btnCancelar);
            this.panelLogin.Controls.Add(this.txtDoc);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.label21);
            this.panelLogin.Controls.Add(this.label25);
            this.panelLogin.Controls.Add(this.txtNombre);
            this.panelLogin.Controls.Add(this.btnIRegistrar);
            this.panelLogin.Controls.Add(this.panelShadow);
            this.panelLogin.Controls.Add(this.panelTitulo);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(800, 450);
            this.panelLogin.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(401, 305);
            this.txtContraseña.MaxLength = 15;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(192, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged_1);
            // 
            // lblNuevoAlumno
            // 
            this.lblNuevoAlumno.AutoSize = true;
            this.lblNuevoAlumno.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAlumno.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNuevoAlumno.Location = new System.Drawing.Point(121, 122);
            this.lblNuevoAlumno.Name = "lblNuevoAlumno";
            this.lblNuevoAlumno.Size = new System.Drawing.Size(250, 36);
            this.lblNuevoAlumno.TabIndex = 67;
            this.lblNuevoAlumno.Text = "Datos de usuario";
            this.lblNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(267, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nro Doc.:";
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.ForeColor = System.Drawing.Color.Black;
            this.txtDoc.Location = new System.Drawing.Point(401, 214);
            this.txtDoc.MaxLength = 9;
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(192, 25);
            this.txtDoc.TabIndex = 2;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            this.txtDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(149, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(153, 300);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(192, 25);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(397, 276);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 21);
            this.label21.TabIndex = 60;
            this.label21.Text = "Contraseña:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Gainsboro;
            this.label25.Location = new System.Drawing.Point(149, 190);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 21);
            this.label25.TabIndex = 59;
            this.label25.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(153, 214);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 25);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // panelShadow
            // 
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 93);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(800, 9);
            this.panelShadow.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 93);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(230, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema escolar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(129, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 176);
            this.panel1.TabIndex = 70;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(463, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIRegistrar
            // 
            this.btnIRegistrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIRegistrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIRegistrar.BorderColor = System.Drawing.Color.LavenderBlush;
            this.btnIRegistrar.BorderRadius = 40;
            this.btnIRegistrar.BorderSize = 0;
            this.btnIRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIRegistrar.FlatAppearance.BorderSize = 0;
            this.btnIRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnIRegistrar.Location = new System.Drawing.Point(129, 387);
            this.btnIRegistrar.Name = "btnIRegistrar";
            this.btnIRegistrar.Size = new System.Drawing.Size(155, 39);
            this.btnIRegistrar.TabIndex = 5;
            this.btnIRegistrar.Text = "Registrarme";
            this.btnIRegistrar.TextColor = System.Drawing.Color.Black;
            this.btnIRegistrar.UseVisualStyleBackColor = false;
            this.btnIRegistrar.Click += new System.EventHandler(this.btnIRegistrar_Click);
            this.btnIRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnIRegistrar_KeyPress);
            // 
            // FrmLoginRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoginRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginRegistro";
            this.Load += new System.EventHandler(this.FrmLoginRegistro_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private Botones.Boton btnIRegistrar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNombre;
        private Botones.Boton btnCancelar;
        private System.Windows.Forms.Label lblNuevoAlumno;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel1;
    }
}