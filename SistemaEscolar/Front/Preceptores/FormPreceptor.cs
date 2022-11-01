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
    public partial class FormPreceptor : Form
    {
        private Form formActual;
        Principal instanciaPrincipal = new Principal();
        public FormPreceptor()
        {
            InitializeComponent();
            instanciaPrincipal.RellenarListas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAltaPreceptor());
        }
        
        private void FrmPreceptor_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void ActualizarGrilla() 
        {
            instanciaPrincipal.RellenarListas();
            dtgPreceptores.DataSource = null;
            dtgPreceptores.DataSource = instanciaPrincipal.getListaPreceptor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarPreceptor frm = new FormModificarPreceptor();
            int idPreceptor = 0;
            foreach (DataGridViewRow indice in dtgPreceptores.SelectedRows)  //Manera diferente de pasar los datos al form de modificar a la que venia haciendo anteriormente. 
            {
                idPreceptor = Convert.ToInt32(indice.Cells[0].Value);
                break;
            }
            frm.txtMatricula.Text = idPreceptor.ToString(); 
            frm.txtNombre.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).nombre;
            frm.txtApellido.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).apellido;
            frm.txtNroDoc.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).numeroDoc;
            frm.cmbTipoDoc.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).tipoDoc;
            frm.dtmPreceptor.Value = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).fechaNacimiento;
            frm.txtTelefono.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).nroTelefono;
            frm.txtEmail.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).email;
            frm.txtLocalidad.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).localidad;
            frm.txtDireccion.Text = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).direccion;
            frm.dtmFechaInicio.Value = instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).fechaInicio;
            if (instanciaPrincipal.BuscarPreceptorPorId(idPreceptor).sexo == frm.radiobtnF.Text) { frm.radiobtnF.Checked = true; }
            else { frm.radiobtnM.Checked = true; }
            OpenChildForm(frm);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult inputUsuario = MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Eliminar Preceptor", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (inputUsuario == DialogResult.OK)
            {
                foreach (DataGridViewRow indice in dtgPreceptores.SelectedRows)
                {
                    int idPreceptorEliminado = Convert.ToInt32(indice.Cells[0].Value);
                    instanciaPrincipal.EliminarPreceptor(idPreceptorEliminado);
                    break;
                }
                FrmAlertaBox frm = new FrmAlertaBox("Preceptor eliminado con éxito", Color.FromArgb(220, 53, 63), 2);
                frm.ShowDialog();
            }
            ActualizarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void OpenChildForm(Form childForm) //Ver si puedo reutilizar la funcion del form del menu y ahorrame reescribirla.
        {
            if (formActual != null)
            {
                formActual.Close();
            }
            formActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPreceptor.Controls.Add(childForm);
            panelPreceptor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void actualizarGrilla()
        {
            //instanciaPrincipal.RellenarListas();
            //dtgPreceptores.DataSource = null;
            //dtgPreceptores.DataSource = instanciaPrincipal.getListaAlumnos();
        }
    }
}
