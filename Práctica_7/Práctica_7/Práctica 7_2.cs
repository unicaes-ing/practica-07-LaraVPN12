using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Práctica_7_2
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int cantidad,numero,par=0,impar=0;
            Console.WriteLine("Ingrese la cantidad de números que desea escribir");
            cantidad = Convert.ToInt32(Console.ReadLine());
            numeros = new int[cantidad];

            for (int i = 1; i <= numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el número");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    par++;
                }
                else impar++;
                
                
            }
            Console.WriteLine("TOTAL DE NÚMEROS PARES: {0}\nTOTAL DE NÚMEROS IMPARES: {1}",par,impar);
            Console.ReadKey();
        }
    }
}
