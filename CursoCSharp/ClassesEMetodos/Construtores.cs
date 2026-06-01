using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;




        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;

        }



        public Carro()
        {

        }
    }

    

    internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "Fiat";
            carro1.Modelo = "Siena";
            carro1.Ano = 2020;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");


            var Carro2 = new Carro("Civic", "Honda", 2020);
            Console.WriteLine($"{Carro2.Fabricante} {Carro2.Modelo} {Carro2.Ano} ");
        }
    }
}
