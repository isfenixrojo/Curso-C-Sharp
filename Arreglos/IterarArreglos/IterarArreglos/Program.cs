using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterarArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 78, 56, 12, 5, 2, 3, 8, 585 };

            Console.WriteLine("Con for");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Item #{0} = {1}", i, arreglo[i]);
            }

            Console.WriteLine("\nCon foreach");
            int n = 0;
            foreach (int item in arreglo)
            {
                Console.WriteLine("Item #{0} = {1}", n, item);
                n++;
            }

            string[] cadena = { "Hola", "Mundo", "Ciclos", "Arreglos", "Cadena" };
            Console.WriteLine("\nIterar arreglo con ciclo for (orden inverso)");
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", cadena[i]);
            }
            Console.WriteLine();
        }
    }
}
