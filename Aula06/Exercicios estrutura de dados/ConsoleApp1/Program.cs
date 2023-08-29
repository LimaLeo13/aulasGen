namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 01

            int opcao = 0;
            Queue<string> fila = new Queue<string>();

            do
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine();
                Console.WriteLine("\t1 - Adicionar Cliente na fila");
                Console.WriteLine("\t2 - Listar todos os Clientes");
                Console.WriteLine("\t3 - Retirar clientes da fila");
                Console.WriteLine("\t0 - Sair");
                Console.WriteLine();
                Console.WriteLine("********************************************************");
                Console.WriteLine("\tEntre com a opção desejada");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Insira o nome do cliente: ");
                        string? nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        break;
                    case 2:
                        Console.WriteLine("Lista de clientes na fila: ");
                        foreach (var clientes in fila)
                        {
                            Console.WriteLine(clientes);
                        }
                        break;
                    case 3:
                        if (fila.Count > 0)
                        {
                            Console.WriteLine("Insira o nome do cliente a ser retirado: ");
                            string nomeRetirado = Console.ReadLine();
                            fila.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;


                }
            } while (opcao != 0);

            
            }
        }
    }
