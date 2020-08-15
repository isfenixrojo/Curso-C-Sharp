using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Constructores
    {
        static void Main(string[] args)
        {
            CuentaBancaria cu1 = new CuentaBancaria("000001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cu1.NoCuenta, cu1.Usuario, cu1.Saldo);

            CuentaBancaria cu2 = new CuentaBancaria("000002", "Israel");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cu2.NoCuenta, cu2.Usuario, cu2.Saldo);

            CuentaBancaria cu3 = new CuentaBancaria("000003", "Simón", 25358);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cu3.NoCuenta, cu3.Usuario, cu3.Saldo);
        }
    }
}
