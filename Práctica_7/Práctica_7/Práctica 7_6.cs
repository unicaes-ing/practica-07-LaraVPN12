using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Práctica_7_6
    {
        public static Random ran;
        public static int[,] numeros;

        public static void CargarDatos()
        {
            ran = new Random();

            numeros = new int[10, 10];
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = ran.Next(10, 99);

                }

            }
            Console.WriteLine();
            Console.WriteLine("La matriz se genero correctamente");
            Console.WriteLine("Presione <Enter> para regresar al menu");
            Console.ReadLine();

        }

        public static void MostrarDatos()
        {
            Console.WriteLine("––-–––––––––––––––––");
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                Console.WriteLine("[");
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    if (numeros[i, j] == 0)
                    {
                        Console.Write("00");
                    }
                    else
                    {
                        if ((numeros[i, j] != 0) && (numeros[i, j] % 2 == 0))
                        {

                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        Console.Write(numeros[i, j]);
                    }


                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("[");

                }

                Console.WriteLine();
                if (i < 9)
                {
                    Console.WriteLine("+––-+–––+–––+–––+––––+––––");
                }

            }

            Console.WriteLine("+––-+–––+–––+–––+––––+––––");
            Console.WriteLine();
            Console.WriteLine("Presione <Enter> para regresar al menu");
            Console.ReadLine();





        }

        static void Main(string[] args)
        {

            int Opcion = 0;
            numeros = new int[6, 6];

            do
            {
                Console.Clear();
                Console.WriteLine("[1]. Insertar matriz");
                Console.WriteLine("[2]. Ver matriz");
                Console.WriteLine("[3]. Salir");
                Console.WriteLine();
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        CargarDatos();
                        break;
                    case 2:
                        MostrarDatos();
                        break;
                }
            } while (Opcion != 3);

        }

    }
}
