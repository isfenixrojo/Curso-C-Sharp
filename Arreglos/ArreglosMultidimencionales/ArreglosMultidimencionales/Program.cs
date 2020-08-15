using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidimencionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is your code.
            //Declarar un arreglo con tres filas y dos columnas;
            int[,] a = new int[3, 2] { { 0, 0 }, { 4, 7 }, { 6, 9 } };

            //Mostrar el arreglo
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2} ", i, j, a[i, j]);
                }

            }
            Console.Write("\n");

            int[,] matriz = new int[3, 3] { { 9, 1, 5 }, { 2, 3, 12 }, { 37, 5, 8 } };
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.Write("\n");
        }
    }
}
