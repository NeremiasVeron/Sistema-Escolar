using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Profesor : Persona
    {
        //PROP
        public int nroLegajo { get; set; }
        public string especializacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public int antiguedad { get; set; } 
        public string nivel { get; set; }
        public string reemplazante { get; set; }

        //public string fechaInscripcion { get; set; }

        ///////////COSNTRUCTORES
        public Profesor( ) { }

        ///////////METODOS

        //private void asignarAntiguedad() {}


    }
}
