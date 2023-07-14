using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartadoVB
{
    public class Empleado
    {
        string Nombre;
        string Apellido;
        float Sueldo_diario;
        public Empleado(string nombre, string apellido, float sueldo_diario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sueldo_diario = sueldo_diario;
        }
        
        public static void Calcula_Sueldo(int dias_trabajados, float sueldo_diario)
        {
            float sueldo;
            sueldo = sueldo_diario * dias_trabajados;
            Console.WriteLine("El sueldo del empleado es: " + sueldo);
        }

    }
}
