using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Alumno
    {

        private string nombre;
        private string apellido;
        private int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public int getLegajo()
        {
            return this.legajo;
        }

        public void getInfoAlumno() {

            Console.WriteLine("Nombre: {0} {1} -- Legajo: {2}", this.nombre, this.apellido, this.legajo);
        } 
    }
}
