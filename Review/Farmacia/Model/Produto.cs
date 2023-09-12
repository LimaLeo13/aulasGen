using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Tipo { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, int tipo, decimal preco)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }
        public Produto() { }
        public virtual void Visualizar()
        {
            string tipo = "";

            switch(Tipo)
            {
                case 1:
                    tipo = "Medicamento";
                    break;
                case 2:
                    tipo = "Cosmetico";
                    break;
            }

            Console

        }

        

    }
}
