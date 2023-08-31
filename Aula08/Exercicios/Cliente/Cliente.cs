using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class Cliente
    {
        private string nome;
        private int idade;
        private string cpf;
        private string genero;
        private string altura;
        public Cliente(string nome, int idade, string cpf, string genero, string altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
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

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
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
            Console.WriteLine("Seu CPF " + this.cpf);
            Console.WriteLine("Seu genero " + this.genero);
            Console.WriteLine("Sua altura " + this.altura);
        }


    }


}

