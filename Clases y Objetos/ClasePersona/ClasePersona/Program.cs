using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pe1 = new Persona("Israel", "Hernandez", 29);
            Persona pe2 = new Persona("Simón", "Moon Moon", 1);
            pe1.Saludar();
            pe2.Saludar();

            pe2.Edad = -10;
            Console.WriteLine(pe2);

        }
    }
}
