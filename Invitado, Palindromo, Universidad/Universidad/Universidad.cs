using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Universidad
    {
        //private List<Curso> listaDeCursos;
        private Curso curso;
        
        public void crearCurso(string nombreCurso, int numeroAula) {

            curso = new Curso(nombreCurso, numeroAula);
                    
        }

        public void getInfoCurso()
        {

            Console.WriteLine("Materia: {0} Aula: {1}\nProfesor: {2} {3} - Legajo: {4}\n ----Alumnos----\n", 
                curso.getMateria(), curso.getNumeroAula(), curso.getNombreProfesor(), curso.getApellidoProfesor(), curso.getLegajoProfesor());
            curso.getLista();
        }
        public void asignarProfACurso(string nombrePr, string apellidoPr, int legajoPr) {

            curso.asignarProfesorACurso(nombrePr, apellidoPr, legajoPr);
        
        }
        public void asignarAlumnoACurso(Alumno alu){

            curso.agregarAlumno(alu);
        }
    }
}
