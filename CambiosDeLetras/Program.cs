using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambiosDeLetras
{
    public class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("Ingresa un texto a moficiar: ");
            texto = Console.ReadLine();

            CambioLetras(texto);
            Console.ReadKey();
        }
        public static void CambioLetras(string texto)
        {
            char[] chars = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            string nuevoTexto=texto.Replace('a', chars[1]).Replace('b', chars[2]).Replace('c', chars[3]).Replace('d', chars[4]).Replace('e',chars[5]);

            Console.WriteLine(nuevoTexto);
        }
    }
}
