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

            //Ajustar dato con 10 datos a la izquierda.
            Console.WriteLine(">{0,-10}<", 5);

            //Distintos formatos.
            int dato = 126;
            Console.WriteLine("Número: {0:N}", dato);
            Console.WriteLine("Cientifico: {0:E}", dato);
            Console.WriteLine("Moneda: {0:C9}", dato);
            Console.WriteLine("Porcentaje: {0:P}", dato);
            Console.WriteLine("Hexadecimal: {0:X}", dato);

        }
    }
}
