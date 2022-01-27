using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Nullables {
        public static void Executar() {
            Nullable<int> num1 = null;  // dessa forma é possível atribuir um valor nula a variável
            int? num2 = null;  // mesmo resultado da de cima.

            //int num3 = null;  // não funciona porque int nao aceita null

            if(num1.HasValue) {
                Console.WriteLine("Valor de num: {0}", num1);
            } else {
                Console.WriteLine($"A variável não possui valor.");
            }

            int valor = num1 ?? 1_000_000;
            Console.WriteLine($"Valor valor??: {valor}");
        }
    }
}
