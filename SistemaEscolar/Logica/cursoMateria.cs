using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class cursoMateria
    {
        public int idCursoMateria { get; set; }
        public Curso curso { get; set; }
        public int idCurso {get;set;}
        public Materia materia { get; set; }
        public int idMateria { get; set; }
        public string nombreMateria { get; set; } 
       
    }
}
