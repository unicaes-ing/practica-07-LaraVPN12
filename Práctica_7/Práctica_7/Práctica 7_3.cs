using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Práctica_7_3
    {
        static void Main(string[] args)
        {
            int cant_grupos,cant_integrantes;
            
            Console.WriteLine("Ingrese la cantidad de equipos");
            cant_grupos = Convert.ToInt32(Console.ReadLine());
            string[][] equipos;
            equipos = new string[cant_grupos][];
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine("Ingrese la cantidad de integrantes del equipo {0}",(i+1));
                cant_integrantes = Convert.ToInt32(Console.ReadLine());
                equipos[i] = new string[cant_integrantes];
                for (int j = 0; j < equipos[i].Length; j++)
                {
                    Console.WriteLine("Ingrese el nombre del integrante #{0} del equipo {1}",(j+1),(i+1));
                    equipos[i][j] = Console.ReadLine();
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("INFORMACIÓN DE LA LA LIGA:");
            for (int i = 0; i < equipos.Length; i++)
            {
                Console.WriteLine("Equipo # {0}:",(i+1));
                for (int j = 0; j < equipos[i].Length; j++)
                {
                    Console.WriteLine(equipos[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        
        }
    }
}
