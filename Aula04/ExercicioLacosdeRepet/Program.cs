namespace ExercicioLacosdeRepet
{
    internal class Program
    {

        //LISTA 01 EXERCICIO 01

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número inteiro:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro (maior que o primeiro):");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("Intervalo inválido. O primeiro número deve ser menor que o segundo.");
            }
            else
            {
                Console.WriteLine($"Números múltiplos de 3 e 5 no intervalo de {num1} a {num2}:");
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //LISTA 01 EXERCICIO 02

            int totalNumeros = 10;
            int numerosPares = 0;
            int numerosImpares = 0;

            for (int i = 1; i <= totalNumeros; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
            Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");

            Console.ReadKey();

            //LISTA 02 EXERCICIO 03

            int age;
            int countUnder21 = 0;
            int countOver50 = 0;

            Console.WriteLine("Digite as idades das pessoas (idade negativa para sair):");

            while (true)
            {
                Console.Write("Idade: ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age < 0)
                    break;

                if (age < 21)
                    countUnder21++;
                else if (age > 50)
                    countOver50++;
            }

            Console.WriteLine($"Total de pessoas com menos de 21 anos: {countUnder21}");
            Console.WriteLine($"Total de pessoas com mais de 50 anos: {countOver50}");

            //LISTA O3 EXERCICIO 05

            int number;
            int sum = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para sair):");

            do
            {
                Console.Write("Número: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                    sum += number;

            } while (number != 0);

            Console.WriteLine($"A soma dos números positivos digitados é: {sum}");
        }

    }
}