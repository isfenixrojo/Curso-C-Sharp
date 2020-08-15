using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass1
    {
        public void Metodo()
        {
            int a = 10;
            int suma = 78 + a;
            Console.WriteLine("Dentro de mi MyNamespace");
            Console.WriteLine("La Suma es: {0}", suma);
        }
    }
}

namespace OtherNamespace
{
    class MyClass
    {
        public void Metodo()
        {
            string cadena = "Hola Mundo";
            int tamano = cadena.Length;
            Console.WriteLine("\nDentro de mi otro MyNamespace");
            Console.WriteLine("La cadena dice: {0} y tiene un tamaño de {1}", cadena, tamano);
        }
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNamespace.MyClass1 obj1 = new MyNamespace.MyClass1();
            OtherNamespace.MyClass obj2 = new OtherNamespace.MyClass();

            obj1.Metodo();
            obj2.Metodo();
        }
    }
}
