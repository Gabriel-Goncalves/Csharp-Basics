using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNum) {
            return num + outroNum;
        }

        public static int Subtracao(this int num, int outroNum) {
            return num - outroNum;
        }

    }

    internal class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(20.Soma(10));

            Console.WriteLine(numero.Subtracao(1));
            Console.WriteLine(10.Subtracao(7));
        }
    }
}
