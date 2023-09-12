namespace Farmacia
{
    public class Program
    {
        private static ConsoleKeyInfo ConsoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;



            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                           Farmacia Br                            |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                 1 - Criar Produto                                |");
                Console.WriteLine("                 |                 2 - Listar Todos os Produtos                     |");
                Console.WriteLine("                 |                 3 - Buscar produto por Id                        |");
                Console.WriteLine("                 |                 4 - Atualizar dados do Produto                   |");
                Console.WriteLine("                 |                 5 - Apagar Produto                               |");
                Console.WriteLine("                 |                 6 - Sair                                         |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |                Entre com a opção desejada                        |");
                Console.WriteLine("                 |                                                                  |");
                Console.WriteLine("                 |%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%|");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Crie seu produto");
                        break;

                    case 2:
                        Console.WriteLine("Liste seus produtos");
                        break;

                    case 3:
                        Console.WriteLine("Buscar produto por Id");
                        break;

                    case 4:
                        Console.WriteLine("Atualizar dados do Produto");
                        break;

                    case 5:
                        Console.WriteLine("Apagar produtos");
                        break;
                }

            }
        }
    }
}