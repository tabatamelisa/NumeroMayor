using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            do
            {
                Console.WriteLine("Digita el primer número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digita el segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine($"El número mayor es: {num1}");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine($"El número mayor es: {num2}");
                }
                else
                {
                    Console.WriteLine("Los números ingresados son iguales");
                }
            } while (true); //El programa se repite

        }
    }
}
