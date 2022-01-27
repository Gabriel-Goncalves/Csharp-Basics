using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) { 
            Nome = nome;
            Preco = preco;
        }

        //public override bool Equals(object obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
    }
    internal class ColecoesList {
        public static void Executar() {
            Produto livro = new Produto("Game of Thrones", 49.90);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);  // adiciona o produto a lista

            var combo = new List<Produto> {
                new Produto("Camisa", 28.9),
                new Produto("8 Temporada GoT", 45.99),
                new Produto("Poster", 10),
            };

            carrinho.AddRange(combo);  // adiciona todos os elementos que estao em combo a carrinho
            Console.WriteLine(carrinho.Count);  // quantos elementos tem o carrinho
            carrinho.RemoveAt(2);  // Remover por index

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }
            Console.WriteLine(carrinho.LastIndexOf(livro));  // qual a ultima posicao que livro aparece
        }
    }
}
