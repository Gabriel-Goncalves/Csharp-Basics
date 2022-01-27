using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Arrays {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Gabriel";
            alunos[1] = "Bia";
            alunos[2] = "João";
            alunos[3] = "Lucas";
            alunos[4] = "Felipe";

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (double nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine($"Média: {media}");

            char[] letras = { 'G', 'a', 'b', 'r', 'i', 'e', 'l' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
