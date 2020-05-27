using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario
             * un número entero y diga si es múltiplo de 4 o de 5. */
            int numero = 0;
            double multiplo;

            Console.Write("Ingrese un numero entero: ");
            numero = int.Parse(Console.ReadLine());

            multiplo = numero % 4;

            if (multiplo==0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero {0} es multiplo de 4 ",numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es multiplo de 4 ", numero);
            }

            multiplo = numero % 5;

            if (multiplo == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero {0} es multiplo de 5 ",numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es multiplo de 5 ",numero);
            }
            Console.ReadKey();
        }
    }
}
