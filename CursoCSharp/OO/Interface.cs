using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };

        public String ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var op in operacoes) {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n\n";
            }

            return resultado;
        }

    }

    internal class Interface {
        public static void Executar() {
            Calculadora calc = new Calculadora();

            var resultado = calc.ExecutarOperacoes(10, 5);
            Console.WriteLine(resultado);
        }
    }
}
