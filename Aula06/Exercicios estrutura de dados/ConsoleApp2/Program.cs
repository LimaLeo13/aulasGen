namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Stack<string> pilha = new Stack<string>();
            Console.WriteLine("");

            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("");
                Console.WriteLine("\t1 - Adicionar livro na pilha");
                Console.WriteLine("\t2 - Listar todos os livros");
                Console.WriteLine("\t3 - Retirar livro na pilha");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine("");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Qual seria seu livro?");
                        pilha.Push(Console.ReadLine()!);
                        break;

                    case 2:
                        Console.WriteLine("Lista de livros da pilha");
                        foreach (var livros in pilha)
                        {
                            Console.WriteLine(livros);
                        }
                        break;

                    case 3:
                    if (pilha.Count > 0)
                        {
                            pilha.Pop();
                            foreach (var livros in pilha)
                            {
                                Console.WriteLine(livros);
                            }
                        }
                        
                    else
                        {
                            Console.WriteLine("A pilha está vazia");
                            Console.Clear();
                        }

                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado!");
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;


                }
            } while (opcao != 0);


        }
        }
    }
