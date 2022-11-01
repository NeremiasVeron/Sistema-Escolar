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

namespace Front.FrmCursos
{
    public partial class FormModificarCurso : Form
    {
        Principal instanciaPrincipal = new Principal();
        public FormModificarCurso()
        {
            InitializeComponent();
        }

        private void FormModificarCurso_Load(object sender, EventArgs e)
        {
            cmbPreceptorCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDivision.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void btnGuardar_Click_1(object sender, EventArgs e) 
        {
            Curso curso = new Curso();
            curso.año = txtAño.Text.Trim();
            curso.division = cmbDivision.Text.Trim();
            curso.nombreCurso = txtNombre.Text.Trim();
            curso.cantAlumnos = Convert.ToInt32(txtCantCupos.Text);
            curso.descripcion = txtDescripcion.Text.Trim();
            curso.idCurso = Convert.ToInt32(txtIdCurso.Text);
            //curso.preceptor = 
            instanciaPrincipal.ModificarCurso(curso, curso.idCurso);
            instanciaPrincipal.RellenarListas();
            FrmAlertaBox frm = new FrmAlertaBox("Curso modificado con éxito!", Color.FromArgb(40, 167, 69), 1);
            frm.ShowDialog();


            this.Close();

        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void txtIdCurso_TextChanged(object sender, EventArgs e)
        {
            txtIdCurso.Enabled = false;
            txtIdCurso.BackColor = Color.Red;
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            
        }
    }
}
