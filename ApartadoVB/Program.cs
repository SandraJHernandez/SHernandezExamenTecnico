using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartadoVB
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dias_trabajados;

            Empleado empleado1 = new Empleado(nombre: "Jacobo", apellido: "Agami", sueldo_diario: 500);
            Empleado empleado2 = new Empleado(nombre: "Alvaro", apellido: "Gonzalez", sueldo_diario: 400);
            Empleado empleado3 = new Empleado(nombre: "Mario", apellido: "Ramon", sueldo_diario: 300);

            Console.WriteLine("Ingrese el numero de dias trabajados del empleado 1: ");
            dias_trabajados = int.Parse(Console.ReadLine());
            Empleado.Calcula_Sueldo(dias_trabajados, sueldo_diario: 500);
            Console.WriteLine("\n Ingrese el numero de dias trabajados del empleado 2: ");
            dias_trabajados = int.Parse(Console.ReadLine());
            Empleado.Calcula_Sueldo(dias_trabajados, sueldo_diario: 400);
            Console.WriteLine("\n Ingrese el numero de dias trabajados del empleado 2: ");
            dias_trabajados = int.Parse(Console.ReadLine());
            Empleado.Calcula_Sueldo(dias_trabajados, sueldo_diario: 300);
            Console.ReadKey();
        }

    }
}
