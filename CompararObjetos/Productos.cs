using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    class Productos : IComparable<Productos>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Productos otro)
        {
            if (Precio > otro.Precio) return 1;
            if (Precio > otro.Precio) return 0;
            return -1;
        }
    }
}
