namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 1 

            List<string> cores = new List<string>();

            while (cores.Count < 5)
            {
                Console.WriteLine("Digite a cor: ");
                string cor = Console.ReadLine()!;
                cores.Add(cor);
                Console.Clear();
            }

            Console.WriteLine();

            foreach (var lista in cores)
            {
                Console.WriteLine(lista);
            }

            Console.WriteLine();

            cores.Sort();
            foreach (var lista in cores)
            {
                Console.WriteLine(lista);
              
            }






        }
    }
}