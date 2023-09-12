using Metodos_02.Namespace01;

namespace Metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MetodoPublico();
            MetodoInternal();
            MetodoProtegido();
            MetodoPrivado();

            Classe01.MetodoPublico();
            Classe01.MetodoInternal();
            //Classe01.MetodoProtegido();
            //Classe01.MetodoPrivado();

            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
            //Classe02.MetodoProtegido();
           // Classe02.MetodoPrivado();

        }

       
        public static void MetodoPublico()
        {
            Console.WriteLine("Metodo Publico - Classe Program");
        }

        public static void MetodoInternal()
        {
            Console.WriteLine("Metodo Internal - Classe Program");
        }

        public static void MetodoProtegido()
        {
            Console.WriteLine("Metodo Protegido - Classe Program");
        }

        public static void MetodoPrivado()
        {
            Console.WriteLine("Metodo Privado - Classe Program");
        }



    }

}