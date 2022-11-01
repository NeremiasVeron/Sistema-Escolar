using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Front.FrmCursos;
using Front.FrmMateria;
using Front.Preceptores;
using Front.Profesores;
using Color = System.Drawing.Color;

namespace Front
{
    public partial class MenuPrincipal : Form
    {
        //Propiedades
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public MenuPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        //Struct de colores. 
        private struct RGBColors
        {
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void ActivateButton(object senderBtn, Color color) //Metodo para activar el boton
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Botón
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Lado izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                
            }
        }

        //Metodo para desabilitar el resaltado de los botones. 
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();   
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;  
            childForm.BringToFront();
            childForm.Show();
            lblTituloChildForm.Text = childForm.Text;
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAlumnos()); //Abrir form hijo
            ActivateButton(sender, RGBColors.color2); 
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormProfesores());
        }

        private void BtnPreceptores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPreceptor());
            ActivateButton(sender, RGBColors.color2);

        }

        private void BtnExamenes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmMaterias()); 
        }

        private void BtnCursos_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormCursos());

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

       
   
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = true;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTituloChildForm.Text = "Home";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShadow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTituloChildForm_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            //lblFecha.Text = DateTime.Now.ToString("dddd:MMMM:yyy");
        }
    }
}
