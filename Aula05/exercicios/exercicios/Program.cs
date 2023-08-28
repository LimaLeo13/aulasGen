using System;

namespace exercicios
{
    internal class Program
    {

        static void Main(string[] args)

        //LISTA 01 EXERCICIO 02

        //Ler 10 numeros inteiros e armazenar em um vetor 
        //Mostrar na tela: Todos os elementos dos indices impares do vetor;
        //Todos os elementos pares;
        //A média de todos os elementos do vetor em uma variavel tipo real

        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] vetor02 = new int[10];
            int soma = 0;

            Console.WriteLine("\nDigite 10 numeros inteiros\n");

            for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"Numero {indice + 1}:");
                vetor01[indice] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nElementos nos índices ímpares do vetor\n");


            for (int indice = 1; indice < 10; indice += 2)
            {
                Console.WriteLine($"Índice {indice}: {vetor01[indice]}");
            }

            Console.WriteLine("\nElementos pares do vetor\n");

            for (int indice = 0; indice < 10; indice++)
            {
                if (vetor01[indice] % 2 == 0)
                {
                    Console.WriteLine(vetor01[indice]);
                }
            }


            Console.WriteLine("\nSoma de todos os elementos\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                vetor01[i] = int.Parse(Console.ReadLine());
                soma += vetor01[i];
            }

            Console.WriteLine($"\nA soma de todos os elementos do vetor é: {soma}\n");

            double media = (double)soma / 10;

            Console.WriteLine($"\nA média de todos os elementos do vetor é: {media}\n");


            //LISTA 02 EXERCICIO 03

            int[,] matriz = new int[3, 3];
            int somaPrincipal = 0, somaSecundaria = 0;
            string diagonalPrincipal = "", diagonalSecundaria = "";

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz.Length); indiceColuna++)
                {
                    Console.WriteLine($"matriz[{indiceLinha}, {indiceColuna}] = ");
                    matriz[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }

                for (int indiceLinha2 = 0; indiceLinha2 < Math.Sqrt(matriz.Length); indiceLinha2++)
                {
                    diagonalPrincipal += matriz[indiceLinha2, indiceLinha2] + " ";
                    somaPrincipal += matriz[indiceLinha2, indiceLinha2];
                }

                for (int indiceLinha3 = 0; indiceLinha3 < Math.Sqrt(matriz.Length); indiceLinha3++)
                {
                    diagonalSecundaria += matriz[indiceLinha3, (int)(Math.Sqrt(matriz.Length) - 1 - indiceLinha3)];
                    somaSecundaria += matriz[indiceLinha3, indiceLinha3];
                }

                Console.WriteLine("Elementos da Diagonal Principal" + diagonalPrincipal);
                Console.WriteLine("Soma da Diagonal Principal" + somaPrincipal);
                Console.WriteLine("Elementos da Diagonal Secundaria" + diagonalSecundaria);
                Console.WriteLine("Soma da Diagonal Secundaria" + diagonalPrincipal);

            }
        }
    }

            
    
}