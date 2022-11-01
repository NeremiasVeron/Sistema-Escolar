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

namespace Front.FrmMateria
{
    public partial class FrmMaterias : Form
    {
        Form formActual = new Form();
        Principal instanciaPrincipal = new Principal();
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FrmModificarMateria());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DesactivarBtn();
            txtNombre.Focus();
            
        }
        private void DesactivarBtn()
        {
            btnNuevo.Enabled = false;
            btnNuevo.BackColor = Color.Gray;

            btnModificar.Enabled = false;
            btnModificar.BackColor = Color.Gray;

            btnEliminar.Enabled = false;
            btnEliminar.BackColor = Color.Gray;

            dtgMaterias.Enabled = false;
            dtgMaterias.BackColor = Color.Gray;

            btnBuscar.Enabled = false;
            btnBuscar.BackColor = Color.Gray;

            btnActualizar.Enabled = false;
            btnActualizar.BackColor = Color.Gray;

            txtBusqueda.Enabled = false;
            txtBusqueda.BackColor= Color.Gray;

            txtCodigo.Enabled = false;
            txtCodigo.BackColor = Color.Gray;

            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.BackColor = Color.FromArgb(31, 30, 68);
        }
        private void ActivarBtn()
        {

            btnNuevo.Enabled = true;
            btnNuevo.BackColor = Color.MediumSlateBlue;

            btnCancelar.Enabled = true;
            btnCancelar.BackColor = Color.MediumSlateBlue;

            btnActualizar.Enabled = true;
            btnActualizar.BackColor = Color.MediumSlateBlue;

            btnBuscar.Enabled = true;
            btnBuscar.BackColor = Color.MediumSlateBlue;

            dtgMaterias.Enabled = true;
            dtgMaterias.BackColor = Color.MediumSlateBlue;

            txtBusqueda.Enabled = true; 
            txtBusqueda.BackColor = Color.White;

            txtCodigo.Enabled = true;
            txtCodigo.BackColor= Color.White;

            btnModificar.Enabled = true;
            btnModificar.BackColor = Color.MediumSlateBlue;

            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.MediumSlateBlue;
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
            panelMaterias.Controls.Add(childForm);
            panelMaterias.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Materia materiaNueva = new Materia();
            materiaNueva.nombre = txtNombre.Text.Trim();
            materiaNueva.cargaHoraria = txtCargaHs.Text.Trim();

            instanciaPrincipal.AltaMateria(materiaNueva);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ActivarBtn();
        }
        private void ActualizarGrilla()
        {
            dtgMaterias.DataSource = null;
            dtgMaterias.DataSource = instanciaPrincipal.getListaMaterias();
        }

    }
}
