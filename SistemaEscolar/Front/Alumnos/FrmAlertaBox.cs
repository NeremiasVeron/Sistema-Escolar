using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Forms
{
    public partial class FrmAlertaBox : Form
    {
        public FrmAlertaBox()
        {
            InitializeComponent();
        }

        public FrmAlertaBox(string pMensaje , Color pColor , int tipo)
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;
            lblMensaje.ForeColor = pColor;
            pTop.BackColor = pColor;

            if (tipo == 1)
            {
                picError.Visible = false;
                lblMensaje.ForeColor = Color.White;
                BackColor = Color.DarkGreen;
            }
            else { picAlertBox.Visible = false;lblMensaje.ForeColor = Color.White ; BackColor = Color.DarkRed; }
        }
        //EVENTO DEL TIMER
        private int conteo;
        private void timerAnimado_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo == 50)
                this.Close();
        }
        //EVENTO LOAD
        private void FrmAlertaBox_Load(object sender, EventArgs e)
        {
            timerAnimado.Start();
            //PositionAlertBox();
            //for (int i = 0; i < 500; i++)
            //{
               
            //}
        }
        private void FrmAlertaBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerAnimado.Enabled = false;
        }

        //public Color BackColorAlertBox { get { return this.BackColor; } set { this.BackColor = value; } }
        //public Color ColorAlertBox { get { return LinAlertBox.BackColor; } set { LinAlertBox.BackColor = lblTextAlertBox.ForeColor = lblTextAlertBox.ForeColor = value; } }
        //public Image IconoAlertBox
        //{
        //    get { return picAlertBox.Image; }
        //    set { picAlertBox.Image = value; }
        //}
        //public string TituloIconoAlertBox
        //{
        //    get { return lblTituloAlertBox.Text; }
        //    set { lblTituloAlertBox.Text = value; }
        //}

        //public string TextoIconoAlertBox
        //{
        //    //get { return lblTextAlertBox.Text; }
        //    //set { lblTextAlertBox.Text = value; }
        //}

        //private void PositionAlertBox()
        //{
        //    int xPos = 0; int yPos = 0;
        //    xPos = Screen.GetWorkingArea(this).Width;
        //    yPos = Screen.GetWorkingArea(this).Height;
        //    this.Location = new Point(xPos - this.Width, yPos - this.Height);
        //}





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
