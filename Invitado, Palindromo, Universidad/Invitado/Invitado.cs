using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Invitado
    {
        private string nombre;
        private string apellido;
        private int mesa;

        public void setNombre(string nombre) {

            this.nombre = nombre;
        }

        public void setApellido(string apellido) {

            this.apellido = apellido;
        }

        public void setMesa(int mesa) {

            this.mesa = mesa;
        
        }

        public string getNombre() {

            return this.nombre; 
        
        }

        public string getApellido()
        {

            return this.apellido;

        }

        public int getMesa() {

            return this.mesa;
        }


    }
}
