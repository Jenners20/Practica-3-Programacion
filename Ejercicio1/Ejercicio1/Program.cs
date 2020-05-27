using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un numero entero y diga si es par.

            int num = 0;
            double divisor = 0;

            Console.Write("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            divisor = num % 2;

            if (divisor==0)
            {
                Console.WriteLine("El numero ingresado {0} es par ",num);
            }
            else
            {
                Console.WriteLine("El numero ingresado {0} no es par ",num);
            }
            Console.ReadKey();
        }
    }
}
