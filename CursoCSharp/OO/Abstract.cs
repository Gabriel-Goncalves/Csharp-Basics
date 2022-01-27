using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    internal class Abstract {

        public abstract class Celular {
            public abstract string Assistente();

            public string Tocar() {
                return "Trim Trim Trim";
            }
        }

        public class Samsung : Celular {
            public override string Assistente() {
                return "Olá! Meu nome é Bixby";
            }
        }

        public class Iphone : Celular {
            public override string Assistente() {
                return "Olá! Meu nome é Siri";
            }
        }

        public static void Executar() {
            List<Celular> celulares = new List<Celular> ();
            celulares.Add (new Samsung ());
            celulares.Add(new Iphone ());

            foreach(Celular c in celulares) {
                Console.WriteLine(c.Assistente());
            }
        }
    }
}
