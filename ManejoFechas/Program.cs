using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFechas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Fecha Actual: {0}", dt);
            Console.WriteLine("Fecha Personalizada: {0}/{1}/{2}", dt.Day, dt.Month, dt.Year);
            Console.WriteLine("Fecha Personalizada: {0}-{1}-{2}", dt.Day, dt.Month, dt.Year);

            string dia = dt.Day.ToString().PadLeft(2, '0');
            string mes = dt.Month.ToString().PadLeft(2, '0'); ;
            string formatoFecha = dia + "-" + mes + "-" + dt.Year;
            Console.WriteLine("Fecha con ceros: {0}", formatoFecha);

            //DateTime dt = new DateTime(2017, 2, 3, 10, 20, 30);
            Console.WriteLine("Año: {0}", dt.Year);
            Console.WriteLine("Mes: {0}", dt.Month);
            Console.WriteLine("Día: {0}", dt.Day);
            Console.WriteLine("Día Mes: {0}", dt.DayOfWeek);
            Console.WriteLine("Hora: {0}", dt.Hour);
            Console.WriteLine("Minuto: {0}", dt.Minute);
            Console.WriteLine("Segundo: {0}", dt.Second);

            Console.WriteLine("Agregar días: {0}", dt.AddDays(4));
            Console.WriteLine("Restar fecha: {0}", dt.AddYears(-2));
            Console.WriteLine("Restar minutos: {0}", dt.AddMinutes(40));
        }
    }
}
