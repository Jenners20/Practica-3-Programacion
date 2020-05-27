using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que pida al usuario 2 numeros enteros
             * y le diga al usuario si el primero es multiplo del segundo*/

            int[] numero;
            numero = new int[2];
            double multiplo = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese un numero entero: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            multiplo = numero[0] % numero[1];

            Console.WriteLine();

            if (multiplo == 0)
            {
                Console.WriteLine("El numero {0} y el numero {1} son multiplos ", numero[0], numero[1]);
            }
            else Console.WriteLine("El numero {0} y el numero {1} no son multiplos ", numero[0], numero[1]);

            Console.ReadKey();

        }
    }
}
