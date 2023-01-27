using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            int posicion = 0;


            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] >= 1000)
                {
                    posicion = i;
                    Console.WriteLine($"En esta posicion hay un valor mayor de tres digitos en la posicion {posicion}");
                }
    }
}
