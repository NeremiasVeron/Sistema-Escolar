using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace Logica
{
    public class Persistenciadedatos
    {
        readonly string RutaListaUsuarios = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeUsuarios.txt";

        readonly string RutaListaAlumnos = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeAlumnos.txt";
        readonly string RutaListaAlumnosIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosAlumnos.txt";

        readonly string RutaListaProfesores = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeProfesores.txt";
        readonly string RutaListaProfesorIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosProfesores.txt";

        readonly string RutaListaPreceptores = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDePrceptores.txt";
        readonly string RutaListaPreceptoresIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosPreceptores.txt";

        readonly string RutaListaMaterias = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeMaterias.txt";
        readonly string RutaListaMateriasIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosMaterias.txt";

        readonly string RutaListaExamenes = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeExamenes.txt";
        readonly string RutaListaExamenesIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosExamenes.txt";

        readonly string RutaListaCursos = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeCursos.txt";
        readonly string RutaListaCursosIdsEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosCursos.txt";

        readonly string RutaListaCursosMaterias = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeCursosMaterias.txt";
        readonly string RutaListaCursosMateriasIdEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosCursosMaterias.txt";

        readonly string RutaListaProfesoresMaterias = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeProfesorMaterias.txt";
        readonly string RutaListaProfesoresMateriasIdEliminados = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaIdEliminadosProfesoresMaterias.txt";

        readonly string RutaListaAlumnoMaterias = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeAlumnosMaterias.txt";
        readonly string RutaListaAlumnosExamenes = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeAlumnosExamen.txt";
        readonly string RutaListaProfesoresExamenes = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeProfesorExamen.txt";
        readonly string RutaListaHistorialHorario = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDeHistorialHorario.txt";
        readonly string RutaListaHistorialInasistencias = @"C:\Repositorio\BitBucker\SystemSchool\Archivos\ListaDehistorialInansistencias.txt";

        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListaUsuarios)) { File.Create(RutaListaUsuarios).Close(); }

            if (!File.Exists(RutaListaAlumnos)) { File.Create(RutaListaAlumnos).Close(); }
            if (!File.Exists(RutaListaAlumnosIdsEliminados)) { File.Create(RutaListaAlumnosIdsEliminados).Close(); }

            if (!File.Exists(RutaListaProfesores)) { File.Create(RutaListaProfesores).Close(); }
            if (!File.Exists(RutaListaProfesorIdsEliminados)) { File.Create(RutaListaProfesorIdsEliminados).Close(); }

            if (!File.Exists(RutaListaPreceptores)) { File.Create(RutaListaPreceptores).Close(); }
            if (!File.Exists(RutaListaPreceptoresIdsEliminados)) { File.Create(RutaListaPreceptoresIdsEliminados).Close(); }

            if (!File.Exists(RutaListaMaterias)) { File.Create(RutaListaMaterias).Close(); }
            if (!File.Exists(RutaListaMateriasIdsEliminados)) { File.Create(RutaListaMateriasIdsEliminados).Close(); }

            if (!File.Exists(RutaListaExamenes)) { File.Create(RutaListaExamenes).Close(); }
            if (!File.Exists(RutaListaExamenesIdsEliminados)) { File.Create(RutaListaExamenesIdsEliminados).Close(); }

            if (!File.Exists(RutaListaCursos)) { File.Create(RutaListaCursos).Close(); }
            if (!File.Exists(RutaListaCursosIdsEliminados)) { File.Create(RutaListaCursosIdsEliminados).Close(); }

            if (!File.Exists(RutaListaCursosMaterias)) { File.Create(RutaListaCursosMaterias).Close(); }
            if (!File.Exists(RutaListaCursosMateriasIdEliminados)) { File.Create(RutaListaCursosMateriasIdEliminados).Close(); }

            if (!File.Exists(RutaListaProfesoresMaterias)) { File.Create(RutaListaProfesoresMaterias).Close(); }
            if (!File.Exists(RutaListaProfesoresMateriasIdEliminados)) { File.Create(RutaListaProfesoresMateriasIdEliminados).Close(); }

            if (!File.Exists(RutaListaAlumnoMaterias)) { File.Create(RutaListaAlumnoMaterias).Close(); }
            if (!File.Exists(RutaListaAlumnosExamenes)) { File.Create(RutaListaAlumnosExamenes).Close(); }
            if (!File.Exists(RutaListaProfesoresExamenes)) { File.Create(RutaListaProfesoresExamenes).Close(); }
            if (!File.Exists(RutaListaHistorialHorario)) { File.Create(RutaListaHistorialHorario).Close(); }
            if (!File.Exists(RutaListaHistorialInasistencias)) { File.Create(RutaListaHistorialInasistencias).Close(); }
        }

        public List<Usuario> LeerArchivoUsuario()
        {
            string locationFile = RutaListaUsuarios;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Usuario> ListaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(content);
                return ListaUsuarios;
            }
        }
        public void GuardarArchivoUsuario(List<Usuario> ListaUsuarios)
        {
            string locationFile = RutaListaUsuarios;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaUsuarios);
                writer.Write(jsonContent);
            }
        }

        ////////////////////////////////////////////////////////// ALUMNOS //////////////////////////////////////////////////////////
        public List<Alumno> LeerArchivoAlumno()
        {
            string locationFile = RutaListaAlumnos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Alumno> ListaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(content);
                return ListaAlumnos;
            }
        }
        public void GuardarArchivoAlumno(List<Alumno> ListaAlumnos)
        {
            string locationFile = RutaListaAlumnos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlumnos);
                writer.Write(jsonContent);
            }
        }
        //ALUMNOS ELIMINADOS
        public List<int> LeerArchivoAlumnosIds()
        {
            string locationFile = RutaListaAlumnosIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaAlumnosIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaAlumnosIdsEliminados;
            }
        }
        public void GuardarArchivoAlumnosIdEliminados(List<int> ListaAlumnosIdsEliminados)
        {
            string locationFile = RutaListaAlumnosIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlumnosIdsEliminados);
                writer.Write(jsonContent);
            }
        }

        ////////////////////////////////////////////////////////// PROFESORES //////////////////////////////////////////////////////////
        public List<Profesor> LeerArchivoProfesor()
        {
            string locationFile = RutaListaProfesores;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Profesor> ListaProfesor = JsonConvert.DeserializeObject<List<Profesor>>(content);
                return ListaProfesor;
            }
        }
        public void GuardarArchivoProfesor(List<Profesor> ListaProfesor)
        {
            string locationFile = RutaListaProfesores;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProfesor);
                writer.Write(jsonContent);
            }
        }
        //PROFESORES ELIMINADOS
        public List<int> LeerArchivoProfesoresIds()
        {
            string locationFile = RutaListaProfesorIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaProfesorIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaProfesorIdsEliminados;
            }
        }

        public void GuardarArchivoProfesoresIdEliminados(List<int> ListaProfesoresIdsEliminados)
        {
            string locationFile = RutaListaProfesorIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProfesoresIdsEliminados);
                writer.Write(jsonContent);
            }
        }

        ////////////////////////////////////////////////////////// PRECEPTOR //////////////////////////////////////////////////////////
        public List<Preceptor> LeerArchivoPreceptor()
        {
            string locationFile = RutaListaPreceptores;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Preceptor> ListaPreceptores = JsonConvert.DeserializeObject<List<Preceptor>>(content);
                return ListaPreceptores;
            }
        }
        public void GuardarArchivoPreceptor(List<Preceptor> ListaPreceptor)
        {
            string locationFile = RutaListaPreceptores;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaPreceptor);
                writer.Write(jsonContent);
            }
        }
        //PRECEPTORES ELIMINADOS
        public List<int> LeerArchivoPreceptorIds()
        {
            string locationFile = RutaListaPreceptoresIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaPreceptoresIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaPreceptoresIdsEliminados;
            }
        }
        public void GuardarArchivoPreceptoresIdEliminados(List<int> ListaPreceptoresIdsEliminados)
        {
            string locationFile = RutaListaPreceptoresIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaPreceptoresIdsEliminados);
                writer.Write(jsonContent);
            }
        }


        ////////////////////////////////////////////////////////// MATERIAS //////////////////////////////////////////////////////////
        public List<Materia> LeerArchivoMateria()
        {
            string locationFile = RutaListaMaterias;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Materia> ListaMaterias = JsonConvert.DeserializeObject<List<Materia>>(content);
                return ListaMaterias;
            }
        }
        public void GuardarArchivoMateria(List<Materia> ListaMaterias)
        {
            string locationFile = RutaListaMaterias;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaMaterias);
                writer.Write(jsonContent);
            }
        }

        public List<int> LeerArchivoMateriaIds()
        {
            string locationFile = RutaListaMateriasIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaMateriasIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaMateriasIdsEliminados;
            }
        }

        public void GuardarArchivoMateriasIdEliminados(List<int> ListaMateriasIdsEliminados)
        {
            string locationFile = RutaListaMateriasIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaMateriasIdsEliminados);
                writer.Write(jsonContent);
            }
        }
        ////////////////////////////////////////////////////////// EXAMENES //////////////////////////////////////////////////////////

        public List<Examen> LeerArchivoExamen()
        {
            string locationFile = RutaListaExamenes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Examen> ListaExamenes = JsonConvert.DeserializeObject<List<Examen>>(content);
                return ListaExamenes;
            }
        }
        public void GuardarArchivoExamen(List<Examen> ListaExamenes)
        {
            string locationFile = RutaListaExamenes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaExamenes);
                writer.Write(jsonContent);
            }
        }
        //EXAMENES ELIMINADOS
        public List<int> LeerArchivoExamenesIds()
        {
            string locationFile = RutaListaExamenesIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaExamenesIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaExamenesIdsEliminados;
            }
        }

        public void GuardarArchivoExamenesIdEliminados(List<int> ListaExamenesIdsEliminados)
        {
            string locationFile = RutaListaExamenesIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaExamenesIdsEliminados);
                writer.Write(jsonContent);
            }
        }


        //////////////////////////////////////////////////////////CURSOS///////////////////////////////////////////////////////////////////
        public List<Curso> LeerArchivoCurso()
        {
            string locationFile = RutaListaCursos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Curso> ListaCursos = JsonConvert.DeserializeObject<List<Curso>>(content);
                return ListaCursos;
            }
        }
        public void GuardarArchivoCurso(List<Curso> ListaCursos)
        {
            string locationFile = RutaListaCursos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCursos);
                writer.Write(jsonContent);
            }
        }
            //CURSOS ELIMINADOS
        public List<int> LeerArchivoCursosIds()
        {
            string locationFile = RutaListaCursosIdsEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaCursosIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaCursosIdsEliminados;
            }
        }

        public void GuardarArchivoCursosIdEliminados(List<int> ListaCursosIdsEliminados)
        {
            string locationFile = RutaListaCursosIdsEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCursosIdsEliminados);
                writer.Write(jsonContent);
            }
        }

        //////////////////////////////////////////////////////////ALUMNOS_MATERIAS  (M:M)//////////////////////////////////////////////////////////
        public List<alumnoMateria> LeerArchivoAlumnoMateria()
        {
            string locationFile = RutaListaAlumnoMaterias;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<alumnoMateria> ListaAlumnoMaterias = JsonConvert.DeserializeObject<List<alumnoMateria>>(content);
                return ListaAlumnoMaterias;
            }
        }
        public void GuardarArchivoCurso(List<alumnoMateria> ListaAlumnoMaterias)
        {
            string locationFile = RutaListaAlumnoMaterias;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlumnoMaterias);
                writer.Write(jsonContent);
            }
        }
        ////////////////////////////////////////////////////////// ALUMNOS_EXAMENES (M:M) //////////////////////////////////////////////////////////
        public List<alumnoExamen> LeerArchivoAlumnoExamen()
        {
            string locationFile = RutaListaAlumnosExamenes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<alumnoExamen> ListaAlumnoExamenes = JsonConvert.DeserializeObject<List<alumnoExamen>>(content);
                return ListaAlumnoExamenes;
            }
        }
        public void GuardarArchivoAlumnoExamen(List<alumnoExamen> ListaAlumnosExamenes)
        {
            string locationFile = RutaListaAlumnosExamenes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaAlumnosExamenes);
                writer.Write(jsonContent);
            }
        }
        ////////////////////////////////////////////////////////// PROFESOR_EXAMENES (M:M) //////////////////////////////////////////////////////////
        public List<profesorExamen> LeerArchivoProfesorExamen()
        {
            string locationFile = RutaListaProfesoresExamenes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<profesorExamen> ListaProfesoresExamenes = JsonConvert.DeserializeObject<List<profesorExamen>>(content);
                return ListaProfesoresExamenes;
            }
        }
        public void GuardarArchivoProfesorExamen(List<profesorExamen> ListaProfesoresExamenes)
        {
            string locationFile = RutaListaProfesoresExamenes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProfesoresExamenes);
                writer.Write(jsonContent);
            }
        }

        /////////////////////////////////////////////////////////// HISTORIALHORARIO //////////////////////////////////////////////////////////
        public List<historialHorarioMateria> LeerArchivoHistorialHorario()
        {
            string locationFile = RutaListaHistorialHorario;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<historialHorarioMateria> ListaHistorialHorario = JsonConvert.DeserializeObject<List<historialHorarioMateria>>(content);
                return ListaHistorialHorario;
            }
        }
        public void GuardarArchivoHistorialHorario(List<historialHorarioMateria> ListaHistorialHorario)
        {
            string locationFile = RutaListaHistorialHorario;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaHistorialHorario);
                writer.Write(jsonContent);
            }
        }

        ////////////////////////////////////////////////////////// HISTORIAL_INASISTENCIAS //////////////////////////////////////////////////////////
        public List<historialInasistenciasAlumno> LeerArchivoHistorialInasistencias()
        {
            string locationFile = RutaListaHistorialInasistencias;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<historialInasistenciasAlumno> ListaHistorialInasistencias = JsonConvert.DeserializeObject<List<historialInasistenciasAlumno>>(content);
                return ListaHistorialInasistencias;
            }
        }
        public void GuardarArchivoHistorialInasistencia(List<historialInasistenciasAlumno> ListaHistorialInasistencias)
        {
            string locationFile = RutaListaHistorialInasistencias;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaHistorialInasistencias);
                writer.Write(jsonContent);
            }
        }
        ////////////////////////////////////////////////////////// PROFESOR - MATERIAS (M:M) //////////////////////////////////////////////////////////
        public List<profesorMateria> LeerArchivoProfesorMaterias()
        {
            string locationFile = RutaListaProfesoresMaterias;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<profesorMateria> ListaProfesorMateria = JsonConvert.DeserializeObject<List<profesorMateria>>(content);
                return ListaProfesorMateria;
            }
        }
        public void GuardarArchivoProfesorMateria(List<profesorMateria> listaProfesorMateria)
        {
            string locationFile = RutaListaProfesoresMaterias; 
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(listaProfesorMateria);
                writer.Write(jsonContent);
            }
        }
        //PROFESORMATERIAS ELIMINADOS
        public List<int> LeerArchivoProfesorMateriaIdEliminados()
        {
            string locationFile = RutaListaProfesoresMateriasIdEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaProfesorMateriaIdsEliminados = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaProfesorMateriaIdsEliminados;
            }
        }

        public void GuardarArchivoProfesorMateriaIdEliminados(List<int> ListaProfesorMateriaIdsEliminados)
        {
            string locationFile = RutaListaProfesoresMateriasIdEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaProfesorMateriaIdsEliminados);
                writer.Write(jsonContent);
            }
        }

        ////////////////////////////////////////////////////////// CURSOS - MATERIAS(M:M) //////////////////////////////////////////////////////////
        public List<cursoMateria> LeerArchivoCursoMaterias()
        {
            string locationFile = RutaListaCursosMaterias;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<cursoMateria> ListaCursoMateria = JsonConvert.DeserializeObject<List<cursoMateria>>(content);
                return ListaCursoMateria;
            }
        }

        public void GuardarArchivoCursoMateria(List<cursoMateria> listaCursoMateria)
        {
            string locationFile = RutaListaCursosMaterias;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(listaCursoMateria);
                writer.Write(jsonContent);
            }
        }
        //CURSOSMATERIAS ELIMINADOS
        public List<int> LeerArchivoCursoMateriasIdEliminados()
        {
            string locationFile = RutaListaCursosMateriasIdEliminados;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<int> ListaIdEliminadosCursoMateria = JsonConvert.DeserializeObject<List<int>>(content);
                return ListaIdEliminadosCursoMateria;
            }
        }
        public void GuardarArchivoCursoMateriaIdEliminados(List<int> listaIdEliminadosCursoMateria)
        {
            string locationFile = RutaListaCursosMateriasIdEliminados;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(listaIdEliminadosCursoMateria);
                writer.Write(jsonContent);
            }
        }


    }
}

