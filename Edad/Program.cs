using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    public class Program
    {
        static void Main(string[] args)
        {
            int edad, menor = 0, mayor=0;

            for(int x = 1; x<=10; x++)
            {
                Console.WriteLine("Ingresa la edad de la persona " + x + " :");
                edad = int.Parse(Console.ReadLine());

                if (edad <= 17)
                {
                    //Console.WriteLine("Es menor de edad ");
                    menor++ ;
                }
                else
                {
                    //Console.WriteLine("Es mayor de edad");
                    mayor++;
                }
            }
            Console.WriteLine("Menores de edad: " + menor);
            Console.WriteLine("Mayores de edad: " + mayor);
            
            Console.ReadKey();
        }
        
    }
}
