using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MetodosComRetorno {
        class CalculadoraComum {
            public int Somar (int a, int b) {
                return a + b;
            }

            public int Subtrair(int a, int b) {
                return a - b;
            }

            public int Multiplicar(int a, int b) {
                return a * b;
            }
        }

        class CalculadoraCadeia {
            int memoria;

            public CalculadoraCadeia Somar (int a) {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a) {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar() {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir() {
                Console.WriteLine(memoria);
                return this;
            }

            public int Resultado() {
                return memoria;
            }
        }

        public static void Executar() {
            CalculadoraComum calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 10);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(4, 8));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            CalculadoraCadeia calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
        }
    }
}
