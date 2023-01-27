using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10] { 34, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
            int valorMax = arreglo[0];
            int posicion = -1;
            int primo = 0;

            for (int i = 0; i < 10; i++)
            {
                if (primo(arreglo[i]))
                {
                    if (arreglo[i] > valorMax || !primo(valorMax))
                    {
                        valorMax = arreglo[i];
                        posicion = i;
                    }
                }
            }
            if (posicion == -1)
            {
                Console.WriteLine("No existen numeros primos en el listado");
            }
            else
            {
                Console.WriteLine($"El numero primo mayor se encuentra en la posicion {posicion}");
            }
        }
    }
    }
}
