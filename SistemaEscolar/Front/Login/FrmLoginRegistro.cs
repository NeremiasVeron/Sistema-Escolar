using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Login
{
    public partial class FrmLoginRegistro : Form
    {
        Principal instanciaPrincipal = new Principal();

        public FrmLoginRegistro()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIRegistrar_Click(object sender, EventArgs e)
        {
            AltaUser();
        }
        private void AltaUser()
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.usuario = txtUsuario.Text.Trim();
            nuevoUsuario.contraseña = txtContraseña.Text;
            nuevoUsuario.nombre = txtNombre.Text.Trim();
            nuevoUsuario.nroDocumento = Convert.ToInt32(txtDoc.Text.Trim());

            instanciaPrincipal.AltaUsuario(nuevoUsuario);

            if (instanciaPrincipal.BuscarUsuario(nuevoUsuario.usuario) == true)
            {
                MessageBox.Show("Registro con éxito!" , "Registrar usuario" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar el registro");
            }
            
        }
        private void DesabilitarBtnRegistrar()
        {
            if(txtNombre.Text == "" || txtDoc.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                btnIRegistrar.BackColor = Color.Transparent;
                btnIRegistrar.Enabled = false;  
            }
            else
            {
                btnIRegistrar.BackColor = Color.MediumSlateBlue;
                btnIRegistrar.Enabled = true;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnRegistrar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnRegistrar();

            if (instanciaPrincipal.BuscarUsuario(txtUsuario.Text.ToLower().Trim())) //Valido que el nombre de usuario que ingrese ya este usado. 
            {
                MessageBox.Show("El nombre de usuario ingresado ya existe!" , "Usuario existente" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
                txtNombre.Enabled = false;
                txtDoc.Enabled = false;
                txtContraseña.Enabled = false;
                
                txtUsuario.Focus();

                btnIRegistrar.BackColor = Color.Transparent;
                btnIRegistrar.Enabled = false;
                
            }
            else
            {
                txtNombre.Enabled = true;
                txtDoc.Enabled = true;
                txtContraseña.Enabled = true;

                txtUsuario.Focus();
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnRegistrar();
        }

        private void txtDoc_TextChanged(object sender, EventArgs e)
        {
            DesabilitarBtnRegistrar();
        }

        private void txtContraseña_TextChanged_1(object sender, EventArgs e)
        {
            DesabilitarBtnRegistrar();
        }

        private void FrmLoginRegistro_Load(object sender, EventArgs e)
        {
            btnIRegistrar.Enabled = false;
            btnIRegistrar.BackColor = Color.Transparent;
        }

        private void txtDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnIRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
