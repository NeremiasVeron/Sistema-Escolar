using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Alumno : Persona

    { 
        public int idCurso {get;set;}

        //private int? idCurso;
        public int matricula { get; set; }
        public string matAprobadas { get; set; }
        public string matDesaprobadas { get; set; }
        public bool condicion { get; set; } //CONSULTAR PROFE

        private string usuario;

        private string contraseña;


        //public void setCursoId(int? idCurso) { this.idCurso = idCurso; }
        //public int? getCursoId() { return idCurso; }


        //CONSTRUCTOR
        public Alumno( )
        {
            asignarEdad();
        }
        
        public void setUsuario(string usuario) { this.usuario = usuario; }

        public string getUsuario() { return usuario; }

        public void setContraseña(string clave) { contraseña = clave; }

        public string getContraseña() { return contraseña; }

    }
}
