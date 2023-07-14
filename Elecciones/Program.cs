using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int voto, candidatoA = 0, candidatoB = 0, candidatoC = 0;

            Console.WriteLine("Ingresa el numero correcpondiente al candidato a Delegado del grupo por el que deseas votar: \n Candidato A: 1 \n Candidato B: 2 \n Candidato C: 3");
            for (int x = 1; x<=20; x++)
            {
                Console.WriteLine("Ingresa el numero correcpondiente al candidato que elegiste: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                {
                    candidatoA++;
                }
                else if (voto == 2)
                {
                    candidatoB++;
                }
                else
                {
                    candidatoC++;
                }
            }

            if (candidatoA > candidatoB && candidatoA > candidatoC)
            {
                Console.WriteLine("Candidato Ganador: A");
                Console.WriteLine("Votos del Candidato: " + candidatoA);

                if (candidatoB > candidatoC)
                {
                    Console.WriteLine("\n Candidado 2° lugar: B");
                    Console.WriteLine("Votos del Candidato: " + candidatoB);
                    Console.WriteLine("\n Candidado 3° lugar: C");
                    Console.WriteLine("Votos del Candidato: " + candidatoC);
                }
                else if(candidatoC > candidatoB)
                {
                    Console.WriteLine("\n Candidado 2° lugar: C");
                    Console.WriteLine("Votos del Candidato: " + candidatoC);
                    Console.WriteLine("\n Candidado 3° lugar: B");
                    Console.WriteLine("Votos del Candidato: " + candidatoB);
                }
            }
            else if(candidatoB > candidatoA && candidatoB > candidatoC)
            {
                Console.WriteLine("Candidato Ganador: B");
                Console.WriteLine("Votos del Candidato: " + candidatoB);
                if (candidatoA > candidatoC)
                {
                    Console.WriteLine("\n Candidado 2° lugar: A");
                    Console.WriteLine("Votos del Candidato: " + candidatoA);
                    Console.WriteLine("\n Candidado 3° lugar: C");
                    Console.WriteLine("Votos del Candidato: " + candidatoC);
                }
                else if (candidatoC > candidatoA)
                {
                    Console.WriteLine("\n Candidado 2° lugar: C");
                    Console.WriteLine("Votos del Candidato: " + candidatoC);
                    Console.WriteLine("\n Candidado 3° lugar: A");
                    Console.WriteLine("Votos del Candidato: " + candidatoA);
                }
            }
            else if(candidatoC > candidatoA && candidatoC > candidatoB)
            {
                Console.WriteLine("Candidato Ganador: C");
                Console.WriteLine("Votos del Candidato: " + candidatoC);

                if (candidatoA > candidatoB)
                {
                    Console.WriteLine("\n Candidado 2° lugar: A");
                    Console.WriteLine("Votos del Candidato: " + candidatoA);
                    Console.WriteLine("\n Candidado 3° lugar: B");
                    Console.WriteLine("Votos del Candidato: " + candidatoB);
                }
                else if (candidatoB > candidatoA)
                {
                    Console.WriteLine("\n Candidado 2° lugar: B");
                    Console.WriteLine("Votos del Candidato: " + candidatoB);
                    Console.WriteLine("\n Candidado 3° lugar: A");
                    Console.WriteLine("Votos del Candidato: " + candidatoA);
                }
            }
            else
            {
                if(candidatoA == candidatoB && candidatoC == candidatoB)
                {
                    Console.WriteLine("Los 3 candidatos obtuvieron la misma cantidad de votos");
                }
                else if(candidatoA == candidatoB)
                {
                    Console.WriteLine("Los candidatos A y B obtuvieron la misma cantidad de votos");
                }
                else if(candidatoC == candidatoB)
                {
                    Console.WriteLine("Los candidatos B y C obtuvieron la misma cantidad de votos");
                }
                else if(candidatoC == candidatoA)
                {
                    Console.WriteLine("Los candidatos A y C obtuvieron la misma cantidad de votos");
                }
            }
            Console.WriteLine("Votos Totales: 20");
            Console.WriteLine("Votos del Candidato A: " + candidatoA);
            Console.WriteLine("Votos del Candidato B: " + candidatoB);
            Console.WriteLine("Votos del Candidato C: " + candidatoC);

            Console.ReadKey();
        }
    }
}
