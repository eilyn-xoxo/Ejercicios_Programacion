using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            int suma;
            int digito1, digito2;

            Console.WriteLine("Introduzca un numero entero de dos digitos: ");
            entrada= int.Parse(Console.ReadLine());

            digito1 = entrada % 10;
            entrada = entrada / 10;

            digito2= entrada % 10;
            entrada= entrada / 10;

            suma = digito1 + digito2;

            Console.WriteLine("La suma de los digitos del numero introducido es: " + suma);

            Console.ReadLine();


            }


        }


    }
    

