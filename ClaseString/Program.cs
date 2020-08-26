using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenacion de Cadenas
            Console.WriteLine("Hola " + "Mundo");
            Console.WriteLine(string.Concat("Hola ", "Mundo"));

            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);

            //Mayusculas-Minusculas
            Console.WriteLine("Minuscula: " + cadena.ToUpper());
            Console.WriteLine("Mayuscula: " + cadena.ToLower());

            //Metodo replace 
            Console.WriteLine("Replace: " + cadena.Replace(" ", "_"));
            Console.WriteLine("Carácter en indice 0: " + cadena[0]);
            Console.WriteLine("Carácter en indice 1: " + cadena[3]);

            //Metodo substring
            Console.WriteLine("Substring (1-8): " + cadena.Substring(1, 8));


            //Metodo Contains
            Console.WriteLine("Cadena contiene \"es\"? " + cadena.Contains("es"));

            //Metodo StarWith
            Console.WriteLine("Cadena empieza con \"La\"? " + cadena.StartsWith("La"));

            //Verificar si una cadena es nula o vacia
            string nula = null;
            Console.WriteLine("nula es null? " + string.IsNullOrEmpty(nula));
            Console.WriteLine("cadena es null? " + string.IsNullOrWhiteSpace(cadena));

            //Obtener la posicion de un dato.
            Console.WriteLine("Posicion de la cadena \"de\"? " + cadena.IndexOf("de"));
        }
    }
}
