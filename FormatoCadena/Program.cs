using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatoCadena
{
    class Program
    {
        static void Main(string[] args)
        {
            int Naranjas = 8;
            int Platanos = 2;
            int Manzanas = 6;

            string resultado = string.Format("Hay {0} Platanos, {1} Naranjas, {2} Manzanas", Platanos, Naranjas, Manzanas);
            Console.WriteLine(resultado);

            Console.WriteLine("Pi: {0:0.00}", Math.PI);

            //Ajustar datos con 10 caracteres de espacio;
            Console.WriteLine(">{0,10}<", 5);
        }
    }
}
