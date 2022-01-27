using System;
using Encapsulamento;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido....");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular); // Por ser internal não tem acesso fora do projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia); // Apenas dentro da classe ou por herança no mesmo projeto
            //Console.WriteLine(UsaMuitoPhotoshop); // apenas na mesma classe pois é private
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos); // Não acessivel pois é do tipo protected apenas por herança
            //Console.WriteLine(amigo.NumeroDoCelular);  // Não acessível pois é internal e so visto dentro do projeto
            //Console.WriteLine(amigo.JeitoDeFalar);  // Não acessivel pois só é visto dentro do projeto por herança
            //Console.WriteLine(amigo.SegredoFamilia); // Não acessivel pois é private protected apenas na mesma classe ou por herança no mesmo projeto
            //Console.WriteLine(amigo.UsaMuitoPhotoshop); // Não acessível pois é private, apenas dentro da Classe
        }

    }

    internal class Encapsulamento {

        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();
            
            Console.WriteLine();
            
            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine();
            new AmigoProximo().MeusAcessos();

            Console.WriteLine();

            new FilhoNaoReconhecido().MeusAcessos();
            Console.WriteLine();
            new AmigoDistante().MeusAcessos();


        }
    }
}
