using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() {
        }
    }

    internal class Construtores {
        public static void Executar() {
            Carro celta = new Carro();
            celta.Modelo = "Celta";
            celta.Fabricante = "Chevrolet";
            celta.Ano = 2012;
            Console.WriteLine($"{celta.Fabricante} {celta.Modelo} {celta.Ano}");

            Carro ka = new Carro("ka", "Ford", 2018);
            Console.WriteLine($"{ka.Fabricante} {ka.Modelo} {ka.Ano}");
        }
    }
}
