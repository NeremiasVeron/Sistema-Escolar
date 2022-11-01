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
    public partial class FormAltaPreceptor : Form
    {
        Principal instanciaPrincipal = new Principal();
        public FormAltaPreceptor()
        {
            InitializeComponent();
        }
        private void FormAltaPreceptor_Load(object sender, EventArgs e)
        {
            cmbTipodoc.DropDownStyle = ComboBoxStyle.DropDownList;
            btnGuardar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Preceptor preceptor = new Preceptor();

            //preceptor.idCurso = Instanciaprincipal.BuscarCursoPorAñoyDivision(cmbCursos.Text, cmbDivisiones.Text.Trim()).idCurso;
            preceptor.nombre = txtNombre.Text.Trim();
            preceptor.apellido = txtApellido.Text.Trim();
            preceptor.fechaNacimiento = dtmPreceptor.Value;
            preceptor.numeroDoc = txtNroDoc.Text.Trim();
            preceptor.tipoDoc = cmbTipodoc.SelectedItem.ToString();
            preceptor.nroTelefono = txtTelefonoAlumno.Text.Trim();
            preceptor.email = txtEmail.Text.Trim();
            preceptor.localidad = txtLocalidadAlumno.Text.Trim();  //Podria ser un combo box
            preceptor.direccion = txtDireccion.Text.Trim();
            preceptor.fechaInicio = dtmFechaInicio.Value;
            if (radiobtnF.Checked)
            {
                preceptor.sexo = radiobtnF.Text.Trim();
            }
            else
            {
                preceptor.sexo = radiobtnM.Text.Trim();
            }
            instanciaPrincipal.AltaPreceptor(preceptor);
            if (instanciaPrincipal.BuscarListaPreceptorPorId(preceptor.idPreceptor).Count == 1) //validacion para saber si el alumno que di de alta se guardo.
            {
                FrmAlertaBox frm = new FrmAlertaBox("Preceptor registrado con éxito!", Color.FromArgb(40, 167, 69), 1);
                frm.ShowDialog();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar el preceptor , intente cargarlo nuevamente !");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 || txtApellido.Text.Length > 0 || txtNroDoc.Text.Length > 0 ||
               txtTelefonoAlumno.Text.Length > 0 || txtEmail.Text.Length > 0 || txtLocalidadAlumno.Text.Length > 0 || txtDireccion.Text.Length > 0 || cmbTipodoc.Text.Length > 0
               || radiobtnF.Checked.ToString().Length > 0 || radiobtnM.Checked.ToString().Length > 0)
            {
                DialogResult inputUsuario = MessageBox.Show("¿Esta seguro que desea salir sin guardar?", "Salir sin guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (inputUsuario == DialogResult.OK) { this.Close(); }
            }
            else
            {
                this.Close();
            }
        }
        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtDireccion);
            validarCamposVacios();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtApellido);
            validarCamposVacios();
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            bool error = instanciaPrincipal.validarNumeroDoc(txtNroDoc.Text);
            if (error)
            {
                MessageBox.Show("Numero de documento ya existente!"); errorProvider1.SetError(txtNroDoc, "Numero de documento ya existente!");
            }
            else { errorProvider1.Clear(); }
            validarCamposVacios();
        }

        private void txtTelefonoAlumno_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void txtLocalidadAlumno_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtLocalidadAlumno);
            validarCamposVacios();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtNombre);
            validarCamposVacios();
        }

        private void radiobtnM_CheckedChanged(object sender, EventArgs e)
        {
            validarCamposVacios();
        }

        private void radiobtnF_CheckedChanged(object sender, EventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }
        private void validarCamposVacios()
        {
            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0 && txtNroDoc.Text.Length > 0 && txtLocalidadAlumno.Text.Length > 0 && txtDireccion.Text.Length > 0 &&
                txtEmail.Text.Length > 0 && txtTelefonoAlumno.Text.Length > 0 && cmbTipodoc.Text.Length > 0 && cmbTipodoc.Text.Length > 0 &&
                radiobtnF.Checked.ToString().Length > 0 && radiobtnM.Checked.ToString().Length > 0) { btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; }
        }
        private void InicializarMayusculas(TextBox txtIngresado)
        {
            txtIngresado.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtIngresado.Text);
            txtIngresado.SelectionStart = txtIngresado.Text.Length;
        }
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNroDoc.Clear();
            txtTelefonoAlumno.Clear();
            txtLocalidadAlumno.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            dtmPreceptor.Refresh();
            cmbTipodoc.Refresh();
        }

    }
}
