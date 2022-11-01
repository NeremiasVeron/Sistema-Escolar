using Front.Cursos;
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
    public partial class FormCursos : Form
    {
        private Form formactual;
        //private DataGridView dtg_Cursos;
        Principal instanciaPrincipal = new Principal();
        public FormCursos()
        {
            InitializeComponent();
            actualizarGrilla();
        }
        private void FormCursos_Load(object sender, EventArgs e)
        {
            //instanciaPrincipal.RellenarListas();
            //dtgCursos.DataSource = instanciaPrincipal.getListaCursos();
            actualizarGrilla();
            rbtnAñoDivision.Checked = true;
            //dtgCursos = dtg_Cursos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAltaCursos());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarCurso frm = new FormModificarCurso();

            foreach (DataGridViewRow indice in dtgCursos.SelectedRows)
            {
                frm.txtIdCurso.Text = indice.Cells[0].Value.ToString();
                frm.txtAño.Text = indice.Cells[1].Value.ToString();
                frm.cmbDivision.Text = indice.Cells[2].Value.ToString();
                frm.txtNombre.Text = indice.Cells[3].Value.ToString();
                frm.txtCantCupos.Text = indice.Cells[4].Value.ToString();
                frm.txtDescripcion.Text = indice.Cells[5].Value.ToString();
                //frm.cmbPreceptorCarg = indice.Cells[x].Value.ToString();
                //faltaria modificar las materias que tiene asignada. 
                //if (indice.Cells[1].Value == null) { indice.Cells[1].Value = 0; frm.txtMatAprobadas.Text = indice.Cells[1].Value.ToString(); }
                //else { frm.txtMatAprobadas.Text = indice.Cells[1].Value.ToString(); }
                break;
            }
            OpenChildForm(frm);
            actualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult inputUsuario = MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Eliminar alumno", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (inputUsuario == DialogResult.OK)
            {
                foreach (DataGridViewRow indice in dtgCursos.SelectedRows)
                {
                    int idCursoEliminado = Convert.ToInt32(indice.Cells[0].Value);
                    instanciaPrincipal.EliminarCurso(idCursoEliminado);
                    break;
                }
                FrmAlertaBox frm = new FrmAlertaBox("Alumno eliminado con éxito", Color.FromArgb(220, 53, 63), 2);
                frm.ShowDialog();
            }
            actualizarGrilla();
        }


        private void panelCursos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm) //Ver si puedo reutilizar la funcion del form del menu y ahorrame reescribirla.
        {
            if (formactual != null)
            {
                formactual.Close();
            }
            formactual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCursos.Controls.Add(childForm);
            panelCursos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void actualizarGrilla()
        {
            instanciaPrincipal.RellenarListas();
            dtgCursos.DataSource = null;
            dtgCursos.DataSource = instanciaPrincipal.getListaCursos();
        }

        private void FormCursos_Activated(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void btnAsignarMaterias_Click(object sender, EventArgs e)
        {
            FormAsignarMaterias form = new FormAsignarMaterias();

            foreach (DataGridViewRow indice in dtgCursos.SelectedRows)
            {
                form.txtIdCurso.Text = indice.Cells[0].Value.ToString();
                form.txtAño.Text = indice.Cells[1].Value.ToString();
                form.cmbDivision.Text = indice.Cells[2].Value.ToString();
                break;
            }

            OpenChildForm(form);

        }
    }
}
