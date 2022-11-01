namespace Front.Forms
{
    partial class FrmAlertaBox
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
            this.LinAlertBox = new System.Windows.Forms.Panel();
            this.timerAnimado = new System.Windows.Forms.Timer(this.components);
            this.picAlertBox = new System.Windows.Forms.PictureBox();
            this.picError = new System.Windows.Forms.PictureBox();
            this.pTop = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // LinAlertBox
            // 
            this.LinAlertBox.BackColor = System.Drawing.Color.Black;
            this.LinAlertBox.Location = new System.Drawing.Point(0, 95);
            this.LinAlertBox.Name = "LinAlertBox";
            this.LinAlertBox.Size = new System.Drawing.Size(5, 6);
            this.LinAlertBox.TabIndex = 3;
            // 
            // timerAnimado
            // 
            this.timerAnimado.Interval = 5;
            this.timerAnimado.Tick += new System.EventHandler(this.timerAnimado_Tick);
            // 
            // picAlertBox
            // 
            this.picAlertBox.Image = global::Front.Properties.Resources.Check;
            this.picAlertBox.Location = new System.Drawing.Point(12, 16);
            this.picAlertBox.Name = "picAlertBox";
            this.picAlertBox.Size = new System.Drawing.Size(60, 60);
            this.picAlertBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlertBox.TabIndex = 0;
            this.picAlertBox.TabStop = false;
            // 
            // picError
            // 
            this.picError.Image = global::Front.Properties.Resources.error;
            this.picError.Location = new System.Drawing.Point(12, 16);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(60, 60);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 4;
            this.picError.TabStop = false;
            this.picError.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pTop
            // 
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(500, 10);
            this.pTop.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Gray;
            this.lblMensaje.Location = new System.Drawing.Point(93, 33);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(74, 24);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // FrmAlertaBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.picError);
            this.Controls.Add(this.LinAlertBox);
            this.Controls.Add(this.picAlertBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlertaBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlertaBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlertaBox_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlertaBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlertBox;
        private System.Windows.Forms.Panel LinAlertBox;
        private System.Windows.Forms.Timer timerAnimado;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Label lblMensaje;
    }
}