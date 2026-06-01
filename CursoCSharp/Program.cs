using CursoCSharp.ClassesEMetodos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos;", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos;", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos;", Inferencia.Executar},
                {"Interpolação - Fundamentos;", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos;", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos;", LendoDados.Executar},
                {"Formatando Número - Fundamentos;", FormatandoNumero.Executar},
                {"Conversões - Fundamentos;", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos;", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos;", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos;", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos;", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos;", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos;", OperadorTernario.Executar},
               
                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle;", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas de Controle;", EstruturaIfElse.Executar},
                {"Estrutura If ElseIf - Estruturas de Controle;", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle;", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle;", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle;", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas  Controle;", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas  Controle;", EstruturaForEach.Executar},
                {"Usando Break - Estruturas  Controle;", UsandoBreak.Executar},
                {"Usando Continue - Estruturas  Controle;", UsandoContinue.Executar},
               
                //Classes e Metodos 
                {"Membros - Classes e Metodos;", Membros.Executar},
                {"Membros - Classes e Metodos;", Construtores.Executar},
                                
                
            });

            central.SelecionarEExecutar();
        }
    }
}