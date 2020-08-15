using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is your code.
            int[] list = { 12, 45, 98, 65, 12, 36, 78 };
            int[] temp = new int[list.Length]; //7 elementos

            //Genera una copia del arreglo list
            Array.Copy(list, temp, list.Length);

            Console.WriteLine("Arreglo original: ");
            MostrarArreglo(list);
            Console.WriteLine("Arreglo copia: ");
            MostrarArreglo(temp);

            //Invierte el arreglo

            Array.Reverse(temp);
            Console.WriteLine("Arreglo invertido");
            MostrarArreglo(temp);

            //Ordenar el arreglo 
            Array.Sort(list);
            Console.WriteLine("Arreglo ordenado");
            MostrarArreglo(list);
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}
