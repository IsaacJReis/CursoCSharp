using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MetodosEstaticos {


        public class CalculadoraEstatica {

            public int Somar(int a, int b) {
                return a + b;

            }

            public static int Multiplicar(int a, int b) {
                return a * b;

            }

        }

        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(10, 25);
            Console.WriteLine("Resultado: {0}", resultado); // Assecivel a partir da classe, sem precisar criar um objeto


            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(3, 5)); // Somar é um método de instância, ou seja, precisa criar um objeto para acessar
        }
    }
}
