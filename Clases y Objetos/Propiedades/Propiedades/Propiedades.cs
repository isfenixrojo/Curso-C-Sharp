using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class Propiedades
    {
        static void Main(string[] args)
        {
            //CuentaBancaria cue1 = new CuentaBancaria();

            CuentaBancaria cue2 = new CuentaBancaria("001", "Israel", 100);
            CuentaBancaria cue3 = new CuentaBancaria("002", "Simón", 250);
            CuentaBancaria.Banco = "Mi Banco";

            /*cue1.Saldo = -5;
            Console.WriteLine("Saldo después de la primera asignacion: {0}", cue1.Saldo);

            cue1.Saldo = 10;
            Console.WriteLine("Saldo después de la segunda asignacion: {0}", cue1.Saldo);*/

            //Llamando a los metodos depositos y retirar.

            Console.WriteLine("Depositar $70 en cuenta 1");
            cue2.Depositar(70);
            Console.WriteLine("Retirar $20 en cuenta 2");
            cue3.Retirar(20);

            Console.WriteLine(cue2.ToString());
            Console.WriteLine(cue3);

            Console.WriteLine("Cambiando el banco");
            CuentaBancaria.AsignarBnaco("Otro banco");

            Console.WriteLine(cue2);
            Console.WriteLine(cue3);
        }
    }
}
