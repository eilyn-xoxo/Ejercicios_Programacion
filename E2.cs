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
            Console.WriteLine("Determinar el mayor numero");
                int[] numeros = new int[10] { 87, 54, 8, 0, 56, 76, 8, 9, 2, 3 };
                int valorMax = numeros[0];
                int posicion = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] % 2 == 0)
                    {
                        if (numeros[i] > valorMax || valorMax % 2 == 1)
                        {
                            valorMax = numeros[i];
                            posicion = i;
                        }
                    }
                }
                Console.WriteLine($"El valor par mayor se encuentra en la posicion {posicion}");
            }
        }
    }
}
    }
}
