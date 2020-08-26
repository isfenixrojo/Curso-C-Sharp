using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Cadena de prueba ");
            //Propiedad Lenght y Capacity

            Console.WriteLine("Cadena {0}\nLenght {1}\nCapacity: {2}", builder, builder.Length, builder.Capacity);

            builder.EnsureCapacity(75); //Asegura una capacidad de 75

            Console.WriteLine("\nNueva capacidad: {0}", builder.Capacity);

            object[] datos = { "cadena", 1, 0.5, false, 'c', 8 };
            foreach (var items in datos)
            {
                builder.Append(items + " ");
            }
            Console.WriteLine(builder.ToString());
            builder.Insert(0, "Inserta al principio ");
            Console.WriteLine(builder);
        }
    }
}
