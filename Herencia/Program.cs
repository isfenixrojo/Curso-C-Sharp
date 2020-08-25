using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 38);

            p.Saludar();

            Empleado e = new Empleado("Jhon", 29, "Programador", 50000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e);
        }
    }
}
