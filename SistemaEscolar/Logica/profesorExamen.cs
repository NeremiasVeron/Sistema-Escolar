using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class profesorExamen
    {
        public int Id { get; set; }
        public Profesor profesor_Examen { get; set; }
        public int nroLegajoProfesor { get; set; }

        public Examen examenProfesor { get; set; }
        public int codExamen { get; set; }

    }
}
