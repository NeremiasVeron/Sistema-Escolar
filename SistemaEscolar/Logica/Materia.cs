using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Materia
    {
        //public Profesor profesor { get; set; }
        public int idMateria { get; set; }
        public string nombre { get; set; }
        public int nivel { get; set; }
        public string cargaHoraria { get; set; }
        
        public string alumnosPresentes { get; set; }

       
        //CONSTRUCTORES

        public Materia()
        {

        }
       
    }
}
