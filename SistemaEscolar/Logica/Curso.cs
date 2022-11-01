using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Curso
    {
        //PROPIEDADES
        //public Preceptor preceptorCurso { get; set; }

        //public int? IdPreceptor;
        public int idCurso { get; set; }
        public string año { get; set; }
        public string division { get; set; }
        public string nombreCurso { get; set; }//agregar der
        public int cantAlumnos { get; set; }
        public string descripcion { get; set; }
        

        //GETTERS Y SETTERS
        //public void setIdPreceptor(int idPreceptor){ this.IdPreceptor = idPreceptor; }
        //public int getIdPreceptor() { return (int)IdPreceptor; }

        //CONSTRUCTORES
        public Curso() { }
    }
}
