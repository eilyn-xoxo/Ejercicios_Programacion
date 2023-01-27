using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10] ;

            int negativos = 0;

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] < 0)
                {

                    negativos = negativos + 1;
                }
            }
            Console.WriteLine($"En el arreglo {negativos} numeros negativos");

        }
    }
}
        }
    }
}
