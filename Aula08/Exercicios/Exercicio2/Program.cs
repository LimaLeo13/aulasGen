using Exercicio2.Exercicio2;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classe2 c1 = new Classe2("Leo", 21, "000000000-00", "Masculino", "1,80");
            Classe2 c2 = new Classe2("Julia", 21, "000000000-00", "Feminino", "1,59");
            c1.visualizar();

            c1.SetNome("Leonardo Lima");
            c1.SetIdade(25);
            c1.SetCargo("Peão");
            c1.SetGenero("Masculino");
            c1.SetAltura("1,80");

            c1.visualizar();

            c2.SetNome("Julia");
            c2.SetIdade(21);
            c2.SetCargo("Gerente");
            c2.SetGenero("Feminino");
            c2.SetAltura("1,59");

            c2.visualizar();

        }
    
    }
}