namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            
            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Leonardo Machado");
            fila.Enqueue("Gaspar");
            
            fila.Dequeue();

            foreach (var nome in fila) 
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o primeiro da fila? " + fila.Peek());

            Console.WriteLine("Gaspar entrou na fila" + fila.Contains("Gaspar"));

            Console.WriteLine("Numero de pessoas na fila" + fila.Count);

        }

    }
}