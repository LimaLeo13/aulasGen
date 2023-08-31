using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Exercicio2
{
    public class Classe2
    {
        private string nome;
        private int idade;
        private string cargo;
        private string genero;
        private string altura;
        public Classe2 (string nome, int idade, string cargo, string genero, string altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.cargo = cargo;
            this.genero = genero;
            this.altura = altura;
        }

        /*Métodos Get e Set*/
        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetCargo()
        {
            return cargo;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string GetGenero()
        {
            return genero;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        public string GetAltura()
        {
            return altura;
        }

        public void SetAltura(string altura)
        {
            this.altura = altura;
        }
        public void visualizar()
        {
            Console.WriteLine("Seu nome " + this.nome);
            Console.WriteLine("Sua idade " + this.idade);
            Console.WriteLine("Seu cargo " + this.cargo);
            Console.WriteLine("Seu genero " + this.genero);
            Console.WriteLine("Sua altura " + this.altura);
        }


    }


}

   