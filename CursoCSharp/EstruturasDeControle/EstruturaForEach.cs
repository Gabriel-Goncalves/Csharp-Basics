using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            string palavra = "Opa!";

            foreach (char letter in palavra) {
                Console.WriteLine(letter);
            }

            var alunos = new String[] { "Ana", "Bia", "Carlos" };
            foreach (string student in alunos) { 
                Console.WriteLine(student);
            }
        }
    }
}
