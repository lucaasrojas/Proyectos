using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Palindromo
    {
        private string palabra;
        private int inicioPalabra = 0;
        private int finalPalabra = 0;
        private bool verificar = false;
        private string palabraInvertida;

        public Palindromo(string palabra){

            this.palabra = palabra.Replace(" ", "");
            

        }
        
        public bool verificarSiEsPalindromo()
        {
            finalPalabra = palabra.Length - 1;

            while( (inicioPalabra < finalPalabra) && (!verificar) ){

                if (palabra[inicioPalabra] == palabra[finalPalabra])
                {
                    inicioPalabra++;
                    finalPalabra--;
                }
                else
                {
                    verificar = true;
                }
            }
            return verificar;
            }
        }
    }

