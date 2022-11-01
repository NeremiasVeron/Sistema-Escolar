using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class historialInasistenciasAlumno
    {
        public Alumno alumnoInasistencia { get; set; }
        public Preceptor preceptor_historialInasistencia { get; set; }

        public DateTime fechaHora { get; set; }
        public string motivo { get; set; }
        public string tipo { get; set; }
         //agregar metodo que si el alumno lleva mas de tantas faltas queda libre
    }
}
