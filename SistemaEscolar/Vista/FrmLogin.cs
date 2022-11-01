using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnIngresar.Visible = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //int maximaCantidadCaracteres = 30;

            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text == "" && txtContraseña.Text != "")
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text != "" && txtContraseña.Text == "")
            {
                btnIngresar.Visible = false;
            }
            else { btnIngresar.Visible = true; }


        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text == "" && txtContraseña.Text != "")
            {
                btnIngresar.Visible = false;
            }
            else if (txtUsuario.Text != "" && txtContraseña.Text == "")
            {
                btnIngresar.Visible = false;
            }
            else { btnIngresar.Visible = true; }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {
                if (validarUsuario(txtUsuario.Text, txtContraseña.Text) == true)
                {
                    MessageBox.Show("BIEVENIDO " + txtUsuario.Text + "!");
                }
                else { MessageBox.Show("Usuario y/o contraseña incorrectos!"); }
            }
            else { MessageBox.Show("Ingrese U y C"); }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool validarUsuario(string usuario, string clave)
        {
            Principal principal = new Principal();

            Alumno alumno = new Alumno();

            alumno.nombre = "Neremias";
            alumno.apellido = "Veron";
            alumno.nacionalidad = "Argentina";
            alumno.dni = "44251723";
            alumno.tipoDni = "Documento";
            alumno.email = "neremiasveron@gmail.com";
            alumno.sexo = "hombre";
            alumno.direccion = "alvear 828";
            alumno.fechaNacimiento = new DateTime(2002, 09, 05);
            //principal.AltaAlumno(alumno, "neremias", "12345");
            return principal.buscarUsuario(usuario, clave);



            //List<string> listaUsuContra = new List<string>();
            //listaUsuContra = principal.buscarUsuario(usuario, clave);
            //string usuarioEncontrado = listaUsuContra[0];
            //string contraseñaEncontrada = listaUsuContra[1];
            //return (usuario == usuarioEncontrado) && (contraseñaEncontrada == clave);

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void PantallaLogin_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            //instanciaPersistencia.InicializarArchivos();
            Principal instanciaPrincipal = new Principal();
            //instanciaPrincipal.RellenarListas(); 
        }
    }
}
