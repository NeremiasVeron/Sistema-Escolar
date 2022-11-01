using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Examen
    {
        public Materia materia { get; set; }
        public Curso curso { get; set; }
        public int idExamen { get; set; }
        public string titulo { get; set; }
        public string temas { get; set; }
        public string instancia { get; set; }
        public string desarrollo { get; set; }
        public string periodo { get; set; }
        public DateTime fechaHora { get; set; }

        

    }
}
