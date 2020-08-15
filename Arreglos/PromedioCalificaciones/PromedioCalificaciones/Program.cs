using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioCalificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de calificaciones: ");
            //1_Ingresar numero de calificaciones a recbir.
            int tamanio = Convert.ToInt32(Console.ReadLine());
            int[] calificacion = new int[tamanio];

            for (int i = 0; i < calificacion.Length; i++)
            {
                Console.WriteLine("Ingresa calificacion #{0}: ", i + 1);
                calificacion[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Calificaciones ingresadas");
            MostrarCalificaciones(calificacion);
            SacarPromedio(calificacion);
        }

        static void MostrarCalificaciones(int[] calificaciones)
        {
            foreach (int item in calificaciones)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void SacarPromedio(int[] calificaciones)
        {
            double suma = 0;
            double promedio;
            int tamaño = calificaciones.Length;
            foreach (int item in calificaciones)
            {
                suma += item;
            }

            promedio = (suma / tamaño);

            Console.WriteLine("\nLa suma de las calificaciones es: " + suma);
            Console.WriteLine("\nEl promedio de las calificaciones es: " + promedio);
            Console.WriteLine();
        }
    }
}
