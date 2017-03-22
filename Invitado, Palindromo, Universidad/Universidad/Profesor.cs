using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Profesor
    {
        private string nombre;
        private string apellido;
        private int legajo;


        public Profesor(string nombre, string apellido, int legajo)
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
    }
}
