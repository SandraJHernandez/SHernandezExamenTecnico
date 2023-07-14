using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            float factorial = 1;

            Console.WriteLine("Ingresa el numero del que deseas saber el factorial: ");
            num = int.Parse(Console.ReadLine());

            for(int x=1; x<=num; x++)
            {
                factorial = factorial * x;
            }
            Console.WriteLine("El factorial de " + num + " es: " + factorial);
            Console.ReadKey();
        }
    }
}
