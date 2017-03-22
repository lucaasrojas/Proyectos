using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Curso
    {

       
        private Profesor profesorDelCurso;
        private string materia;
        private int numAula;

        List<Alumno> listaDeAlumnos = new List<Alumno>();
        

        public Curso(string materia, int numAula)
        {
            this.materia = materia;
            this.numAula = numAula;
        }

        public string getMateria()
        {
            return this.materia;
        }
        public int getNumeroAula()
        {
            return this.numAula;
        }

        public void asignarProfesorACurso(string nombreP, string apellidoP, int legajoP) {
        
            profesorDelCurso = new Profesor(nombreP, apellidoP, legajoP);
            
        }
        public string getNombreProfesor() {

            return profesorDelCurso.getNombre();
        }
        public string getApellidoProfesor()
        {

            return profesorDelCurso.getApellido();
        }
        public int getLegajoProfesor()
        {

            return profesorDelCurso.getLegajo();
        }
       public void getLista()
        {

            foreach (Alumno  item in listaDeAlumnos)
            {
              Console.WriteLine(item.getNombre()+" "+item.getApellido()+" -- Legajo:"+item.getLegajo());
            }
        }
       
        public void agregarAlumno(Alumno alu) {

            listaDeAlumnos.Add(alu);
        }
    }
}
