using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElse {
        public static void Executar () {
            double nota = 7.0;

            if (nota >= 7) {
                Console.WriteLine("Aprovado!");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
