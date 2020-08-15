using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroControlAcceso
{
    class MiClase
    {
        //Puede ser visto desde otra clase.
        public void MetodoPublico()
        {
            Console.WriteLine("Llamando al método Publico");
        }

        //Puede ser visto desde esta clase o cualquier clase 
        //que herede de mi MiClase 
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamando al método Protected");
        }

        //Puede ser visto por cualquier clase dentro del mismo assembly 
        internal void MetodoInternal()
        {
            Console.WriteLine("Llamando al método Internal");
        }

        //Puede ser visto solo por esta clase.
        private void MetodoPrivate()
        {
            Console.WriteLine("Llamando al método Private");
        }
}
}
