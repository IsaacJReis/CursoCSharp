using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpicional {

        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opicional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propiedades Autoimplantadas
        public double Preco
        {
            get; set;
        }

        //Somente Leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda

            //get
            //{
            //    return Preco - (desconto * Preco);
            //}

        }

        public CarroOpicional() {

        }

        public CarroOpicional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }




        internal class Props {

            public static void Executar() {

                var op1 = new CarroOpicional("Paredão", 15000.00);
                Console.WriteLine(op1.PrecoComDesconto);

                var op2 = new CarroOpicional();
                op2.Nome = "Motor Envenenado";
                op2.Preco = 50000.00;

                Console.WriteLine(op1.Nome);
                Console.WriteLine(op1.Preco);


                Console.WriteLine(op2.Nome);
                Console.WriteLine(op2.Preco);
                Console.WriteLine(op2.PrecoComDesconto);

            }
        }
    }
}