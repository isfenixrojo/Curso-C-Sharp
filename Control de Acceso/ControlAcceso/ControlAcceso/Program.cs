using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtroControlAcceso;
namespace ControlAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj = new MiClase();

            obj.MetodoPublico();
            obj.MetodoInternal();
            //obj.MetodoPrivate();
            //obj.MetodoProtected();

        }
    }
}
