using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var boleano = true;

            Console.WriteLine(-valorNegativo);// Inverte o sinal do valor negativo
            Console.WriteLine(!boleano); // Inverte o valor booleano
            

            numero1++; // Incrementa o valor de numero1 em 1
            Console.WriteLine(numero1);

            --numero1; // Decrementa o valor de numero1 em 1
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");

        }
    }
}
