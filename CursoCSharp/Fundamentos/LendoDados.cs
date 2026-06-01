using System;
using System.Drawing;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {

        public static void Executar() {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($" Nome é:  {nome} a idade é:  {idade} ganha:  R${salario}");


            Console.WriteLine("Qual seu valor monetario? ");
            double moeda = double.Parse(Console.ReadLine());
            Console.WriteLine(moeda.ToString("C"));
        }
    }
}
