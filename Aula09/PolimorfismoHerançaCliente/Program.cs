using PolimorfismoHerançaCliente.Model;

namespace PolimorfismoHerançaCliente
{

    public class Program
    {
        static void Main(string[] args)
        {
            Jogo reileao = new Jogo(3, "Rei leão 2", 5.5M, "Aventura");
            reileao.Visualizar();
        }
    }

}
