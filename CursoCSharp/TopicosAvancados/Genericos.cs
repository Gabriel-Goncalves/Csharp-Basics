using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {

    // Essa classe está totalmente genérica, pois o T está aberto, podendo ser definido na herança ou no momento de instanciar a classe
    public class Caixa<T> {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0,2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    // Ao instanciar dessa forma está sendo definido que T é do tipo int
    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) {

        }
    }

    // Ao instanciar dessa forma está sendo definido que T é do tipo string
    class CaixaString : Caixa<string> {
        public CaixaString() : base("string") {

        }
    }

    internal class Genericos {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("método"));
            Console.WriteLine(caixa2.Coisa.GetType());
        }
    }
}
