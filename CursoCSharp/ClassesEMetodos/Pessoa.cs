using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return $"Eu sou o {Nome} e tenho {Idade}";
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
