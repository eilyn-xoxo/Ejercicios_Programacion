using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("En esta pantalla vamos a leer 10 numeros y determinar en que posicion esta en mayor {0}");

            int[] numeros = new int[10];

            for (int x = 0; x < numeros.Length; x++) {


                numeros[x] = 0;
                Console.WriteLine(" Digite los numeros", x);

                int.TryParse(Console.ReadLine(), out numeros[x]);


            }

            int numayor = 0;
            int posicion = 0 ;

            for (int x = 0; x< numeros.Length; x++) {

                if (numeros[x] > numayor){
                    numayor = numeros[x];
                    posicion = x;

                }
            
            }
            Console.WriteLine("El numero mayor es {0} y esta en la posicion {1}: ", numayor, posicion);
            Console.ReadLine();
        }

    }
}
