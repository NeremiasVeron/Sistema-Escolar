using Front.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Front.FrmCursos
{
    public partial class FormAltaCursos : Form
    {
        Principal instanciaPrincipal = new Principal();
        public FormAltaCursos()

        {
            InitializeComponent();
        }
        private void FormAltaCursos_Load(object sender, EventArgs e)
        {
            cmbPreceptorCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            

            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Curso nuevoCurso = new Curso();

            nuevoCurso.año = txtAño.Text.Trim().ToLower();
            nuevoCurso.division = cmbDivision.SelectedItem.ToString();
            nuevoCurso.nombreCurso = txtNombre.Text.Trim();
            nuevoCurso.cantAlumnos = Convert.ToInt32(txtCantCupos.Text.Trim());
            nuevoCurso.descripcion = txtDescripcion.Text.Trim();

            //instanciaPrincipal.RellenarListas();
            instanciaPrincipal.AltaCurso(nuevoCurso);
            limpiarCampos();

            if (instanciaPrincipal.BuscarCursoPorAñoyDivision(nuevoCurso.año, nuevoCurso.division) == null) //validacion para saber si el alumno que di de alta se guardo.
            {
                FrmAlertaBox frm = new FrmAlertaBox("No se ha podido registrar el curso correctamente!", Color.FromArgb(220, 53, 63), 2);
                frm.ShowDialog();

            }
            else
            {
                FrmAlertaBox frm = new FrmAlertaBox("Curso registrado con éxito!", Color.FromArgb(40, 167, 69), 1);
                frm.ShowDialog();
                limpiarCampos();



                //nuevoCurso.preceptorCurso = cmbPreceptorCargo.SelectedItem;
                //cursoMateria cursoMateria = new cursoMateria();
                //cursoMateria.curso = nuevoCurso;
                //cursoMateria.idCurso = nuevoCurso.idCurso;
                //cursoMateria.idMateria = 
                //cursoMateria.idMateria = 
                //instanciaPrincipal.AltaCursoMateria(cursoMateria, nuevoCurso);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtAño.Text.Length > 0 || cmbDivision.Text.Length > 0 || txtNombre.Text.Length > 0 ||
             txtCantCupos.Text.Length > 0 || cmbPreceptorCargo.Text.Length > 0 || cmbMaterias.Text.Length > 0 || txtDescripcion.Text.Length > 0)
            {
                DialogResult inputUsuario = MessageBox.Show("¿Esta seguro que desea salir sin guardar?", "Salir sin guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (inputUsuario == DialogResult.OK) { this.Close(); }
            }
            else
            {
                this.Close();
            }
        }

        private void panelCursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtDescripcion);
        }

        private void txtDivision_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposVacios();

          
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtNombre);
            ValidarCamposVacios();
            
        }

        private void txtCantCupos_TextChanged(object sender, EventArgs e)
        {
            ValidarCamposVacios();
        }

        private void cmbPreceptorCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            InicializarMayusculas(txtAño);
            ValidarCamposVacios();


        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantCupos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarCamposVacios()
        {
            if (txtAño.Text.Length > 0 && cmbDivision.Text.Length > 0 && txtCantCupos.Text.Length > 0 && txtNombre.Text.Length > 0)
            { btnGuardar.Enabled = true; }
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
            txtAño.Clear();
            cmbDivision.Refresh();
            txtCantCupos.Clear();
            txtDescripcion.Clear();
            cmbPreceptorCargo.Refresh();
        }
        private void ValidarCurso()
        {
            if (instanciaPrincipal.BuscarCursoPorAñoyDivision(txtAño.Text, cmbDivision.Text) != null)
            {
                txtAño.Focus();
                cmbDivision.Focus();
                btnGuardar.Enabled = false;
                MessageBox.Show("Curso ya registrado, pruebe ingresando otra división u año.");
            }
            
            
        }
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
