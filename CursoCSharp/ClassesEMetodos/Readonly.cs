using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
         Nome = nome;
         Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

        public int GetIdade() {

            int idade = DateTime.Now.Year - Nascimento.Year;

            if (DateTime.Now.Month < Nascimento.Month)
            {
                idade--;
            }

            else if (DateTime.Now.Month == Nascimento.Month && DateTime.Now.Day < Nascimento.Day)
                
            {
                idade--;
            }

            return idade;
        
        }

    }
    internal class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Isaac Reis", new DateTime(2007, 3, 12));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
            Console.WriteLine("Idade: {0}",novoCliente.GetIdade());
            
        
        }
    }
}
