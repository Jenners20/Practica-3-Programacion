using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario tres números
             * reales y muestre cuál es el mayor de los tres.*/
            double[] numeros = new double[3];
            double mayor = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese un numero real: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            if (numeros[0]>numeros[1])
            {
                if (numeros[0]>numeros[2])
                {
                    Console.WriteLine("El mayor es: " + numeros[0]);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + numeros[2]);
                }
            }
            else
            {
                if (numeros[1]>numeros[2])
                {
                    Console.WriteLine("El mayor es: " + numeros[1]);
                }
                else
                {
                    Console.WriteLine("El mayor es: " + numeros[2]);
                }
            }
            Console.ReadKey();
        }
    }
}
