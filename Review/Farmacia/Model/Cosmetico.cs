using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Cosmetico : Produto
    {
        public String Fragancia { get; set; } = string.Empty;
        public Cosmetico(int id, string nome, int tipo, decimal preco, string fragancia)
            : base(id, nome, tipo, preco)
        {
            Fragancia = fragancia;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Cosmetico: " + Cosmetico)
        }
    }
}
