using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class profesorMateria
    {
        public int IdProfesorMateria { get; set; }

        public Profesor profesor { get; set; }  
        public int nroLegajoProfesor { get; set; }

        public Materia materia { get; set; }
        public int CodMateria { get; set; }
    }
}
