using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoHrencias
{
    class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }
        public Estudiante(string nombre, int edad, double promedio, string grado) : base(nombre, edad)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public void Estudiar()
        {
            Console.WriteLine("Estudiando muy duro...");
        }

        public void IrAClases()
        {
            Console.WriteLine("Mi clase es de {0}", Grado);
        }

        public override void Saludar()
        {
            base.Saludar();//Version de persona;
            Console.WriteLine("Mi nombre es {0} y mi promedio es {1:0.0}", Nombre, Promedio);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Edad{1}, Promedio{2}, Grado{3}", Nombre, Edad, Promedio, Grado);
        }
    }
}
