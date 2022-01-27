using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            bool tercaCerto = false;
            bool quintaCerto = false;

            bool comprouTv50 = tercaCerto && quintaCerto;
            Console.WriteLine($"Comprou TV 50: {comprouTv50}");

            bool comprouSorvete = tercaCerto || quintaCerto;
            Console.WriteLine($"Comprou Sorvete: {comprouSorvete}");

            bool comprouTV32 = tercaCerto ^ quintaCerto;
            Console.WriteLine($"Comprou TV 32: {comprouTV32}");
        }
    }
}
