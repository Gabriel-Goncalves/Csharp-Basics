using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class UsandoDelegate {

        delegate double Soma(double a, double b);  // como se fosse uma interface
        delegate void ImprimirSoma(double a, double b);  // como se fosse uma interface

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma;
            ImprimirSoma op2 = MeuImprimirSoma;

            Console.WriteLine(op1(2,3));
            op2(5, 8);
        }
    }
}
