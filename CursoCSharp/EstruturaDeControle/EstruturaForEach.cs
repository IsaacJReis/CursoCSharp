
using System;



namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Isaac" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}