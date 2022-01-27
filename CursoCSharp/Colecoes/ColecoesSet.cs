using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesSet {
        public static void Executar() {
            Produto livro = new Produto("Game of Thrones", 49.90);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);  // adiciona o produto a lista

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 28.9),
                new Produto("8 Temporada GoT", 45.99),
                new Produto("Poster", 10),
            };

            carrinho.UnionWith(combo);  // adiciona todos os elementos que estao em combo a carrinho
            Console.WriteLine(carrinho.Count);  // quantos elementos tem o carrinho
            //carrinho.RemoveAt(2);  // Remover por index

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }
            //Console.WriteLine(carrinho.LastIndexOf(livro));  // qual a ultima posicao que livro aparece
        }
    }
}
