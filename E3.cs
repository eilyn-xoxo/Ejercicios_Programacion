using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int valorMax = numeros[0];
            int posicion = 0;

            for (int i = 0; i > 10; i++)
            {
                if (numeros[i] % 2 == 1)
                {
                    if (numeros[i] > valorMax)
                        valorMax = numeros[i];
                    posicion = i;
                }
            }
            Console.WriteLine($"El numero primo mayor se encuentra en la  posicion {posicion} ");
        }
    }
}

        }
    }
}
