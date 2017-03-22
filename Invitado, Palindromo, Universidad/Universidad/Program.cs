using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
           
          /*  Analize el objeto Universidad. Piense en caracteristicas y acciones que se le puedan atribuir al mismo. 
           * En base a lo analizado, modele la clase que lo representa con sus atributos y métodos correspondientes.
            */

            /* Universidad (aulas)
             *         Aulas (materias)
             *              Materias (profesor, alumnos)
             *                  Profesor(nombre, apellido, legajo)
             *                  Alumnos (nombre, apellido, legajo)
             *                  
            */

            string nombreCurso;
            int numeroDeAulaDelCurso;
            string nombreProfDeCurso;
            string apellidoProfDeCurso;
            int legajoProfDeCurso;
            string nombreA;
            string apellidoA;
            int legajoA;
            char otroAlumno;

            Console.WriteLine("Nombre del curso: ");
            nombreCurso = Console.ReadLine();
            
            Console.WriteLine("Numero de aula del curso: ");
            numeroDeAulaDelCurso = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nombre del Profesor: ");
            nombreProfDeCurso = Console.ReadLine();
            
            Console.WriteLine("Apellido del Profesor: ");
            apellidoProfDeCurso = Console.ReadLine();
            
            Console.WriteLine("Legajo del Profesor: ");
            legajoProfDeCurso = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Nombre de Alumno: ");
            nombreA = Console.ReadLine();
            
            Console.WriteLine("Apellido de Alumno: ");
            apellidoA = Console.ReadLine();
            
            Console.WriteLine("Legajo del Alumno: ");
            legajoA = int.Parse(Console.ReadLine());

            Universidad universidad = new Universidad();
            universidad.crearCurso(nombreCurso, numeroDeAulaDelCurso);
            universidad.asignarProfACurso(nombreProfDeCurso, apellidoProfDeCurso, legajoProfDeCurso);

            universidad.asignarAlumnoACurso(new Alumno(nombreA, apellidoA, legajoA));

            Console.WriteLine("Desea ingresar otro alumno? (S/N)): ");
            otroAlumno = char.Parse(Console.ReadLine().ToLower());

            while(otroAlumno != 'n'){
                    Console.WriteLine("Nombre de Alumno: ");
                    nombreA = Console.ReadLine();

                    Console.WriteLine("Apellido de Alumno: ");
                    apellidoA = Console.ReadLine();

                    Console.WriteLine("Legajo del Alumno: ");
                    legajoA = int.Parse(Console.ReadLine());

                    universidad.asignarAlumnoACurso(new Alumno(nombreA, apellidoA, legajoA));

                    Console.WriteLine("Desea ingresar otro alumno? (S/N)): ");
                    otroAlumno = char.Parse(Console.ReadLine().ToLower());
                    
            } 
            Console.WriteLine("----- Informacion del Curso -----");
            universidad.getInfoCurso();
            
            Console.ReadLine();
            
        }



    }
}
