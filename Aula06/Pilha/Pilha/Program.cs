namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            pilha.Pop();

            foreach (var nome in pilha) 
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o ultimo elemento da fila? " + pilha.Peek());

            Console.WriteLine("Gaspar faz parte da pilha" + pilha.Contains("Gaspar"));

            Console.WriteLine("Numero de pessoas na pilha" + pilha.Count);

        }

    }
}