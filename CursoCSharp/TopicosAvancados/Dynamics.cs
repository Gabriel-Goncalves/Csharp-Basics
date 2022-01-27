using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";  // mesmo recebendo uma string a variável nao fica amarrada a esse tipo
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Nome = "Maria Julia";
            aluno.Nota = 9.8;
            Console.WriteLine($"{aluno.Nome} tirou nota {aluno.Nota}");
        }
    }
}
