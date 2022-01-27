using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    internal class LINQ2 {
        public static void Executar() {
            List<Aluno> alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota=8.0 },
                new Aluno() { Nome = "André", Idade = 21, Nota=4.3 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota=9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota=8.5 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota= 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota= 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota=6.8 },
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));  // caso não ache da um erro
            Console.WriteLine($"{pedro.Nome}: {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); // recebe null pois não irá encontrar

            if (fulano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var anaFirst = alunos.First(aluno => aluno.Nome.Equals("Ana"));  // Dessa forma da erro caso nao encontre
            Console.WriteLine($"{anaFirst.Nome}: {anaFirst.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("adfad"));  // Dessa forma não da erro e assume o null como valor
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            } else {
                Console.WriteLine($"{sicrano.Nome}: {sicrano.Nota}");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome == "Ana");
            if (outraAna == null) {
                Console.WriteLine("Aluno Inexistente");
            } else {
                Console.WriteLine($"{outraAna.Nome}: {outraAna.Nota}");
            }

            var exemploSkip = alunos.Skip(1).Take(3); // Pula 1 e pega os próximos 3
            foreach(var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota); // RETORNA A MAIOR NOTA
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota); // RETORNA A MENOR NOTA
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);  // RETORNA O SOMATÓRIO DE TODAS AS NOTAS
            Console.WriteLine($"Somatório notas: {somatorioNotas}");

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);  // RETORNA A MÉDIA DE TODAS AS NOTAS
            Console.WriteLine($"Média da turma {mediaDaTurma.ToString("F2")}");

            var mediaAlunosAprovados = alunos.Where(aluno => aluno.Nota >= 7).Average(aluno => aluno.Nota); // RETORNA A MÉDIA DAS NOTAS QUE SÃO MAIORES QUE 7
            Console.WriteLine($"Média alunos aprovados {mediaAlunosAprovados}");
        }
    }
}
