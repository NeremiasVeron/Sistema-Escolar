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

namespace Front.Forms
{
    public partial class FormModificarAlumno : Form
    {
        Principal instanciaPrincipal = new Principal();

        string validadorCurso;
        string validadorDivision;
        string val_Nombre;
        string val_Apellido;
        string val_NroDoc;
        string val_Tipodoc;
        string val_Telefono;
        string val_Correo;
        string val_Fecha;
        string val_Localidad;
        string val_Direccion;
        string val_MatDesa;
        string val_MatApro;
        string val_Sexo;
        public FormModificarAlumno()
        {
            InitializeComponent();
        }

        private void FormModificarAlumno_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDivisioness.DropDownStyle = ComboBoxStyle.DropDownList;

            //guardo los datos del alumno para validar
            validadorCurso = cmbCursos.Text.ToString();
            validadorDivision = cmbDivisioness.Text.ToString();
            val_Nombre = txtNombre.Text;
            val_Apellido = txtApellido.Text;
            val_Correo = txtEmail.Text;
            val_NroDoc = txtNroDoc.Text;
            val_Tipodoc = cmbTipoDoc.Text.ToString();
            val_Telefono = txtTelefonoAlumno.Text;
            val_Localidad = txtLocalidadAlumno.Text;
            val_Direccion = txtDireccion.Text;
            val_MatDesa = txtMatDesaprobadas.Text;
            val_MatApro = txtMatAprobadas.Text;
            val_Fecha = dtmAlumno.Text;
            if (radiobtnF.Checked) { val_Sexo = radiobtnF.Text; } else { val_Sexo = radiobtnM.Text; }

            ValidarCamposEditado();
            btnGuardar.Enabled = false;

        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumnoModificado = new Alumno();

            if (validadorCurso != cmbCursos.Text || validadorDivision != cmbDivisioness.Text)  // Valido si el usuario modificó los cursos del alumno.Si modificó alguno, busco y me traigo el id del nuevo curso asignado.
            {
                int idCursoNuevo = instanciaPrincipal.BuscarCursoPorAñoyDivision(cmbCursos.Text, cmbDivisioness.Text.Trim()).idCurso;
                nuevoAlumnoModificado.idCurso = idCursoNuevo;
            }
            else
            {
                nuevoAlumnoModificado.idCurso = Convert.ToInt32(txtIdCurso.Text);
            }
            
            nuevoAlumnoModificado.matricula = Convert.ToInt32(txtMatricula.Text);
            nuevoAlumnoModificado.nombre = txtNombre.Text.Trim();
            nuevoAlumnoModificado.apellido = txtApellido.Text.Trim();
            nuevoAlumnoModificado.numeroDoc = txtNroDoc.Text.Trim();
            nuevoAlumnoModificado.tipoDoc = cmbTipoDoc.Text.ToString();
            nuevoAlumnoModificado.fechaNacimiento = dtmAlumno.Value;
            nuevoAlumnoModificado.nroTelefono = txtTelefonoAlumno.Text.Trim();
            nuevoAlumnoModificado.email = txtEmail.Text.Trim();
            nuevoAlumnoModificado.localidad = txtLocalidadAlumno.Text.Trim();
            nuevoAlumnoModificado.direccion = txtDireccion.Text.Trim();
            nuevoAlumnoModificado.matAprobadas = txtMatAprobadas.Text.Trim();
            nuevoAlumnoModificado.matDesaprobadas = txtMatDesaprobadas.Text.Trim();
            if (radiobtnF.Checked) { nuevoAlumnoModificado.sexo = radiobtnF.Text; } else { nuevoAlumnoModificado.sexo = radiobtnM.Text; }

            int idAlumno = Convert.ToInt32(txtMatricula.Text);
            instanciaPrincipal.ModificarAlumno(nuevoAlumnoModificado, idAlumno);

            FrmAlertaBox frm = new FrmAlertaBox("Alumno modificado con éxito!", Color.FromArgb(40, 167, 69), 1); //HACER validacion para ver si realmmente se mdofico con exito. 
            frm.ShowDialog();
            this.Close();
        }
        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelModificarAlumno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditado();

