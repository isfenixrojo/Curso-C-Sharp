using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Clases
    {
        static void Main(string[] args)
        {
            //Crear un objeto de tipo rectangulo;
            Rectangulo rect = new Rectangulo();

            rect.Altura = 10;
            rect.Base = 5;
            int area = rect.CalcularArea();
            Console.WriteLine("Rect: {0} x {1}, area: {2}", rect.Base, rect.Altura, area);

            Rectangulo rec2 = new Rectangulo { Base = 3, Altura = 8 };
            int area2 = rec2.CalcularArea();
            Console.WriteLine("Rect2: {0} x {1}, area: {2}", rect.Base, rect.Altura, area2);
        }
    }
}
