using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; //conversão implícita
            Console.WriteLine(quebrado);

            double nota = 9.7;  
            int notaTruncada = (int)nota; //conversão explícita (cast)
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();    
            int idadeInteiro = int.Parse(idadeString); //conversão de string para inteiro
            Console.WriteLine("Idade inseria: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.Write("Digite o primeiro numero: ");
                string palavra = Console.ReadLine();
                int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado {0}", numero);

            Console.Write("Digite o Segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado {0}", numero2);
        }
    }
}
