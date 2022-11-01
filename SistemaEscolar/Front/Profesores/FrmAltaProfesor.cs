using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Front.Profesores
{
    
    public partial class FrmAltaProfesor : Form
    {
        Principal instanciaPrincipal = new Principal();
        public FrmAltaProfesor()
        {
            InitializeComponent();
        }
        private void FrmAltaProfesor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbDivisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista profesores
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private string asignarSexo() 
        {
            if (radiobtnF.Checked)
            {
                return radiobtnF.Text; 
            }
            else {return radiobtnM.Text; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor profesorNuevo = new Profesor();
            profesorNuevo.nombre = txtNombre.Text.Trim().ToLower();
            profesorNuevo.apellido = txtApellido.Text.Trim().ToLower();
            profesorNuevo.tipoDoc = cmbTipodoc.Text;
            profesorNuevo.numeroDoc = txtNroDoc.Text.Trim();
            profesorNuevo.email = txtEmail.Text.Trim();
            profesorNuevo.nroTelefono = txtTelefonoAlumno.Text.Trim();
            profesorNuevo.sexo = asignarSexo();
            profesorNuevo.fechaInicio = dtmFechaInicio.Value;
            profesorNuevo.nivel = txtNivelCat.Text.Trim();
            profesorNuevo.especializacion = txtEspecializacion.Text.Trim();

            instanciaPrincipal.AltaProfesor(profesorNuevo);

        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {

        }

       
    }
}
