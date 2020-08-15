using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    class CuentaBancaria
    {
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        //backing field
        private decimal _saldo;

        //Full property (Propiedad completa)
        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value < 0 ? 0 : value;
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            Saldo -= cantidad;
        }
        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return string.Format("NoCuenta: {0}, Usuario: {1}, Saldo: ${2}", NoCuenta, Usuario, Saldo);
        }

        public static string Banco { get; set; }

        public static void AsignarBnaco(string banco)
        {
            Console.WriteLine("Asignando nuevo banco...");
            Banco = banco;
        }

        #region
        public CuentaBancaria() { }
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            NoCuenta = noCuenta;
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            NoCuenta = noCuenta;
            Usuario = usuario;
            Saldo = saldo;
        }
        #endregion
    }
}
