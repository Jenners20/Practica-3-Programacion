using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario ds numeros enteros
            //y diga cual es el mayor de ellos

            int num1 = 0;
            int num2 = 0;

            Console.Write("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (num1>num2)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            if (num1<num2)
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }
            if (num1==num2)
            {
                Console.WriteLine("Los numeros {0} y {1} son iguales ",num1,num2);
            }

            Console.ReadKey();
        }
    }
}
