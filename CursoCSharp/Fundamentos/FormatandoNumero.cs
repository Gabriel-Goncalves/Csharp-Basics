using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 5.175;
            Console.WriteLine(valor.ToString("F3")); // 3 casas após a vírgula
            Console.WriteLine(valor.ToString("C"));  // coloca o R$ antes C de currencies
            Console.WriteLine(valor.ToString("P"));  // % no final
            Console.WriteLine(valor.ToString("#.##"));  // qual o formato específico

            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));
            Console.WriteLine(valor.ToString("C2", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // completa com zeros a esquerda para que  o total dê 10 caracteres

        }
    }
}
