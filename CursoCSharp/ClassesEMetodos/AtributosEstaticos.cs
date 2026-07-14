using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {


    public class Produto {

        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;



        public Produto(string nome, double preco, double desconto) {

            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {
        }
        public double CaucularDesconto() {

            return Preco - Preco * Desconto;
        }
    }
    internal class AtributosEstaticos {


        public static void Executar() {
            var produto1 = new Produto("Lapís", 2.5, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Apontador",
                Preco = 1.5
            };

            Console.WriteLine("Preço com desconto {0}", produto1.CaucularDesconto());
            Console.WriteLine("Preço com desconto {0}", produto2.CaucularDesconto());

            Produto.Desconto = 0.4;
        }
    }
}
