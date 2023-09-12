using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    public class Classe01
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Metodo Publico - Classe 01");
        }

        public static void MetodoInternal()
        {
            Console.WriteLine("Metodo Internal - Classe 01");
        }

        protected static void MetodoProtegido()
        {
            Console.WriteLine("Metodo Protegido - Classe 01");
        }

        private static void MetodoPrivado()
        {
            Console.WriteLine("Metodo Privado - Classe 01");
        }
    }
}
