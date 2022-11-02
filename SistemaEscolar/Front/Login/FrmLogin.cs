using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Front.Login
{
    public partial class FrmLogin : Form
    {
        Principal instanciaPrincipal = new Principal();
        bool cambios = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnIngresar();
            ValidoCampos(txtUsuario);
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnIngresar();
            ValidoCampos(txtContraseña);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(instanciaPrincipal.BuscarUsuarioContraseña(txtUsuario.Text.Trim().ToLower(), txtContraseña.Text))
            {
                MessageBox.Show("BIENVENIDO " + txtUsuario.Text.Trim() + "!" ,"Ingreso al sistema " ,  MessageBoxButtons.OK , MessageBoxIcon.Information);
                MenuPrincipal frm = new MenuPrincipal();
                foreach(var indice in instanciaPrincipal.GetListaUsuarios())
                {
                    if(indice.usuario == txtUsuario.Text)
                    {
                        frm.lblUsuario.Text = indice.nombre;
                        this.Hide();
                        frm.ShowDialog();
                        break;
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegistrarme_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new FrmLoginRegistro();
            frmRegistro.ShowDialog();
            //this.Hide();
            
        }
        
        private void DesabilitarBtnIngresar()
        {
            if (txtUsuario.Text.Length == 0 && txtContraseña.Text.Length == 0)
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text.Length != 0 && txtContraseña.Text.Length == 0)
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text.Length == 0 && txtContraseña.Text.Length != 0)
            {
                btnIngresar.Visible = false;
            }
            else
            {
                btnIngresar.Visible = true;
            }

        }
        private void ValidoCampos(TextBox txtaValidar)
        {
            if (txtaValidar.Text.Trim() != "")
            {
                cambios = true;
            }
            else
            {
                cambios = false;
            }
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios) //si detecta cambios tira un box. 
            {
                DialogResult res = MessageBox.Show("Es probable que haya habido cambios. ¿Desea cerrar el programa sin guardar?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Cancel )
                {
                    e.Cancel = true;
                }

            }
        }
    }
}
