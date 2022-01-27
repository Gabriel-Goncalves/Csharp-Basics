using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class LINQ1 {
        public static void Executar() {
            List<Aluno> alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota=8.0 },
                new Aluno() { Nome = "André", Idade = 21, Nota=4.3 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota=9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota=8.5 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota= 7.7 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota=6.8 },
            };

            Console.WriteLine("===== APROVADOS ======");
            var aprovados = alunos.Where(a => (a.Nota >= 7)).OrderBy(a => a.Nome);  // filter

            foreach (Aluno aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }


            Console.WriteLine("\n\n ======== CHAMADA =================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach(var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n===== APROVADOS (Por Idade) ==================");
            var alunosAprovados =  // Lista de strings
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade   // ordena por idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
