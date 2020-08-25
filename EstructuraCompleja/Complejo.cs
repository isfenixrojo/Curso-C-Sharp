using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCompleja
{
    struct Complejo
    {
        public double Real { get; }
        public double Imaginario { get; }

        public Complejo(double real, double imaginario) : this()
        {
            Imaginario = imaginario;
            Real = real;
        }

        public Complejo Suma(Complejo otro)
        {
            return new Complejo(Real + otro.Real, Imaginario + otro.Imaginario);
        }
        public Complejo Multiplicacion(Complejo otro)
        {
            return new Complejo(Real * otro.Real - Imaginario * otro.Imaginario, Real * otro.Imaginario + Imaginario * otro.Real);
        }
        public override string ToString()
        {
            return string.Format("Re: {0:0.0}, Im: {1:0.0}i", Real, Imaginario);
        }
    }
}
