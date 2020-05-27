using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario un número entero.
             * Si es múltiplo de 10, se lo avisará al usuario y pedirá un 
             * segundo número, para decir a continuación si este segundo 
             * número también es múltiplo de 10. */

            int[] numeros;
            numeros = new int[2];
            double multiplo = 0;

            Console.Write("Ingrese un numero entero: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            multiplo = numeros[0] % 10;

            if(multiplo==0)
            {

               Console.WriteLine("El numero {0} es multiplo de 10 ", numeros[0]);
                Console.WriteLine();

                Console.Write("Ingrese un segundo numero entero ");
                numeros[1] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                multiplo = numeros[1] % 10;

                if (multiplo==0)
                {
                    Console.WriteLine("El segundo numero {0} tambien es multiplo de 10", numeros[1]);
                }

            }
            else
            {
                Console.WriteLine("El numero {0} no es multiplo de 10, por lo que no se seguirá el proceso...",numeros[0]);

            }
            Console.ReadKey();
        }
    }
}
