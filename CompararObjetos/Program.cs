using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se decalra los productos 
            Productos p1 = new Productos { Codigo = "A1", Precio = 123 };
            Productos p2 = new Productos { Codigo = "A2", Precio = 34.5m };
            Productos p3 = new Productos { Codigo = "A3", Precio = 99.9m };

            //Se inicializa  el arreglo de la matriz
            decimal suma = 0;
            Productos[] productos = new Productos[] { p1, p2, p3 }; ///
            //Se ordena la matriz 
            Array.Sort(productos);
            foreach (var prod in productos)
            {
                suma += prod.Precio;
                Console.WriteLine("Codigo: {0}, Precio: {1}", prod.Codigo, prod.Precio);
            }
            Console.WriteLine("\nLa suma de precios es: " + suma + "\n");
        }


    }
}
