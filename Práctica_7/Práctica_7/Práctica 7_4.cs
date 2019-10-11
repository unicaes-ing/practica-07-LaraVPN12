using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Práctica_7_4
    {
        static void Arreglo(int[,] Matriz)
        {
            for (int i = 0; i < Matriz.Length; i++)
            {
                for (int j = 0; j < Matriz.Length; j++)
                {
                    Console.Write(Matriz[i,j]+"\t");
                    
                }
                Console.WriteLine();
            }
        }
      
        static void Main(string[] args)
        {
            int[,] Numeros;
            Numeros = new int[3, 3];
            int numero = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                for (int j = 0; j < Numeros.Length; j++)
                {
                    Console.WriteLine("Ingrese el número:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Numeros[i, j] = numero;
                }
                
            }

            Arreglo(Numeros);
            Console.ReadKey();
        }

       
    }
}
