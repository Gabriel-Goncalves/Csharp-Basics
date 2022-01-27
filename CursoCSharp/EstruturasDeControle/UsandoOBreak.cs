using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoOBreak {
        public static void Executar() {
            Random r = new Random();

            int numero = r.Next(1, 51);

            for (int i = 0; i <= 50; i++) {
                Console.WriteLine($"{i} é o número que queremos?");
                if (numero == i) {
                    Console.WriteLine("Sim!");
                    break; // o break fica associado apenas ao laço de repetição e nao ao bloco ou esturura que o envolve 
                } else {
                    Console.WriteLine("Não");
                }
            }
        }
    }
}
