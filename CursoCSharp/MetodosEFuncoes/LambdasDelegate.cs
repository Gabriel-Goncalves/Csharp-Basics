using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class LambdasDelegate {

        delegate double Operacao(double x, double y);

        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao multi = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(sum(10, 5));
            Console.WriteLine(sub(10, 5));
            Console.WriteLine(multi(10, 5));
            Console.WriteLine(div(10, 5));
        }
    }
}
