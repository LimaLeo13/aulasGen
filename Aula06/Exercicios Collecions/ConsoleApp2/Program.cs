namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Exercicio 2

            HashSet<int> numeros = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                int recebidos = Convert.ToInt32(Console.ReadLine())!;
                numeros.Add(recebidos);
                Console.Clear();
            }

            foreach (var l in numeros) 
            {
                Console.WriteLine(l + " ");
            }
        }
    }
}