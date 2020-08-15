using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamaño del arreglo? ");
            int tam = Convert.ToInt32(Console.ReadLine());

            //Definir el arreglo
            int[] numeros = new int[tam];

            //Leer datos y guardalos en el arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escribe número en indice {0}: ", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nLos datos que ingresaste son: ");
            MostrarArreglo(numeros);
            SumarNumeros(numeros);
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }

        static void SumarNumeros(int[] arreglo)
        {
            int suma = 0;
            foreach (int item in arreglo)
            {
                suma += item;
            }
            Console.WriteLine("\nLa suma de los numero del arreglo es: " + suma);
            Console.WriteLine();
        }
    }
}
