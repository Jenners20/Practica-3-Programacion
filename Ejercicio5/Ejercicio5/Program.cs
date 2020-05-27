using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que multiplique dos números
             * enteros de la siguiente forma: pedirá al usuario un
             * primer número entero. Si el número que se que teclee
             * es 0, escribirá en pantalla "El producto de 0 por 
             * cualquier número es 0". Si se ha tecleado un número
             * distinto de cero, se pedirá al usuario un segundo 
             * número y se mostrará el producto de ambos.*/

            int[] numeros=new int[2];
            int resultado = 0;

            Console.Write("Ingrese un numero entero: ");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (numeros[0]!=0)
            {
                Console.Write("Ingrese un numero entero: ");
                numeros[1] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                resultado = numeros[0] * numeros[1];

                Console.WriteLine("El producto de {0} y {1} es: {2}", numeros[0], numeros[1], resultado);
            }
            else
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }

            Console.ReadKey();
        }
    }
}
