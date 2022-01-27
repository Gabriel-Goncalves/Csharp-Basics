using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesQueue {
        public static void Executar() {
            Queue<String> fila = new Queue<String>();
            fila.Enqueue("FIRST");
            fila.Enqueue("Second");
            fila.Enqueue("Third");

            Console.WriteLine(fila.Peek()); // retorna o primeiro elemento da fila sem remove-lo

            Console.WriteLine(fila.Count);  // Funciona como o Length retorna o tamanho da fila

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(4.14);

            Console.WriteLine();
            Console.WriteLine(salada.Contains("item"));  // verifica se existe "item" dentro da fila
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
