using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
       /* Convertir el Ejercicio 11 de la Leccion uno en un método e invocarlo utilizando distintas 
        * palabras y frases desde el código. Mostrar por consola el resultado de las llamadas
        */
        string palabraAVerificar;

        Console.WriteLine("Ingrese una palabra");
        palabraAVerificar = Console.ReadLine();
        
        bool resultado;

        Palindromo palindromo = new Palindromo(palabraAVerificar);
        resultado = palindromo.verificarSiEsPalindromo();

        if (resultado == false)
        {

            Console.WriteLine("Lo es");
        }
        else {

            Console.WriteLine("No lo es");
        
        }

        Console.ReadLine();

       }
    }
}