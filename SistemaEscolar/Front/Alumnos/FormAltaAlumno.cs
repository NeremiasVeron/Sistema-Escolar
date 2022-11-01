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
using Color = System.Drawing.Color;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Front.Forms
{

    public partial class FormAltaAlumno : Form
    {
        Principal Instanciaprincipal = new Principal();

        public FormAltaAlumno()
        {
            InitializeComponent();
        }
        private void FormAltaAlumno_Load(object sender, EventArgs e)
        {

            cmbTipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDivisiones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipodoc.Items.Add("DNI");
            cmbTipodoc.Items.Add("Pasaporte");
            cmbTipodoc.Items.Add("Libreta Enrolamiento");
            cmbTipodoc.Items.Add("Libreta Civica");
            cmbTipodoc.Items.Add("Libreta Verde");
            btnGuardar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumnoNuevo = new Alumno();
            
            alumnoNuevo.idCurso = Instanciaprincipal.BuscarCursoPorAñoyDivision(cmbCursos.Text, cmbDivisiones.Text.Trim()).idCurso;            
            alumnoNuevo.nombre = txtNombre.Text.Trim();
            alumnoNuevo.apellido = txtApellido.Text.Trim();
            alumnoNuevo.fechaNacimiento = dtmAlumno.Value;
            alumnoNuevo.numeroDoc = txtNroDoc.Text.Trim();
            alumnoNuevo.tipoDoc = cmbTipodoc.SelectedItem.ToString();
            alumnoNuevo.nroTelefono = txtTelefonoAlumno.Text.Trim();
            alumnoNuevo.email = txtEmail.Text.Trim();
            alumnoNuevo.localidad = txtLocalidadAlumno.Text.Trim();  //Podria ser un combo box
            alumnoNuevo.direccion = txtDireccion.Text.Trim();
            if (radiobtnF.Checked)
            {
                alumnoNuevo.sexo = radiobtnF.ToString();
            }
            else
            {
                alumnoNuevo.sexo = radiobtnM.ToString();
            }
            Instanciaprincipal.AltaAlumno(alumnoNuevo);
            if (Instanciaprincipal.buscarAlumnosPorMatricula(alumnoNuevo.matricula).Count == 1) //validacion para saber si el alumno que di de alta se guardo.
            {
                FrmAlertaBox frm = new FrmAlertaBox("Alumno registrado con éxito!", Color.FromArgb(40, 167, 69), 1);
                frm.ShowDialog();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar al alumno , intente cargarlo nuevamente !");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 || txtApellido.Text.Length > 0 || txtNroDoc.Text.Length > 0 ||
               txtTelefonoAlumno.Text.Length > 0 || txtEmail.Text.Length > 0 || txtLocalidadAlumno.Text.Length > 0 || txtDireccion.Text.Length > 0)
            {
                DialogResult inputUsuario = MessageBox.Show("¿Esta seguro que desea salir sin guardar?", "Salir sin guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (inputUsuario == DialogResult.OK) { this.Close(); }
            }
            else
            {
                this.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            InicializarMayusculas(txtNombre);

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            //validarCamposVacios();
            InicializarMayusculas(txtApellido);

        }

   
        private void txtLocalidadAlumno_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtLocalidadAlumno);
            //validarCamposVacios(); 
            validarCamposVacios();

        }

        private void txtDirección_TextChanged(object sender, EventArgs e)
        {

            InicializarMayusculas(txtDireccion);
            //validarCamposVacios();
            validarCamposVacios();
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            bool error = Instanciaprincipal.validarNumeroDoc(txtNroDoc.Text);
            if (error) 
            { 
                MessageBox.Show("Numero de documento ya existente!"); errorProvider2.SetError(txtNroDoc, "Numero de documento ya existente!"); 
            }
            else { errorProvider2.Clear(); }

            validarCamposVacios();

        }
        private void txtTelefonoAlumno_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

        }
        private void radiobtnF_CheckedChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

        }

        private void radiobtnM_CheckedChanged(object sender, EventArgs e)
        {
            validarCamposVacios();

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void radioBtnFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }       
        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipodoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTelefonoAlumno_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLocalidadAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dtmAlumno_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void cmbDivisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            //btnGuardar.Enabled = validarComboBox();
        }

        /////////////////////////////////////////////////////////////////// METODOS PROPIOS //////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // AGREGAR : VALIDAR NRO TELÉFONO - FECHA DE NACIMIENTO.  
        private void nuevoAlumno() { }

        private void ValidarFecha() { }
        
            //DateTime hoy = DateTime.Today;
            //if (dtmAlumno.Value >= hoy)
            //{
            //    MessageBox.Show("Fecha Inválida!", "ERROR");
            //    this.btnGuardar.Enabled = false;

            //}
            //if (dtmAlumno.Value < dtmAlumno.MinDate) { MessageBox.Show("Fecha Inválida!", "ERROR"); }
        
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroDoc.Clear();
            txtTelefonoAlumno.Clear();
            txtLocalidadAlumno.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            dtmAlumno.Refresh();
            cmbTipodoc.Refresh();
            cmbCursos.Refresh();
            cmbDivisiones.Refresh();
        }

        private void validarCamposVacios()
        {
            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtNroDoc.Text.Length > 0 && txtLocalidadAlumno.Text.Length > 0 && txtDireccion.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && txtTelefonoAlumno.Text.Length > 0 && cmbTipodoc.Text.Length > 0 && cmbCursos.Text.Length > 0 && cmbDivisiones.Text.Length > 0 &&
                radiobtnF.Checked.ToString().Length > 0 && radiobtnM.Checked.ToString().Length > 0) { btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; }
        }
        private void InicializarMayusculas(TextBox txtIngresado)
        {
            txtIngresado.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtIngresado.Text);
            txtIngresado.SelectionStart = txtIngresado.Text.Length;
        }
    }
}

       
   

