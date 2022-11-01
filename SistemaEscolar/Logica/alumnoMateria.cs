using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class alumnoMateria
    {
        //PROPIEDADES
        public int Id { get; set; }
        public Alumno Alumno { get; set; } 

        public int matriculaAlumno { get; set; }

        public Materia Materia { get; set; }

        public int CodMateria { get; set; }

        public float notaPrimerTrimestre { get; set; } //agregar a der - deberian estar en alumnoMateria
        public float notaSegundoTrimestre { get; set; } 
        public float notaTercerTrimestre { get; set; } 
        public float notaFinal { get; set; }

        

        //CONSTRUCTOR

        //METODOS
    }
}
