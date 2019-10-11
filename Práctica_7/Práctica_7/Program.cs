using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edad;
            int cantidad,edades,mayores=0,menores=0;
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            cantidad = Convert.ToInt32(Console.ReadLine());
            edad = new int[cantidad];

            for (int i = 1; i <= edad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad del estudiante {0}",i);
                edades = Convert.ToInt32(Console.ReadLine());

                if (edades >= 18)
                {
                    mayores++;
                }
                else menores++;
            }
            Console.WriteLine("MAYORES DE EDAD: {0}\nMENORES DE EDAD: {1}",mayores,menores);
            Console.ReadKey();
        }
    }
}
