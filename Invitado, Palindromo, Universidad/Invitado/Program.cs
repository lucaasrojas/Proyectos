using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declarar una clase que posea tres propiedades de tipo 'private'. 
             * Declarar los métodos necesarios para definir su valor y leerlos luego.
             * Hacer un programa que pida al usuario el valor de las propiedades definidas, 
             * las guarde en la instancia y luego las muestre por pantalla en un mensaje de una sola linea
             */

            Invitado invitado = new Invitado();

            Console.WriteLine("Nombre: ");
            invitado.setNombre(Console.ReadLine());
            Console.WriteLine("Apellido: ");
            invitado.setApellido(Console.ReadLine());
            Console.WriteLine("Numero de Mesa: ");
            invitado.setMesa(int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Invitado: "+ invitado.getNombre() + " " + invitado.getApellido() + 
                " tiene asiganda la mesa numero " + invitado.getMesa());

            Console.ReadLine();


        }
    }
}
