using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Práctica_7_5
    {
        public static int[,] Primero;
        public static int[,] Segundo;

        static int Sumas(int[,] datos)
        {
            int suma = 0;


            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    suma += datos[i, j];
                }
            }


            return suma;
        }
        static int sumar2(int[,] datos)
        {
            int suma = 0;


            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    suma += datos[i, j];
                }
            }


            return suma;
        }





        static void Main(string[] args)
        {
            int total = 0;
            Primero = new int[3, 3];
            Console.Write("Ingrese los numeros de la matriz 1: ");
            for (int f1 = 0; f1 < Primero.GetLength(0); f1++)
            {
                for (int c1 = 0; c1 < Primero.GetLength(1); c1++)
                {
                    string num;
                    num = Console.ReadLine();
                    Primero[f1, c1] = int.Parse(num);

                }
            }


            Segundo = new int[3, 3];
            Console.Write("Ingrese los numeros de la matriz 2: ");
            for (int i = 0; i < Primero.GetLength(0); i++)
            {
                for (int j = 0; j < Primero.GetLength(1); j++)
                {
                    string num;
                    num = Console.ReadLine();
                    Segundo[i, j] = int.Parse(num);

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            total = Sumas(Primero) + Sumas(Segundo);
            Console.WriteLine("La suma de la matrices es {0:N0}", total);
            Console.ReadKey();
        }
    }
}
