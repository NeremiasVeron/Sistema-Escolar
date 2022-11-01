using Front.Forms;
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

namespace Front.Preceptores
{
    public partial class FormModificarPreceptor : Form
    {
        Principal instanciaPrincipal = new Principal();
        //string validadorCurso;
        //string validadorDivision;
        
        string val_Nombre;
        string val_Apellido;
        string val_NroDoc;
        string val_Tipodoc;
        string val_FechaNac;
        string val_Telefono;
        string val_Correo;
        string val_Localidad;
        string val_Direccion;
        public FormModificarPreceptor()
        {
            InitializeComponent();
        }

        private void FormModificarPreceptor_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbDivisiones.DropDownStyle = ComboBoxStyle.DropDownList;

            //cmbCursos.Enabled = false; //en desarrollo
            //cmbDivisiones.Enabled = false;//en desarrollo
            //dtmFechaInicio.Enabled = false;//en desarrollo

            //validadorCurso = cmbCursos.Text;
            //validadorDivision = cmbDivisiones.Text;
            val_Nombre = txtNombre.Text.Trim();
            val_Apellido = txtApellido.Text.Trim();
            val_NroDoc = txtNroDoc.Text.Trim();
            val_Tipodoc = cmbTipoDoc.Text;
            val_FechaNac = dtmPreceptor.Text;
            val_Telefono =  txtTelefono.Text.Trim();
            val_Correo =  txtEmail.Text.Trim();
            val_Localidad = txtLocalidad.Text.Trim();
            val_Direccion = txtDireccion.Text.Trim();

            ValidarCamposEditados();
            btnGuardar.Enabled = false;

        }
        private void ValidarCamposEditados()
        {
            if (val_Nombre != txtNombre.Text) { errorProvider1.SetError(txtNombre, "Campo editado"); }
            else { errorProvider1.Clear(); }
            if (val_Apellido != txtApellido.Text) { errorProvider2.SetError(txtApellido, "Campo editado"); }
            else { errorProvider2.Clear(); }
            if (val_NroDoc != txtNroDoc.Text) { errorProvider3.SetError(txtNroDoc, "Campo editado"); }
            else { errorProvider3.Clear(); }
            if (val_Tipodoc != cmbTipoDoc.Text) { errorProvider4.SetError(cmbTipoDoc, "Campo editado"); }
            else { errorProvider4.Clear(); }
            if (val_Telefono != txtTelefono.Text) { errorProvider5.SetError(txtTelefono, "Campo editado"); }
            else { errorProvider5.Clear(); }
            if (val_Correo != txtEmail.Text) { errorProvider6.SetError(txtEmail, "Campo editado"); }
            else { errorProvider6.Clear(); }
            if (val_Localidad != txtLocalidad.Text) { errorProvider7.SetError(txtLocalidad, "Campo editado"); }
            else { errorProvider7.Clear(); }
            if (val_Direccion != txtDireccion.Text) { errorProvider8.SetError(txtDireccion, "Campo editado"); }
            else { errorProvider8.Clear(); }
            //if (validadorCurso != cmbCursos.Text) { errorProvider9.SetError(cmbCursos, "Campo editado"); }
            //else { errorProvider9.Clear(); }
            //if (validadorDivision != cmbDivisiones.Text) { errorProvider10.SetError(cmbDivisiones, "Campo editado"); }
            //else { errorProvider10.Clear(); }
            if (val_FechaNac != dtmPreceptor.Text.ToString()) { errorProvider13.SetError(dtmPreceptor, "Campo editado"); }
            else { errorProvider13.Clear(); }

        }
        private void validarCamposVacios()
        {
            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtNroDoc.Text.Length > 0 && txtLocalidad.Text.Length > 0 && txtDireccion.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && txtTelefono.Text.Length > 0 && cmbTipoDoc.Text.Length > 0 ) //&& cmbCursos.Text.Length > 0 && cmbDivisiones.Text.Length > 0
            { btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Preceptor preceptorModificado = new Preceptor();

            int idPreceptor = Convert.ToInt32(txtMatricula.Text);
            preceptorModificado.nombre = txtNombre.Text.Trim();
            preceptorModificado.apellido = txtApellido.Text.Trim();
            preceptorModificado.tipoDoc = cmbTipoDoc.Text.Trim();
            preceptorModificado.numeroDoc = txtNroDoc.Text.Trim();
            preceptorModificado.fechaNacimiento = dtmPreceptor.Value;
            preceptorModificado.nroTelefono = txtTelefono.Text.Trim();
            preceptorModificado.email = txtEmail.Text.Trim();
            preceptorModificado.localidad = txtLocalidad.Text.Trim();
            preceptorModificado.direccion = txtDireccion.Text.Trim();
            preceptorModificado.fechaInicio = dtmFechaInicio.Value;
            if (radiobtnF.Checked) { preceptorModificado.sexo = radiobtnF.Text; }
            else { preceptorModificado.sexo = radiobtnM.Text; }

            instanciaPrincipal.ModificarPreceptor(preceptorModificado,idPreceptor);
            FrmAlertaBox frm = new FrmAlertaBox("Preceptor modificado con éxito!", Color.FromArgb(40, 167, 69), 1);
            frm.ShowDialog();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbDivisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false;
            txtMatricula.BackColor = Color.DarkRed;
        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void dtmPreceptor_ValueChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditados();
            validarCamposVacios();
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
    }
}
