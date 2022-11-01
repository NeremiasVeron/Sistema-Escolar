using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class alumnoExamen
    {
        //PROP
        public int Id { get; set; }
        public Alumno alumno { get; set; }
        public int matriculaAlumno { get; set; }

        public Examen examen { get; set; }
        public int codExamen { get; set; }

        //CONSTRUCTOR

        //METODOS
    }
}
