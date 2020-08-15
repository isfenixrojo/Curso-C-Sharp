using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisArreglos
{
    class Arreglos
    {
        static void Main(string[] args)
        {
            //Sintaxis 1
            int[] array = new int[5];
            array[0] = 56;
            array[1] = 12;
            array[2] = 5;
            array[3] = 8;
            array[4] = -4;
            Console.WriteLine("Arreglo: " + array[4]);

            //Sintaxis 2
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Arreglo: " + vocales[3]);
        }
    }
}
