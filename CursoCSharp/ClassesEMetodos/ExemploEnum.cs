using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExemploEnum {

        public enum Week { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};

        public class Agenda {
            public string Tarefa;
            public Week WeekDay;
        }
        public static void Executar() {
            int id = (int)Week.Segunda;
            Console.WriteLine(id);

            var minhaAgenda = new Agenda();
            minhaAgenda.Tarefa = "Comprar Pão";
            minhaAgenda.WeekDay = Week.Segunda;

            Console.WriteLine($"A tarefa de {minhaAgenda.WeekDay} é: {minhaAgenda.Tarefa}");
        }
    }
}
