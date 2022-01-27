using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pe in pessoas) {
                Console.WriteLine($"Olá {pe}");
            }
        }
        public static void Executar () {
            Recepcionar("José", "Irineu");
        }
    }
}
