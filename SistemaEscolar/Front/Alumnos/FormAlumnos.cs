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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Front
{
    public partial class FormAlumnos : Form
    {
        private Form formactual;
        Principal instanciaPrincipal = new Principal();

        public FormAlumnos()
        {
            InitializeComponent();
            actualizarGrilla();
            //instanciaPrincipal.RellenarListas();

        }
        
        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
            //lblAlumnoMod.Visible = false;
           //lblIdAlumnoMod.Visible = false;

                //5/10 = 00:00HS. Agregar una lista a la logica datos mas relevantes, traerla y mostrarla. En los btn ABM, llamo al dtg del form a heredar.
                           //Heredar otro form de alumnos para mostrar la lista con datos completos.

            //foreach(var indice in instanciaPrincipal.getListaAlumnos())
            //{
            //    dtgAlumnos.Rows.Add(indice.matricula,indice.nombre,indice.apellido,indice.tipoDoc,indice.numeroDoc,indice.nroTelefono);

            //}
        }
   
        private void actualizarGrilla() 
        { 
            instanciaPrincipal.RellenarListas();
            gridAlumnos.DataSource = null;
            gridAlumnos.DataSource = instanciaPrincipal.getListaAlumnos();
            lblContadorAlumnos.Text = instanciaPrincipal.getListaAlumnos().Count.ToString(); 

        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAltaAlumno());
        }

        //MEOTODS
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
            panelAlumnos.Controls.Add(childForm);
            panelAlumnos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (rbtnMatricula.Checked == true)
            {
                int matriculaAlumno = Convert.ToInt32(txtBusqueda.Text);
                List<Alumno> listaAlumnosEncontrada = new List<Alumno>();
                listaAlumnosEncontrada = instanciaPrincipal.BuscarAlumnoPorMatricula(matriculaAlumno);

                if ( listaAlumnosEncontrada.Count == 0)
                {
                    MessageBox.Show("No existe alumno con matricula " + txtBusqueda.Text + "!" , "Búsqueda" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                }
                else
                {
                    gridAlumnos.DataSource = listaAlumnosEncontrada;
                }
                
            }

            else if (rbtnNombre.Checked == true)
            {
                string nombreAlumno = txtBusqueda.Text.Trim();
                List<Alumno> listaAlumnosEncontrada = new List<Alumno>();
                listaAlumnosEncontrada = instanciaPrincipal.BuscarAlumnoPorNombre(nombreAlumno);

                if (listaAlumnosEncontrada.Count == 0 )
                {
                    MessageBox.Show("No existe el alumno con nombre '" + txtBusqueda.Text + "' !");
                }
                else
                {
                    gridAlumnos.DataSource = listaAlumnosEncontrada;
                }
               
            }

            else if (rbtnDocumento.Checked == true)
            { 
                string dniAlumno = txtBusqueda.Text.Trim();
                List<Alumno> listaAlumnosEncontrada = new List<Alumno>();
                listaAlumnosEncontrada = instanciaPrincipal.BuscarAlumnoPorDNI(dniAlumno);

                if (listaAlumnosEncontrada.Count == 0)
                {
                    MessageBox.Show("No existe alumno con numero de documento '" + txtBusqueda.Text + "' !" ,"Búsqueda", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                }
                else
                {
                    gridAlumnos.DataSource = listaAlumnosEncontrada;
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione porqué filtro desea buscar.", " Buscar ", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult inputUsuario = MessageBox.Show("¿Estas seguro que desea eliminar el registro?", "Eliminar alumno", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (inputUsuario == DialogResult.OK)
            {
                foreach (DataGridViewRow indice in gridAlumnos.SelectedRows)
                {
                    int idAlumnoEliminado = Convert.ToInt32(indice.Cells[0].Value);
                    instanciaPrincipal.EliminarAlumno(idAlumnoEliminado);
                    break;
                }
                FrmAlertaBox frm = new FrmAlertaBox("Alumno eliminado con éxito", Color.FromArgb(220, 53, 63), 2);
                frm.ShowDialog();
            }
            actualizarGrilla();
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            FormModificarAlumno frm = new FormModificarAlumno();

            foreach (DataGridViewRow indice in gridAlumnos.SelectedRows)
            {
                frm.txtMatricula.Text = indice.Cells[0].Value.ToString();
                frm.txtIdCurso.Text = indice.Cells[1].Value.ToString();
                
                List<Curso> listaCurso = new List<Curso>();
                listaCurso = instanciaPrincipal.BuscarCursoPorId(Convert.ToInt32(indice.Cells[1].Value));
                foreach (var i in listaCurso) //recorro la lista en la que tengo el objeto curso para extraer las propiedaes que me interesan modificar y mandarlas al otro form. 
                {
                    frm.cmbCursos.Text = i.año.ToString();
                    frm.cmbDivisioness.Text = i.division.ToString();
                }

                frm.txtNombre.Text = indice.Cells[2].Value.ToString();
                frm.txtApellido.Text = indice.Cells[3].Value.ToString();
                frm.cmbTipoDoc.Text = indice.Cells[4].Value.ToString();
                frm.txtNroDoc.Text = indice.Cells[5].Value.ToString();
                frm.txtLocalidadAlumno.Text = indice.Cells[7].Value.ToString();
                frm.txtTelefonoAlumno.Text = indice.Cells[8].Value.ToString();
                frm.txtEmail.Text = indice.Cells[9].Value.ToString();
                frm.txtDireccion.Text = indice.Cells[10].Value.ToString();

                if (indice.Cells[11].Value.ToString() == "Masculino") { frm.radiobtnM.Select(); } else { frm.radiobtnF.Select(); } //Envio al otro form el sexo del alumno que di de alta.

                frm.dtmAlumno.Value = (DateTime)indice.Cells[12].Value;
                if (indice.Cells[13].Value == null) { indice.Cells[13].Value = 0; frm.txtMatAprobadas.Text = indice.Cells[13].Value.ToString(); }
                else { frm.txtMatAprobadas.Text = indice.Cells[13].Value.ToString(); }
                if (indice.Cells[14].Value == null) { indice.Cells[14].Value = 0; frm.txtMatDesaprobadas.Text = indice.Cells[14].Value.ToString(); }
                else { frm.txtMatDesaprobadas.Text = indice.Cells[14].Value.ToString(); }
                //fmr.condicion[15]
            }
            OpenChildForm(frm);
            actualizarGrilla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void panelAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }
        private void boton1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void persistenciadedatosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void principalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiarLista_Click_1(object sender, EventArgs e)
        {
            instanciaPrincipal.EliminarListaCompleta();
            actualizarGrilla();
        }

        private void gridAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblIdAlumnoMod_Click(object sender, EventArgs e)
        {
         
        }

        private void lblAlumnoMod_Click(object sender, EventArgs e)
        {
           
        }

        private void rbtnNombre_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