            validarCamposVacios();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidadAlumno_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMatDesaprobadas_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false;
            txtMatricula.BackColor = Color.DarkRed;
        }

        private void cmbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();

        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposEditado();
            validarCamposVacios();
            //bool error = instanciaPrincipal.validarNumeroDoc(txtNroDoc.Text);  //me devuelve un true si encuentra el nro de doc. 
            //if (error)
            //{
            //    MessageBox.Show("Numero de documento ya existente!"); 
            //    errorProvider1.SetError(txtNroDoc, "Numero de documento ya existente!");
            //}
            //else { errorProvider1.Clear(); }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void txtIdCurso_TextChanged(object sender, EventArgs e)
        {
            txtIdCurso.Enabled = false;
            txtIdCurso.BackColor = Color.DarkRed;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void txtTelefonoAlumno_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void txtMatAprobadas_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }

        private void cmbDivisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
            ValidarCamposEditado();
        }
        private void ValidarCamposEditado()
        {
            if (val_Nombre != txtNombre.Text) { errorProviderNombre.SetError(txtNombre, "Campo editado"); }
            else { errorProviderNombre.Clear(); }
            if (val_Apellido != txtApellido.Text) { errorProviderApellido.SetError(txtApellido, "Campo editado"); }
            else { errorProviderApellido.Clear(); }
            if (val_NroDoc != txtNroDoc.Text) { errorProviderNroDoc.SetError(txtNroDoc, "Campo editado"); }
            else { errorProviderNroDoc.Clear(); }
            if (val_Tipodoc != cmbTipoDoc.Text) { errorProviderTipoDoc.SetError(cmbTipoDoc, "Campo editado"); }
            else { errorProviderTipoDoc.Clear(); }
            if (val_Telefono != txtTelefonoAlumno.Text) { errorProviderTel.SetError(txtTelefonoAlumno, "Campo editado"); }
            else { errorProviderTel.Clear(); }
            if (val_Correo != txtEmail.Text) { errorProviderCorreo.SetError(txtEmail, "Campo editado"); }
            else { errorProviderCorreo.Clear(); }
            if (val_Localidad != txtLocalidadAlumno.Text) { errorProviderLoc.SetError(txtLocalidadAlumno, "Campo editado"); }
            else { errorProviderLoc.Clear(); }
            if (val_Direccion != txtDireccion.Text) { errorProviderDire.SetError(txtDireccion, "Campo editado"); }
            else { errorProviderDire.Clear(); }
            if (validadorCurso != cmbCursos.Text) { errorProviderCurso.SetError(cmbCursos, "Campo editado"); }
            else { errorProviderCurso.Clear(); }
            if (validadorDivision != cmbDivisioness.Text) { errorProviderDiv.SetError(cmbDivisioness, "Campo editado"); }
            else { errorProviderDiv.Clear(); }
            if (val_MatApro != txtMatAprobadas.Text) { errorProviderMat.SetError(txtMatAprobadas, "Campo editado"); }
            else { errorProviderMat.Clear(); }
            if (val_MatDesa != txtMatDesaprobadas.Text) { errorProviderMatDesa.SetError(txtMatDesaprobadas, "Campo editado"); }
            else { errorProviderMatDesa.Clear(); }
            if (val_Fecha != dtmAlumno.Text) { errorProviderFecha.SetError(dtmAlumno, "Campo editado"); }
            else { errorProviderFecha.Clear(); }

        }
        private void validarCamposVacios()
        {
            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtNroDoc.Text.Length > 0 && txtLocalidadAlumno.Text.Length > 0 && txtDireccion.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && txtTelefonoAlumno.Text.Length > 0 && cmbTipoDoc.Text.Length > 0 && cmbCursos.Text.Length > 0 && cmbDivisioness.Text.Length > 0
                && txtMatAprobadas.Text.Length > 0 && txtMatDesaprobadas.Text.Length > 0 && dtmAlumno.Text.Length > 0 && radiobtnF.Checked == true || radiobtnM.Checked == true )
            { btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; }
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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
            validarCamposVacios();
            ValidarCamposEditado();
            ValidarFecha();


        }
        private bool ValidarFecha()
        {
            DateTime fechaActual = DateTime.Today;
            int edad;


            if (dtmAlumno.Value == fechaActual)
            {
                MessageBox.Show("Fecha Inválida");
            }

            edad = fechaActual.Year - dtmAlumno.Value.Year;
            if (dtmAlumno.Value.Month > fechaActual.Month) { --edad; }

            if (edad < 12 || edad > 20) { MessageBox.Show("El límite de edad es a partir de 12 años hasta los 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); btnGuardar.Enabled = false; return false; }
            else { btnGuardar.Enabled = true; return true; }
        }

        private void radiobtnF_CheckedChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void radiobtnM_CheckedChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }
    }
}
