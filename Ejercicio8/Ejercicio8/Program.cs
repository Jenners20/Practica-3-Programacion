using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa que pida al usuario dos números
             * enteros y diga "Uno de los números es positivo", "Los 
             * dos números son positivos" o bien "Ninguno de los números
             * es positivo", según corresponda*/

            int[] numeros = new int[2];
            int verificacion = 0;

            for (int i = 0;  i < 2;  i++)
            {
                Console.Write("Ingrese un numero entero: ");
                numeros[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (numeros[i] > 0)
                {
                    verificacion = verificacion + 1;
                }
            }
           
            if (verificacion==2)
            {
                Console.WriteLine("Los dos números son positivos...");
            }
            if (verificacion==1)
            {
                Console.WriteLine("Uno de los números es positivo...");
            }
            if (verificacion==0)
            {
                Console.WriteLine("Ninguno de los números son positivos...");
            }
            Console.ReadKey();
        }
    }
}
