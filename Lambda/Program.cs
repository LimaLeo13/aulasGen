namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Exibir os itens\n");

            foreach (var n in numeros)
            {   
                Console.WriteLine(n + n);
            }
            numeros.ForEach(n => Console.WriteLine(n + n));

            Console.WriteLine("Exibir os itens pares da lista\n");

            foreach (var n in numeros)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
            }

            numeros.ForEach(n =>
            {
                if (n % 2 == 0)
                    Console.WriteLine(n);
            });

        
        }
    }
}