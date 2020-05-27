using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números enteros. 
             * Si el segundo no es cero, mostrará el resultado de dividir
             * entre el primero y el segundo. Por el contrario, si el segundo
             * número es cero, escribirá "Error: No se puede dividir entre cero".*/

            int[] numeros = new int[2];
            double resultado = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Ingrese un numero entero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            if (numeros[1]!=0)
            {
                resultado = numeros[0] / numeros[1];

                Console.WriteLine("El resultado de dividir {0} y {1} es: {2}", numeros[0], numeros[1], resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero ");
            }
            Console.ReadKey();
        }
    }
}
