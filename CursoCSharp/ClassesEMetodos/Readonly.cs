using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento() {
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }

    internal class Readonly {
        public static void Executar() {
            Cliente novoCliente = new Cliente("Gabriel Gonçalves", new DateTime(1998, 5, 28));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}
