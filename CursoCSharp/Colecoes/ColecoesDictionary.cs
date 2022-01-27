using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesDictionary {
        public static void Executar () {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Spider Man");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine($"2004: {filmes[2004]}");
                Console.WriteLine($"2004: {filmes.GetValueOrDefault(2008)}"); // caso nao exista não irá gerar um erro e sim apenas retornará um valor vazio de acordo com o tipo de variável que no caso é uma string vazia
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2016, out string filme2016);
            Console.WriteLine("Filme 2016: " + filme2016);

            // Formas de percorrer um dictionary

            Console.WriteLine("CHAVES");
            // Apenas as chaves
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            Console.WriteLine();

            Console.WriteLine("VALORES");
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            Console.WriteLine();

            Console.WriteLine("CHAVE E VALOR");
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
