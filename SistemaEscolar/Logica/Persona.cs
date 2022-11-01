using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public DateTime fechaNacimiento { get; set; }
        public string numeroDoc { get; set; }
        public string tipoDoc { get; set; }
        public string nroTelefono { get; set; }
        public string email { get; set; }

        public string localidad { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }

        public Persona() { }
        public void asignarEdad()
        {
            DateTime fechaActual = DateTime.Today;
            DateTime fechaLimite = new DateTime(1953, 01, 01);
            if (fechaNacimiento > fechaActual && fechaNacimiento < fechaLimite)
            {
                edad = 0;
            }
            else
            {
                int Edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --Edad;
                }
                edad = Edad;
            }
        }

        //public virtual string getDatos() //TRATAR DE CREAR UNA INTERFACE
        //{
        //    return nombre + "\n" + apellido + "\n" + dni + "\n" + tipoDni + "\n" + email + "\n" + fechaNacimiento + "\n" + direccion + "\n" + nacionalidad +  "\n" + sexo + "\n";

        //}

    }
}




