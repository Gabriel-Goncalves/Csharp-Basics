using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);  // Não consegue acessar pois é protected e so é reconhecido por herança ou na própria classe
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);  // Consegue acessar pq por mais que seja protected também é internal que é visto dentro do projeto
            //Console.WriteLine(amiga.SegredoFamilia); // Não consegue acessar pois é do tipo private protected, só vista dentro da própria classe ou por herança
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); // Não consegue acessar pois é do tipo private, visualizado apenas dentro da própria classe
        }
    }
}
