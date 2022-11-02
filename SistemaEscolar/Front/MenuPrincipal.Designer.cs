using System.Drawing;

namespace Front
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnCursos = new FontAwesome.Sharp.IconButton();
            this.BtnMaterias = new FontAwesome.Sharp.IconButton();
            this.BtnExamenes = new FontAwesome.Sharp.IconButton();
            this.BtnPreceptores = new FontAwesome.Sharp.IconButton();
            this.BtnProfesores = new FontAwesome.Sharp.IconButton();
            this.BtnAlumnos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfesores = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.BtnReportes);
            this.panelMenu.Controls.Add(this.BtnCursos);
            this.panelMenu.Controls.Add(this.BtnMaterias);
            this.panelMenu.Controls.Add(this.BtnExamenes);
            this.panelMenu.Controls.Add(this.BtnPreceptores);
            this.panelMenu.Controls.Add(this.BtnProfesores);
            this.panelMenu.Controls.Add(this.BtnAlumnos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 657);
            this.panelMenu.TabIndex = 2;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.BtnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReportes.IconSize = 32;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 502);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnReportes.Size = new System.Drawing.Size(220, 60);
            this.BtnReportes.TabIndex = 9;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnCursos
            // 
            this.BtnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCursos.FlatAppearance.BorderSize = 0;
            this.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCursos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCursos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCursos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCursos.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCursos.IconSize = 32;
            this.BtnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.Location = new System.Drawing.Point(0, 442);
            this.BtnCursos.Name = "BtnCursos";
            this.BtnCursos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCursos.Size = new System.Drawing.Size(220, 60);
            this.BtnCursos.TabIndex = 8;
            this.BtnCursos.Text = "Cursos";
            this.BtnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCursos.UseVisualStyleBackColor = true;
            this.BtnCursos.Click += new System.EventHandler(this.BtnCursos_Click);
            // 
            // BtnMaterias
            // 
            this.BtnMaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMaterias.FlatAppearance.BorderSize = 0;
            this.BtnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaterias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaterias.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnMaterias.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BtnMaterias.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnMaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaterias.IconSize = 32;
            this.BtnMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMaterias.Location = new System.Drawing.Point(0, 382);
            this.BtnMaterias.Name = "BtnMaterias";
            this.BtnMaterias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnMaterias.Size = new System.Drawing.Size(220, 60);
            this.BtnMaterias.TabIndex = 7;
            this.BtnMaterias.Text = "Materias";
            this.BtnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMaterias.UseVisualStyleBackColor = true;
            this.BtnMaterias.Click += new System.EventHandler(this.BtnMaterias_Click);
            // 
            // BtnExamenes
            // 
            this.BtnExamenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnExamenes.FlatAppearance.BorderSize = 0;
            this.BtnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExamenes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExamenes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnExamenes.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.BtnExamenes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnExamenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExamenes.IconSize = 32;
            this.BtnExamenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExamenes.Location = new System.Drawing.Point(0, 322);
            this.BtnExamenes.Name = "BtnExamenes";
            this.BtnExamenes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnExamenes.Size = new System.Drawing.Size(220, 60);
            this.BtnExamenes.TabIndex = 6;
            this.BtnExamenes.Text = "Exámenes";
            this.BtnExamenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExamenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExamenes.UseVisualStyleBackColor = true;
            this.BtnExamenes.Click += new System.EventHandler(this.BtnExamenes_Click);
            // 
            // BtnPreceptores
            // 
            this.BtnPreceptores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPreceptores.FlatAppearance.BorderSize = 0;
            this.BtnPreceptores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreceptores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreceptores.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnPreceptores.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnPreceptores.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnPreceptores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPreceptores.IconSize = 32;
            this.BtnPreceptores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPreceptores.Location = new System.Drawing.Point(0, 262);
            this.BtnPreceptores.Name = "BtnPreceptores";
            this.BtnPreceptores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnPreceptores.Size = new System.Drawing.Size(220, 60);
            this.BtnPreceptores.TabIndex = 5;
            this.BtnPreceptores.Text = "Preceptores";
            this.BtnPreceptores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPreceptores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPreceptores.UseVisualStyleBackColor = true;
            this.BtnPreceptores.Click += new System.EventHandler(this.BtnPreceptores_Click);
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProfesores.FlatAppearance.BorderSize = 0;
            this.BtnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfesores.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProfesores.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.BtnProfesores.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnProfesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProfesores.IconSize = 32;
            this.BtnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfesores.Location = new System.Drawing.Point(0, 202);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProfesores.Size = new System.Drawing.Size(220, 60);
            this.BtnProfesores.TabIndex = 4;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProfesores.UseVisualStyleBackColor = true;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlumnos.FlatAppearance.BorderSize = 0;
            this.BtnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlumnos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumnos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAlumnos.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.BtnAlumnos.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlumnos.IconSize = 32;
            this.BtnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumnos.Location = new System.Drawing.Point(0, 140);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAlumnos.Size = new System.Drawing.Size(220, 62);
            this.BtnAlumnos.TabIndex = 3;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Front.Properties.Resources.Logo_para_Practica___F__1__removebg_preview;
            this.btnHome.Location = new System.Drawing.Point(-49, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(302, 162);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.lblProfesores);
            this.panelDesktop.Controls.Add(this.lblAlumnos);
            this.panelDesktop.Controls.Add(this.panelShadow);
            this.panelDesktop.Controls.Add(this.panelTitulo);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(934, 657);
            this.panelDesktop.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cursos registrados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Materias registradas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Preceptores registrados:";
            // 
            // lblProfesores
            // 
            this.lblProfesores.AutoSize = true;
            this.lblProfesores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesores.ForeColor = System.Drawing.Color.White;
            this.lblProfesores.Location = new System.Drawing.Point(64, 248);
            this.lblProfesores.Name = "lblProfesores";
            this.lblProfesores.Size = new System.Drawing.Size(237, 25);
            this.lblProfesores.TabIndex = 19;
            this.lblProfesores.Text = "Profesores registrados:";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.ForeColor = System.Drawing.Color.White;
            this.lblAlumnos.Location = new System.Drawing.Point(63, 177);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(224, 25);
            this.lblAlumnos.TabIndex = 18;
            this.lblAlumnos.Text = "Alumnos registrados:";
            // 
            // panelShadow
            // 
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(934, 9);
            this.panelShadow.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panelTitulo.Controls.Add(this.lblTituloChildForm);
            this.panelTitulo.Controls.Add(this.iconCurrentChildForm);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(934, 75);
            this.panelTitulo.TabIndex = 0;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblTituloChildForm
            // 
            this.lblTituloChildForm.AutoSize = true;
            this.lblTituloChildForm.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTituloChildForm.Location = new System.Drawing.Point(63, 30);
            this.lblTituloChildForm.Name = "lblTituloChildForm";
            this.lblTituloChildForm.Size = new System.Drawing.Size(101, 36);
            this.lblTituloChildForm.TabIndex = 1;
            this.lblTituloChildForm.Text = "Home";
            this.lblTituloChildForm.Click += new System.EventHandler(this.lblTituloChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 34);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 75);
            this.panel1.TabIndex = 25;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHora.Location = new System.Drawing.Point(886, 27);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 22);
            this.lblHora.TabIndex = 27;
            this.lblHora.Text = "Usuario:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFecha.Location = new System.Drawing.Point(424, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 22);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsuario.Location = new System.Drawing.Point(114, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(820, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(22, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(93, 25);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Usuario:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(54, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 373);
            this.panel2.TabIndex = 26;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1154, 657);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Sistema escolar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnAlumnos;
        private FontAwesome.Sharp.IconButton BtnMaterias;
        private FontAwesome.Sharp.IconButton BtnExamenes;
        private FontAwesome.Sharp.IconButton BtnPreceptores;
        private FontAwesome.Sharp.IconButton BtnProfesores;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnCursos;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProfesores;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer horaFecha;
    }
}

