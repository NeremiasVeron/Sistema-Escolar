using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logica
{
    public class Principal
    {
        List<Usuario> ListaUsuarios = new List<Usuario>();

        List<Alumno> ListaAlumnos = new List<Alumno>();
        List<int> ListaIdEliminados = new List<int>();

        List<Profesor> ListaProfesor = new List<Profesor>();
        List<int> ListaIdEliminadosProfesores = new List<int>();

        List<Preceptor> ListaPreceptor = new List<Preceptor>();
        List<int> ListaIdEliminadosPreceptor = new List<int>();

        List<Materia> ListaMaterias = new List<Materia>();
        List<int> ListaIdEliminadosMaterias = new List<int>();

        List<Examen> ListaExamenes = new List<Examen>();
        List<int> ListaIdEliminadosExamenes = new List<int>();

        List<Curso> ListaCursos = new List<Curso>();
        List<int> ListaIdEliminadosCursos = new List<int>();

        List<cursoMateria> ListaCursosMaterias = new List<cursoMateria>();
        List<int> ListaIdEliminadosCursosMaterias = new List<int>();

        List<profesorMateria> ListaProfesorMaterias = new List<profesorMateria>();
        List<int> ListaIdEliminadosProfesoresMaterias = new List<int>();

        List<alumnoMateria> ListaAlumnoMaterias = new List<alumnoMateria>();
        List<alumnoExamen> ListaAlumnoExamen = new List<alumnoExamen>();
        List<historialHorarioMateria> ListaHistorialHorarioMaterias = new List<historialHorarioMateria>();
        List<historialInasistenciasAlumno> ListaHistorialInasistencias = new List<historialInasistenciasAlumno>();

        Persistenciadedatos InstanciaPersistenciaDatos = new Persistenciadedatos();

        public Principal() ///CONSTRUCTOR PARA INICIALIZAR ARCHIVOS Y RELLENAR LISTAS. 
        { InstanciaPersistenciaDatos.InicializarArchivos(); ; RellenarListas(); }
        public void RellenarListas()
        {
            ListaUsuarios = InstanciaPersistenciaDatos.LeerArchivoUsuario();

            ListaAlumnos = InstanciaPersistenciaDatos.LeerArchivoAlumno();
            ListaIdEliminados = InstanciaPersistenciaDatos.LeerArchivoAlumnosIds();

            ListaProfesor = InstanciaPersistenciaDatos.LeerArchivoProfesor();
            ListaIdEliminadosProfesores = InstanciaPersistenciaDatos.LeerArchivoProfesoresIds();

            ListaPreceptor = InstanciaPersistenciaDatos.LeerArchivoPreceptor();
            ListaIdEliminadosPreceptor = InstanciaPersistenciaDatos.LeerArchivoPreceptorIds();

            ListaMaterias = InstanciaPersistenciaDatos.LeerArchivoMateria();
            ListaIdEliminadosMaterias = InstanciaPersistenciaDatos.LeerArchivoMateriaIds();

            ListaExamenes = InstanciaPersistenciaDatos.LeerArchivoExamen();
            ListaIdEliminadosExamenes = InstanciaPersistenciaDatos.LeerArchivoMateriaIds();

            ListaCursos = InstanciaPersistenciaDatos.LeerArchivoCurso();
            ListaIdEliminadosCursos = InstanciaPersistenciaDatos.LeerArchivoCursosIds();

            List<cursoMateria> ListaCursosMaterias = InstanciaPersistenciaDatos.LeerArchivoCursoMaterias();
            ListaIdEliminadosCursosMaterias = InstanciaPersistenciaDatos.LeerArchivoCursoMateriasIdEliminados();

            ListaAlumnoMaterias = InstanciaPersistenciaDatos.LeerArchivoAlumnoMateria();

            ListaProfesorMaterias = InstanciaPersistenciaDatos.LeerArchivoProfesorMaterias();
            ListaIdEliminadosProfesoresMaterias = InstanciaPersistenciaDatos.LeerArchivoProfesorMateriaIdEliminados();

            ListaAlumnoExamen = InstanciaPersistenciaDatos.LeerArchivoAlumnoExamen();

            ListaHistorialHorarioMaterias = InstanciaPersistenciaDatos.LeerArchivoHistorialHorario();

            ListaHistorialInasistencias = InstanciaPersistenciaDatos.LeerArchivoHistorialInasistencias();

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                      ////GESTIÓN DE USERS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaUsuario(Usuario nuevoUsuario)
        {
            ListaUsuarios = ValidarNullListaUsuarios();
            Usuario usuario = new Usuario();

            usuario.codUsuario = ListaUsuarios.Count + 1;
            usuario.usuario = nuevoUsuario.usuario;
            usuario.contraseña = nuevoUsuario.contraseña;
            usuario.nombre = nuevoUsuario.nombre;
            usuario.nroDocumento = nuevoUsuario.nroDocumento;

            ListaUsuarios.Add(usuario);
            InstanciaPersistenciaDatos.GuardarArchivoUsuario(ListaUsuarios);

        }
        
        public List<Usuario> ValidarNullListaUsuarios()
        {
            ListaUsuarios = InstanciaPersistenciaDatos.LeerArchivoUsuario();
            if (ListaUsuarios == null)
            {
                List<Usuario> nuevaListaUsuarios = new List<Usuario>();
                return nuevaListaUsuarios;
            }
            else
            {
                return ListaUsuarios;
            }
        }

        public bool BuscarUsuario(string usuario) //Metodo para validar si hay un nombre de usuario ya creado. 
        {
            ListaUsuarios = ValidarNullListaUsuarios();

            if (ListaUsuarios.FindAll(x => usuario == x.usuario).Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool BuscarUsuarioContraseña(string usuario, string contraseña)//Metodo para devolver un booleano si encuentra o no el usuario y contraseña del alumno.
        {
            ListaUsuarios = ValidarNullListaUsuarios();
            bool validador = false;
            foreach (var indice in ListaUsuarios)
            {
                if (indice.usuario == usuario && indice.contraseña == contraseña)
                {
                    return true;
                }
               
            }
            return validador;
        }
        public List<Usuario> GetListaUsuarios()
        {
            ListaUsuarios = ValidarNullListaUsuarios();
            return ListaUsuarios;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                                ////ABM ALUMNO  + BUSQUEDAS DE ALUMNOS.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaAlumno(Alumno nuevoAlumno) //Corregir usuario y contraseña, hecho solo de prueba. 
        {
            ListaAlumnos = ValidarNullListaAlumnos();

            Alumno alumnoNuevo = new Alumno();
            alumnoNuevo.idCurso = nuevoAlumno.idCurso;
            alumnoNuevo.matricula = devolverUltimoIdEliminado();
            alumnoNuevo.nombre = nuevoAlumno.nombre;
            alumnoNuevo.apellido = nuevoAlumno.apellido;
            alumnoNuevo.fechaNacimiento = nuevoAlumno.fechaNacimiento;
            alumnoNuevo.numeroDoc = nuevoAlumno.numeroDoc;
            alumnoNuevo.tipoDoc = nuevoAlumno.tipoDoc;
            alumnoNuevo.nroTelefono = nuevoAlumno.nroTelefono;
            alumnoNuevo.email = nuevoAlumno.email;
            alumnoNuevo.localidad = nuevoAlumno.localidad;
            alumnoNuevo.direccion = nuevoAlumno.direccion;
            alumnoNuevo.sexo = nuevoAlumno.sexo;
            alumnoNuevo.asignarEdad();

            if (alumnoNuevo.matricula == 0) { alumnoNuevo.matricula = ListaAlumnos.Count + 1; ListaAlumnos.Add(alumnoNuevo); } //validacion para no repetir ids eliminados.
            else { ListaAlumnos.Add(alumnoNuevo); }

            InstanciaPersistenciaDatos.GuardarArchivoAlumno(ListaAlumnos);
            //if (validarIdRepetidos(nuevoAlumno.matricula)) { nuevoAlumno.matricula = ListaAlumnos.Count + 1; ListaAlumnos.Add(nuevoAlumno); }
            //if (validarIdRepetidos(nuevoAlumno.matricula) == false) { ListaAlumnos.Insert(nuevoAlumno.matricula - 1, nuevoAlumno); } //VER
            //else {  ListaAlumnos.Add(nuevoAlumno); }

            //nuevoAlumno.setUsuario(usuario);
            //nuevoAlumno.setContraseña(contraseña);
        }

        public void EliminarAlumno(int idAlumno)
        {
            ListaIdEliminados = validarListaIdsEliminados(); //valida lista null de idsEliminados.

            ListaIdEliminados.Add(idAlumno);
            InstanciaPersistenciaDatos.GuardarArchivoAlumnosIdEliminados(ListaIdEliminados);

            var alumnoEliminado = ListaAlumnos.Find(x => idAlumno == x.matricula);
            ListaAlumnos.Remove(alumnoEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoAlumno(ListaAlumnos);
        }
        public void EliminarListaCompleta() //Simplemente para ahorrarme trabajo de eliminar uno por uno. 
        {
            ListaAlumnos.Clear();
            InstanciaPersistenciaDatos.GuardarArchivoAlumno(ListaAlumnos);
        }

        public void ModificarAlumno(Alumno alumnoNuevo, int matricula)
        {
            var alumnoModificado = ListaAlumnos.Find(x => matricula == x.matricula);
            int posicionAlumnoModificado = ListaAlumnos.IndexOf(alumnoModificado);
            //var alumnoModificado = ListaAlumnos.Find(indice => matricula == indice.matricula);
            alumnoModificado.idCurso = alumnoNuevo.idCurso;
            alumnoModificado.nombre = alumnoNuevo.nombre;
            alumnoModificado.apellido = alumnoNuevo.apellido;
            alumnoModificado.numeroDoc = alumnoNuevo.numeroDoc;
            alumnoModificado.fechaNacimiento = alumnoNuevo.fechaNacimiento;
            alumnoModificado.edad = alumnoNuevo.edad;
            alumnoModificado.nroTelefono = alumnoNuevo.nroTelefono;
            alumnoModificado.email = alumnoNuevo.email;
            alumnoModificado.localidad = alumnoNuevo.localidad;
            alumnoModificado.direccion = alumnoNuevo.direccion;
            alumnoModificado.matricula = matricula;
            alumnoModificado.tipoDoc = alumnoNuevo.tipoDoc;
            alumnoModificado.matAprobadas = alumnoNuevo.matAprobadas;
            //alumnoModificado.condicion = alumnoNuevo.condicion;
            alumnoModificado.matDesaprobadas = alumnoNuevo.matDesaprobadas;
            alumnoModificado.sexo = alumnoNuevo.sexo;
            alumnoModificado.asignarEdad();
            //alumnoModificado.cursoAlumno = alumnoNuevo.cursoAlumno;
            var alumnoEliminado = ListaAlumnos.Find(x => matricula == x.matricula);
            ListaAlumnos.Remove(alumnoEliminado);
            ListaAlumnos.Insert(posicionAlumnoModificado, alumnoModificado);

            InstanciaPersistenciaDatos.GuardarArchivoAlumno(ListaAlumnos);
        }

        /////////////////////////////BUSQUEDAS///////////////////////////////
        
        public List<Alumno> BuscarAlumnoPorNombre(string nombre)
        {
            ListaAlumnos = ValidarNullListaAlumnos();

            List<Alumno> listaFiltrada = new List<Alumno>();

            foreach(var alumno in ListaAlumnos)
            {
                if (alumno.nombre.Contains(nombre))
                {
                    listaFiltrada.Add(alumno);
                }
                
            }
            return listaFiltrada;
        }
        public List<Alumno> BuscarAlumnoPorMatricula(int id) //Busqueda alumnos por ID.
        {
            ListaAlumnos = ValidarNullListaAlumnos();
            List<Alumno> listaAlumnosEncontrados = new List<Alumno>();

            listaAlumnosEncontrados = ListaAlumnos.FindAll(x => id == x.matricula);

            return listaAlumnosEncontrados;

        }
        public bool validarNumeroDoc(string nroDocumento)
        {
            bool rta = false;
            if (BuscarAlumnoPorDNI(nroDocumento).Count == 0) { return rta; }
            else { return true; };
        }

        public List<Alumno> BuscarAlumnoPorDNI(string documento) //Busqueda alumnos por Documento.
        {
            ListaAlumnos = ValidarNullListaAlumnos();
            List<Alumno> listaAlumnosEncontrados = new List<Alumno>();

            listaAlumnosEncontrados = ListaAlumnos.FindAll(x => documento == x.numeroDoc);
            return listaAlumnosEncontrados;

        }
        public List<Alumno> getListaAlumnos() //Para devolver la lista ordenada por ids. 
        {
            ListaAlumnos = ValidarNullListaAlumnos();

            IEnumerable<Alumno> ListaAlumnosOrdenada = ListaAlumnos.OrderBy(x => x.matricula);
            ListaAlumnos = ListaAlumnosOrdenada.ToList();
            return ListaAlumnos;
        }
        public List<Alumno> FiltrarListaAlumnosPorNombre() //Para devolver la lista ordenada por nombre.
        {
            ListaAlumnos = ValidarNullListaAlumnos();
            ListaAlumnos = ListaAlumnos.OrderBy(x => x.nombre).ToList();

            return ListaAlumnos;
        }
        public List<Alumno> FiltrarListaAlumnosPorTipoDocumento() //Para devolver la lista ordenada por nombre.
        {
            ListaAlumnos = ValidarNullListaAlumnos();
            ListaAlumnos = ListaAlumnos.OrderBy(x => x.tipoDoc).ToList();

            return ListaAlumnos;
        }
        public List<Alumno> FiltrarListaAlumnosPorTipoDocumento(string tipoDoc) //Para devolver la lista ordenada por nombre.
        {
            ListaAlumnos = ValidarNullListaAlumnos();

            ListaAlumnos = ListaAlumnos.OrderBy(x => x.tipoDoc).ToList();
            ListaAlumnos = ListaAlumnos.FindAll(x => tipoDoc == x.tipoDoc);

            return ListaAlumnos;
        }
        public List<Alumno> FiltrarListaAlumnosPorLocalidad() //Para devolver la lista ordenada por nombre.
        {
            ListaAlumnos = ValidarNullListaAlumnos();
            ListaAlumnos = ListaAlumnos.OrderBy(x => x.localidad).ToList();

            return ListaAlumnos;
        }

        public List<int> validarListaIdsEliminados() //validacion de listaAlumnosIdEliminados null. 
        {
            if (ListaIdEliminados == null)
            {
                List<int> NuevaListaIdEliminados = new List<int>();
                return NuevaListaIdEliminados;
            }
            else { return ListaIdEliminados; }
        }
        public List<Alumno> ValidarNullListaAlumnos()
        {
            ListaAlumnos = InstanciaPersistenciaDatos.LeerArchivoAlumno();
            if (ListaAlumnos == null)
            {
                List<Alumno> nuevaListaAlumno = new List<Alumno>();
                return nuevaListaAlumno;
            }
            else
            {
                return ListaAlumnos;
            }
        }
        public int devolverUltimoIdEliminado() //Metodo para que me devuelva siempre el ultimo idEliminado de alumnos, si no hay me devuelve 0, si hay me trae el ultimo y lo elimina.
        {
            ListaIdEliminados = validarListaIdsEliminados();
            int idEliminado = 0;
            if (ListaIdEliminados.Count == 0)
            {
                return idEliminado;
            }
            else { idEliminado = ListaIdEliminados.Last(); ListaIdEliminados.Remove(idEliminado); }

            InstanciaPersistenciaDatos.GuardarArchivoAlumnosIdEliminados(ListaIdEliminados);
            return idEliminado;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                  /////ABM PRECEPTOR  
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaPreceptor(Preceptor preceptor)
        {
            ListaPreceptor = ValidarListaNullPreceptor();

            Preceptor nuevoPreceptor = new Preceptor();
            nuevoPreceptor.idPreceptor = DevolverUltimoIdEliminadoPreceptor();
            nuevoPreceptor.nombre = preceptor.nombre;
            nuevoPreceptor.apellido = preceptor.apellido;
            nuevoPreceptor.numeroDoc = preceptor.numeroDoc;
            nuevoPreceptor.tipoDoc = preceptor.tipoDoc;
            nuevoPreceptor.email = preceptor.email;
            nuevoPreceptor.nroTelefono = preceptor.nroTelefono;
            nuevoPreceptor.direccion = preceptor.direccion;
            nuevoPreceptor.localidad = preceptor.localidad;
            nuevoPreceptor.fechaNacimiento = preceptor.fechaNacimiento;
            nuevoPreceptor.sexo = preceptor.sexo;
            nuevoPreceptor.asignarEdad();
            nuevoPreceptor.fechaInicio = preceptor.fechaInicio; ;
            //nuevoPreceptor.cantCursos = preceptor.cantCursos; //NULL
            //nuevoPreceptor.asignarAntiguedad();

            if (nuevoPreceptor.idPreceptor == 0) { nuevoPreceptor.idPreceptor = ListaPreceptor.Count + 1; ListaPreceptor.Add(nuevoPreceptor); }
            else { ListaPreceptor.Add(nuevoPreceptor); }

            InstanciaPersistenciaDatos.GuardarArchivoPreceptor(ListaPreceptor);
        }

        public void EliminarPreceptor(int idPreceptor)
        {
            ListaIdEliminadosPreceptor = validarListaIdsEliminadosPreceptor();
            ListaIdEliminadosPreceptor.Add(idPreceptor);
            InstanciaPersistenciaDatos.GuardarArchivoPreceptoresIdEliminados(ListaIdEliminadosPreceptor);

            var preceptorEliminado = ListaPreceptor.Find(x => idPreceptor == x.idPreceptor);
            ListaPreceptor.Remove(preceptorEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoPreceptor(ListaPreceptor);
        }
        public void ModificarPreceptor(Preceptor preceptor, int idPreceptor)
        {
            //var preceptorModificado = ListaPreceptor.Find(x => idPreceptor == x.idPreceptor);
            var preceptorModificado = BuscarPreceptorPorId(idPreceptor);
            int posicionPreceptorModificado = ListaPreceptor.IndexOf(preceptorModificado);

            preceptorModificado.nombre = preceptor.nombre;
            preceptorModificado.apellido = preceptor.apellido;
            preceptorModificado.numeroDoc = preceptor.numeroDoc;
            preceptorModificado.tipoDoc = preceptor.tipoDoc;
            preceptorModificado.email = preceptor.email;
            preceptorModificado.nroTelefono = preceptor.nroTelefono;
            preceptorModificado.direccion = preceptor.direccion;
            preceptorModificado.localidad = preceptor.localidad;
            preceptorModificado.fechaNacimiento = preceptor.fechaNacimiento;
            preceptorModificado.sexo = preceptor.sexo;
            preceptorModificado.asignarEdad();
            preceptorModificado.fechaInicio = preceptor.fechaInicio;
            //preceptorModificado.cantCursos = preceptor.cantCursos; //NULL - Deberia modificarse automaticamente cuando asigno al curso un preceptor. 

            var preceptorEliminado = ListaPreceptor.Find(x => idPreceptor == x.idPreceptor);
            ListaPreceptor.Remove(preceptorEliminado);
            ListaPreceptor.Insert(posicionPreceptorModificado, preceptorModificado);

            InstanciaPersistenciaDatos.GuardarArchivoPreceptor(ListaPreceptor);
        }
        public List<Preceptor> ValidarListaNullPreceptor()
        {
            ListaPreceptor = InstanciaPersistenciaDatos.LeerArchivoPreceptor();
            if (ListaPreceptor == null)
            {
                List<Preceptor> nuevaListaPreceptor = new List<Preceptor>();
                //Preceptor preceptor = new Preceptor();
                //nuevaListaPreceptor.Add(preceptor);    
                return nuevaListaPreceptor;
            }
            else
            {
                return ListaPreceptor;
            }
        }
        public List<int> validarListaIdsEliminadosPreceptor() //validacion de listaPreceptoresIdEliminados null. 
        {
            if (ListaIdEliminadosPreceptor == null)
            {
                List<int> NuevaListaIdEliminados = new List<int>();
                return NuevaListaIdEliminados;
            }
            else { return ListaIdEliminados; }
        }
        public int DevolverUltimoIdEliminadoPreceptor() //Metodo para que me devuelva siempre el ultimo idEliminado , si no hay me devuelve 0.
        {
            int idEliminado = 0;
            if (ListaIdEliminadosPreceptor.Count == 0)
            {
                return idEliminado;
            }
            else { idEliminado = ListaIdEliminadosPreceptor.Last(); ListaIdEliminadosPreceptor.Remove(idEliminado); }
            InstanciaPersistenciaDatos.GuardarArchivoPreceptoresIdEliminados(ListaIdEliminadosPreceptor);
            return idEliminado;
        }
        public List<Preceptor> getListaPreceptor()
        {
            ListaPreceptor = ValidarListaNullPreceptor();

            IEnumerable<Preceptor> ListaPreceptorOrdenada = ListaPreceptor.OrderBy(x => x.idPreceptor);
            ListaPreceptor = ListaPreceptorOrdenada.ToList();
            return ListaPreceptor;
        }

        public List<Preceptor> BuscarListaPreceptorPorId(int idPreceptor)
        {
            List<Preceptor> listaPreceptorEncontrada = new List<Preceptor>();
            var preceptor = ListaPreceptor.Find(x => idPreceptor == x.idPreceptor);
            listaPreceptorEncontrada.Add(preceptor);
            return listaPreceptorEncontrada;
        }
        public Preceptor BuscarPreceptorPorId(int idPreceptor)
        {
            var preceptor = ListaPreceptor.Find(x => idPreceptor == x.idPreceptor);
            return preceptor;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                       ///ABM CURSOS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaCurso(Curso cursoNuevo) //(Preceptor preceptor)
        {
            ListaCursos = ValidarNullListaCursos();

            Curso nuevoCurso = new Curso();
            nuevoCurso.idCurso = devolverUltimoIdEliminadoCursos();
            nuevoCurso.año = cursoNuevo.año;
            nuevoCurso.division = cursoNuevo.division;
            nuevoCurso.nombreCurso = cursoNuevo.nombreCurso;
            nuevoCurso.cantAlumnos = cursoNuevo.cantAlumnos;
            nuevoCurso.descripcion = cursoNuevo.descripcion;
            //nuevoCurso.preceptorCurso = preceptor;
            //nuevoCurso.setIdPreceptor(preceptor.idPreceptor);

            if (nuevoCurso.idCurso == 0) { nuevoCurso.idCurso = ListaCursos.Count + 1; ListaCursos.Add(nuevoCurso); }
            else { ListaCursos.Add(nuevoCurso); }

            InstanciaPersistenciaDatos.GuardarArchivoCurso(ListaCursos);

        }

        public void ModificarCurso(Curso curso, int idCurso)
        {
            var cursoModificado = ListaCursos.Find(x => idCurso == x.idCurso);
            int posicionCursoModificado = ListaCursos.IndexOf(cursoModificado);

            cursoModificado.año = curso.año;
            cursoModificado.division = curso.division;
            cursoModificado.nombreCurso = curso.nombreCurso;
            cursoModificado.cantAlumnos = curso.cantAlumnos;
            cursoModificado.descripcion = curso.descripcion;
            //cursoModificado.preceptorCurso = curso.preceptorCurso;

            var cursoEliminado = ListaCursos.Find(x => idCurso == x.idCurso);
            ListaCursos.Remove(cursoEliminado);
            ListaCursos.Insert(posicionCursoModificado, cursoModificado);

            InstanciaPersistenciaDatos.GuardarArchivoCurso(ListaCursos);
        }
        public void EliminarCurso(int idCurso)
        {
            ListaIdEliminadosCursos = validarListaIdsEliminadosCursos();
            ListaIdEliminadosCursos.Add(idCurso);
            InstanciaPersistenciaDatos.GuardarArchivoCursosIdEliminados(ListaIdEliminadosCursos);

            var cursoEliminado = ListaCursos.Find(x => idCurso == x.idCurso);
            ListaCursos.Remove(cursoEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoCurso(ListaCursos);
        }
        public List<Curso> ValidarNullListaCursos()
        {
            ListaCursos = InstanciaPersistenciaDatos.LeerArchivoCurso();
            if (ListaCursos == null)
            {
                List<Curso> nuevaListaCursos = new List<Curso>();
                return nuevaListaCursos;
            }
            else
            {
                return ListaCursos;
            }
        }
        public List<int> validarListaIdsEliminadosCursos() //validacion de listaCursosIdEliminados null. 
        {
            if (ListaIdEliminadosCursos == null)
            {
                List<int> nuevaListaIdEliminadosCursos = new List<int>();
                return nuevaListaIdEliminadosCursos;
            }
            else { return ListaIdEliminadosCursos; }
        }
        public int devolverUltimoIdEliminadoCursos() //metodo para que me devuelva siempre el ultimo idEliminado, si no hay me devuelve 0.
        {
            int idEliminado = 0;
            if (ListaIdEliminadosCursos.Count == 0)
            {
                return idEliminado;
            }
            else { idEliminado = ListaIdEliminadosCursos.Last(); ListaIdEliminadosCursos.Remove(idEliminado); }
            InstanciaPersistenciaDatos.GuardarArchivoCursosIdEliminados(ListaIdEliminadosCursos);
            return idEliminado;
        }

        public List<Curso> getListaCursos()
        {
            ListaCursos = ValidarNullListaCursos();

            IEnumerable<Curso> ListaCursosOrdenada = ListaCursos.OrderBy(x => x.idCurso);
            ListaCursos = ListaCursosOrdenada.ToList();
            return ListaCursos;
        }
        ////////////BUSQUEDAS//////////
        public Curso BuscarCursoPorAñoyDivision(string año, string division)
        {
            ListaCursos = ValidarNullListaCursos();

            List<Curso> listaCursosEncontradas = new List<Curso>();
            listaCursosEncontradas = ListaCursos.FindAll(x => año == x.año);
            var cursoEncontrado = listaCursosEncontradas.Find(x => division == x.division);
            return cursoEncontrado;
            //if(cursoEncontrado == null)
            //{
            //    return null;
            //}
            //else
            //{
            //    return cursoEncontrado;
            //}

        }
        public List<Curso> BuscarCursoPorId(int idCurso)
        {
            ListaCursos = ValidarNullListaCursos();

            List<Curso> listaCursosEncontradas = new List<Curso>();
            listaCursosEncontradas = ListaCursos.FindAll(x => idCurso == x.idCurso);
            //var curso = ListaCursos.FindAll(x => idCurso == x.idCurso);
            //listaCursosEncontradas.Add(curso);
            return listaCursosEncontradas;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                      //ABM MATERIAS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaMateria(Materia materia)
        {
            ListaMaterias = ValidarNullListaMaterias();
            Materia nuevaMateria = new Materia();
            nuevaMateria.idMateria = ListaMaterias.Count + 1;
            nuevaMateria.nombre = materia.nombre;
            nuevaMateria.nivel = materia.nivel;
            nuevaMateria.cargaHoraria = materia.cargaHoraria;
            nuevaMateria.alumnosPresentes = validarNull(materia.alumnosPresentes);
            //nuevaMateria.alumnosRegistrados = validarNull(materia.alumnosPresentes);

            ListaMaterias.Add(nuevaMateria);
            InstanciaPersistenciaDatos.GuardarArchivoMateria(ListaMaterias);
        }

        public void EliminarMateria(int idMateria)
        {
            var materiaEliminada = ListaMaterias.Find(x => idMateria == x.idMateria);
            ListaMaterias.Remove(materiaEliminada);

            InstanciaPersistenciaDatos.GuardarArchivoMateria(ListaMaterias);
        }
        public void ModificarMateria(Materia materia, int idMateria)
        {
            var materiaModificada = ListaMaterias.Find(x => idMateria == x.idMateria);
            int posicionMateriaModificada = ListaMaterias.IndexOf(materiaModificada);

            materiaModificada.nombre = materia.nombre;
            materiaModificada.nivel = materia.nivel;
            materiaModificada.cargaHoraria = materia.cargaHoraria;
            materiaModificada.alumnosPresentes = materia.alumnosPresentes;
            //materiaModificada.profesor = materia.profesor;
            //materiaModificada.alumnosRegistrados = materia.alumnosRegistrados;

            var materiaEliminada = ListaMaterias.Find(x => idMateria == x.idMateria);
            ListaMaterias.Remove(materiaEliminada);
            ListaMaterias.Insert(posicionMateriaModificada, materiaModificada);

            InstanciaPersistenciaDatos.GuardarArchivoMateria(ListaMaterias);
        }
        public string validarNull(string var)
        {
            if (var == null)
            {
                return var = "0";
            }
            return var;
        }


        ////BUSQUEDAS
        public List<Materia> BuscarMateriaPorId(int idMateria)
        {
            List<Materia> listaMateriasEncontradas = new List<Materia>();
            var materia = ListaMaterias.Find(x => idMateria == x.idMateria);
            listaMateriasEncontradas.Add(materia);

            return listaMateriasEncontradas;
        }

        public List<Materia> BuscarMateriaPorNombre(string nombre)
        {
            List<Materia> listaMateriasEncontradas = new List<Materia>();
            listaMateriasEncontradas = ListaMaterias.FindAll(x => nombre == x.nombre);

            return listaMateriasEncontradas;
        }

        public List<Materia> getListaMaterias() //Para devolver la lista ordenada por ids. 
        {
            ListaMaterias = ValidarNullListaMaterias();

            IEnumerable<Materia> ListaMateriasOrdenada = ListaMaterias.OrderBy(x => x.idMateria);
            ListaMaterias = ListaMateriasOrdenada.ToList();
            return ListaMaterias;
        }
        public List<Materia> ValidarNullListaMaterias()
        {
            ListaMaterias = InstanciaPersistenciaDatos.LeerArchivoMateria();
            if (ListaMaterias == null)
            {
                List<Materia> nuevaListaMateria = new List<Materia>();
                return nuevaListaMateria;
            }
            else
            {
                return ListaMaterias;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                  ////ABM PROFESOR  
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaProfesor(Profesor profesor)
        {
            ListaProfesor = ValidarListaNullProfesor();

            Profesor nuevoProfesor = new Profesor();

            nuevoProfesor.nroLegajo = ListaProfesor.Count + 1;
            nuevoProfesor.nombre = profesor.nombre;
            nuevoProfesor.apellido = profesor.apellido;
            nuevoProfesor.numeroDoc = profesor.numeroDoc;
            nuevoProfesor.tipoDoc = profesor.tipoDoc;
            nuevoProfesor.email = profesor.email;
            nuevoProfesor.nroTelefono = profesor.nroTelefono;
            nuevoProfesor.direccion = profesor.direccion;
            nuevoProfesor.localidad = profesor.localidad;
            nuevoProfesor.fechaNacimiento = profesor.fechaNacimiento;
            nuevoProfesor.sexo = profesor.sexo;

            nuevoProfesor.nivel = profesor.nivel;
            nuevoProfesor.especializacion = profesor.especializacion;
            nuevoProfesor.fechaInicio = profesor.fechaInicio;
            nuevoProfesor.reemplazante = profesor.reemplazante;

            ListaProfesor.Add(nuevoProfesor);
            InstanciaPersistenciaDatos.GuardarArchivoProfesor(ListaProfesor);

        }
        public void ModificarProfesor(Profesor profesor, int nroLegajoProfesor)
        {
            var profesorModificado = ListaProfesor.Find(x => nroLegajoProfesor == x.nroLegajo);
            int posicionProfesorModificado = ListaProfesor.IndexOf(profesorModificado);

            profesorModificado.nombre = profesor.nombre;
            profesorModificado.apellido = profesor.apellido;
            profesorModificado.numeroDoc = profesor.numeroDoc;
            profesorModificado.tipoDoc = profesor.tipoDoc;
            profesorModificado.fechaNacimiento = profesor.fechaNacimiento;
            profesorModificado.nroTelefono = profesor.nroTelefono;
            profesorModificado.email = profesor.email;
            profesorModificado.localidad = profesor.localidad;
            profesorModificado.direccion = profesor.direccion;

            profesorModificado.nivel = profesor.nivel;
            profesorModificado.fechaInicio = profesor.fechaInicio;
            profesorModificado.especializacion = profesor.especializacion;
            profesorModificado.reemplazante = profesor.reemplazante;
            profesorModificado.asignarEdad();

            var profesorEliminado = ListaProfesor.Find(x => nroLegajoProfesor == x.nroLegajo);
            ListaProfesor.Remove(profesorEliminado);
            ListaProfesor.Insert(posicionProfesorModificado, profesorModificado);

            InstanciaPersistenciaDatos.GuardarArchivoProfesor(ListaProfesor);
        }
        public void EliminarProfesor(int nroLegajo)
        {
            var profesorEliminado = ListaProfesor.Find(x => nroLegajo == x.nroLegajo);
            ListaProfesor.Remove(profesorEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoProfesor(ListaProfesor);
        }
        public List<Profesor> ValidarListaNullProfesor()
        {
            ListaProfesor = InstanciaPersistenciaDatos.LeerArchivoProfesor();
            if (ListaProfesor == null)
            {
                List<Profesor> nuevaListaProfesor = new List<Profesor>();

                return nuevaListaProfesor;
            }
            else
            {
                return ListaProfesor;
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                            //ABM EXAMEN  
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaExamen(Examen examen, Materia materiaAsignada, Curso curso)
        {
            //como le asgino el examen a la materia que quiero?
            Examen nuevoExamen = new Examen();
            nuevoExamen.materia = materiaAsignada;
            nuevoExamen.curso = curso;
            nuevoExamen.idExamen = ListaExamenes.Count + 1;
            nuevoExamen.titulo = examen.titulo;
            nuevoExamen.temas = examen.temas;
            nuevoExamen.instancia = examen.instancia;
            nuevoExamen.fechaHora = examen.fechaHora;
            nuevoExamen.desarrollo = examen.desarrollo;
            nuevoExamen.periodo = examen.periodo;
            ListaExamenes.Add(nuevoExamen);

            InstanciaPersistenciaDatos.GuardarArchivoExamen(ListaExamenes);

        }
        public void EliminarExamen(int idExamen)
        {
            var examenEliminado = ListaExamenes.Find(x => idExamen == x.idExamen);
            ListaExamenes.Remove(examenEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoExamen(ListaExamenes);
        }
        public void ModificarExamen(Examen examenNuevo, int Cod)
        {
            var examenModificado = ListaExamenes.Find(x => Cod == x.idExamen);
            int posicionExamenModificado = ListaExamenes.IndexOf(examenModificado);

            examenModificado.materia = examenNuevo.materia;
            examenModificado.curso = examenNuevo.curso;
            examenModificado.titulo = examenNuevo.titulo;
            examenModificado.temas = examenNuevo.temas;
            examenModificado.instancia = examenNuevo.instancia;
            examenModificado.fechaHora = examenNuevo.fechaHora;
            examenModificado.desarrollo = examenNuevo.desarrollo;
            examenModificado.periodo = examenNuevo.periodo;

            var examenEliminado = ListaExamenes.Find(x => Cod == x.idExamen);
            ListaExamenes.Remove(examenEliminado);
            ListaExamenes.Insert(posicionExamenModificado, examenModificado);

            InstanciaPersistenciaDatos.GuardarArchivoExamen(ListaExamenes);
        }



        ///////BUSQUEDAS
        public List<Examen> BuscarExamenPorId(int idExamen)
        {
            List<Examen> listaExamenesEncontrados = new List<Examen>();
            var examen = ListaExamenes.Find(x => idExamen == x.idExamen);
            listaExamenesEncontrados.Add(examen);

            return listaExamenesEncontrados;

        }
        public List<Examen> buscarExamenPorMateria(Materia materia)
        {
            List<Examen> listaExamenesEncontrados = new List<Examen>();

            listaExamenesEncontrados = ListaExamenes.FindAll(x => materia == x.materia);

            return listaExamenesEncontrados;

        }
        public List<Examen> buscarExamenPorCurso(Curso curso)
        {
            List<Examen> listaExamenesEncontrados = new List<Examen>();

            listaExamenesEncontrados = ListaExamenes.FindAll(x => curso == x.curso);

            return listaExamenesEncontrados;

        }
        public List<Examen> buscarExamenPorFecha(DateTime fecha)
        {
            List<Examen> listaExamenesEncontrados = new List<Examen>();

            listaExamenesEncontrados = ListaExamenes.FindAll(x => fecha == x.fechaHora);

            return listaExamenesEncontrados;
        }
        public List<Examen> getListaExamenes() //Para devolver la lista ordenada por ids. 
        {
            IEnumerable<Examen> listaExamenesOrdenada = ListaExamenes.OrderBy(x => x.idExamen);
            ListaExamenes = listaExamenesOrdenada.ToList();
            return ListaExamenes;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                               ///ASIGNACIONES MUCHOS A MUCHOS. CLASES AUXILIARES. 
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 
        public void AsignarCursoMateria(Materia materia, Curso curso)
        {
            ListaCursosMaterias = ValidarListaNullCursoMateria();

            cursoMateria nuevoCursoMateria = new cursoMateria();
            nuevoCursoMateria.idCursoMateria = DevolverUltimoIdEliminadoCursoMateria();
            nuevoCursoMateria.curso = curso;
            nuevoCursoMateria.idCurso = curso.idCurso;
            nuevoCursoMateria.materia = materia;
            nuevoCursoMateria.idMateria = materia.idMateria;
            nuevoCursoMateria.nombreMateria = materia.nombre;

            if (nuevoCursoMateria.idCursoMateria == 0) { nuevoCursoMateria.idCursoMateria = ListaCursosMaterias.Count + 1; ListaCursosMaterias.Add(nuevoCursoMateria); }
            else { ListaCursosMaterias.Add(nuevoCursoMateria); }

            InstanciaPersistenciaDatos.GuardarArchivoCursoMateria(ListaCursosMaterias);
        }
        public void QuitarCursoMateria(int idCursoMateria) 
        {
            ListaIdEliminadosCursosMaterias = ValidarListaIdsEliminadosCursoMateria();
            ListaIdEliminadosCursosMaterias.Add(idCursoMateria);
            InstanciaPersistenciaDatos.GuardarArchivoCursoMateriaIdEliminados(ListaIdEliminadosCursosMaterias);

            var cursoMateriaEliminado = ListaCursosMaterias.Find(x => idCursoMateria == x.idCursoMateria);
            ListaCursosMaterias.Remove(cursoMateriaEliminado);

            InstanciaPersistenciaDatos.GuardarArchivoCursoMateria(ListaCursosMaterias);
        }
        public List<cursoMateria> BuscarCursoMateria(int idCurso, int idMateria)
        {
            ListaCursosMaterias = ValidarListaNullCursoMateria();
            List<cursoMateria> listaCursosMateriasEncontrados = new List<cursoMateria>();

            listaCursosMateriasEncontrados = ListaCursosMaterias.FindAll(x => idMateria == x.idMateria);
            listaCursosMateriasEncontrados.FindAll(x => idCurso == x.idCurso);

            return listaCursosMateriasEncontrados;
        }
        public List<int> ValidarListaIdsEliminadosCursoMateria() 
        {
            if (ListaIdEliminadosCursosMaterias == null)
            {
                List<int> nuevaListaIdEliminadosCursosMaterias = new List<int>();
                return nuevaListaIdEliminadosCursosMaterias;
            }
            else { return ListaIdEliminadosCursosMaterias; }
        }
        public int DevolverUltimoIdEliminadoCursoMateria() 
        {
            ListaIdEliminadosCursosMaterias = ValidarListaIdsEliminadosCursoMateria();
            int idEliminado = 0;
            if (ListaIdEliminadosCursosMaterias.Count == 0)
            {
                return idEliminado;
            }
            else { idEliminado = ListaIdEliminadosCursosMaterias.Last(); ListaIdEliminadosCursosMaterias.Remove(idEliminado); }

            InstanciaPersistenciaDatos.GuardarArchivoCursoMateriaIdEliminados(ListaIdEliminadosCursosMaterias);
            return idEliminado;
        }
        public List<cursoMateria> ValidarListaNullCursoMateria() 
        {
            ListaCursosMaterias = InstanciaPersistenciaDatos.LeerArchivoCursoMaterias();
            if(ListaCursosMaterias == null)
            {
                List<cursoMateria> nuevaListaCursoMateria = new List<cursoMateria>();
                return nuevaListaCursoMateria;
            }
            else
            {
                return ListaCursosMaterias;
            }
        }
        public List<cursoMateria> GetListaCursoMaterias(int idCurso)
        {
            ListaCursosMaterias = ValidarListaNullCursoMateria();

            List<cursoMateria> listaCursosMateriasEncontrados = new List<cursoMateria>();
            listaCursosMateriasEncontrados = ListaCursosMaterias.FindAll(x => idCurso == x.idCurso);

            IEnumerable<cursoMateria> ListaCursoMateriasOrdenada = listaCursosMateriasEncontrados.OrderBy(x => x.idCursoMateria);
            listaCursosMateriasEncontrados = ListaCursoMateriasOrdenada.ToList();

            return listaCursosMateriasEncontrados;

        }



        public void AsignarProfesorMateria(Materia materia, Profesor profesorAsignado)
        {
            profesorMateria profesorMateria = new profesorMateria();

            profesorMateria.IdProfesorMateria = ListaProfesorMaterias.Count + 1;
            profesorMateria.CodMateria = materia.idMateria;
            profesorMateria.materia = materia;
            profesorMateria.nroLegajoProfesor = profesorAsignado.nroLegajo;
            profesorMateria.profesor = profesorAsignado;

            ListaProfesorMaterias.Add(profesorMateria);
            InstanciaPersistenciaDatos.GuardarArchivoProfesorMateria(ListaProfesorMaterias);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //HISTORIAL DE HORARIO MATERIAS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //HISTORIAL DE INASISTENCIAS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///ABM AULAS
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaAula()
        {

        }
    }
}
