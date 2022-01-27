using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random r = new Random();

            int numeroSecreto = r.Next(1, 16);
            bool numeroEncontrado = false;

            int tentativasRestante = 5;
            int tentativas = 0;

            while (tentativasRestante > 0 && !numeroEncontrado) {
                Console.WriteLine("Digite um número");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;
                tentativasRestante--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Número encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                } else if (numeroSecreto < palpite) {
                    Console.WriteLine("Menor... Tente Novamente!");
                    Console.WriteLine($"Você possui {tentativas} tentativas");
                } else {
                    Console.WriteLine("Maior... Tente Novamente!");
                    Console.WriteLine($"Você possui {tentativas} tentativas");
                }
            }
        }
    }
}
