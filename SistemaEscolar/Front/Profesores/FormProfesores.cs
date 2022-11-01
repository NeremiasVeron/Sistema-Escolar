using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Profesores
{
  
    public partial class FormProfesores : Form
    {
        Form formActual = new Form();
        public FormProfesores()
        {
            InitializeComponent();
        }

        private void FormProfesores_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAltaProfesor());
        }
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {

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
            panelProfesores.Controls.Add(childForm);
            panelProfesores.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        

        
    }
}
