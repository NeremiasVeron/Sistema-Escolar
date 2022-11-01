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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Front.Cursos
{
    public partial class FormAsignarMaterias : Form
    {
        Principal instanciaPrincipal = new Principal();
        int posicion;
        public FormAsignarMaterias()
        {
            InitializeComponent();
        }
        private void FormAsignarMaterias_Load(object sender, EventArgs e)
        {
            AnularCampos();
            RellenarGridMateriasAsignadas();
           
        }

      
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            List<Materia> listaMaterias = new List<Materia>();
            Curso curso = new Curso();

            curso = instanciaPrincipal.BuscarCursoPorAñoyDivision(txtAño.Text, cmbDivision.Text);

            foreach (DataGridViewRow indice in dtgMaterias.SelectedRows) //busco la materia asignar
            {
                listaMaterias = instanciaPrincipal.BuscarMateriaPorId(Convert.ToInt32(indice.Cells[0].Value));
            }
          
            if (instanciaPrincipal.BuscarCursoMateria(curso.idCurso, listaMaterias[0].idMateria).Count == 0) //validacion para no agregar dos materias iguales.  
            {
                instanciaPrincipal.AsignarCursoMateria(listaMaterias[0], curso);
                RellenarGridMateriasAsignadas();
            }
            else { MessageBox.Show("La materia seleccionada ya se encuentra asignada al curso! " , "ASIGNAR MATERIA " , MessageBoxButtons.OK, MessageBoxIcon.Error); } 
            
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow indice in gridMateriasCursos.SelectedRows) //busco la materia asignar
            {
                int idCursoMateria = Convert.ToInt32(indice.Cells[0].Value);
                instanciaPrincipal.QuitarCursoMateria(idCursoMateria);
                break;
            }
            RellenarGridMateriasAsignadas();
        }

        private void RellenarGridMateriasAsignadas()
        {
            dtgMaterias.DataSource = null;
            dtgMaterias.DataSource = instanciaPrincipal.getListaMaterias();
            lblNumeroMaterias.Text = instanciaPrincipal.getListaMaterias().Count.ToString();
            gridMateriasCursos.DataSource = null;
            gridMateriasCursos.DataSource = instanciaPrincipal.GetListaCursoMaterias(Convert.ToInt32(txtIdCurso.Text)); //Filtro las materias por curso porque sino me muestra todas. 
            lblContadorMatAsignadas.Text = instanciaPrincipal.GetListaCursoMaterias(Convert.ToInt32(txtIdCurso.Text)).Count.ToString();
        }
        private void AnularCampos()
        {
            txtAño.Enabled = false;
            cmbDivision.Enabled = false;
            txtIdCurso.Enabled = false;
            cmbPreceptorCargo.Enabled = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dtgMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = e.RowIndex;
        }
       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void icnbtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
