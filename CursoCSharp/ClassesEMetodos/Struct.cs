using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    internal class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 3;

            Console.WriteLine($"Inicial X: {coordenadaInicial.X}, Y: {coordenadaInicial.Y}");

            Console.WriteLine();
            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);
            
            Console.WriteLine($"Final X: {coordenadaFinal.X}, Y: {coordenadaFinal.Y}");
        }
    }
}
