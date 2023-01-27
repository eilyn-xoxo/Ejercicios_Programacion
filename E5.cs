using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio de los numeros");
            int[] numeros = new int[10] ;
            int sumaTotal = 0;

            for (int i = 0; i < 10; i++)
            {
                sumaTotal = sumaTotal + numeros[i];
            }

            int promedio = sumaTotal / 10;

            Console.WriteLine($"El promedio de los numeros es {promedio}");
        }
    }
}
        }
    }
}
