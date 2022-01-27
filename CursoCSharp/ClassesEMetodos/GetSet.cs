using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class GetSet {

        public class Moto {
            private string Modelo;
            private string Marca;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada) {
                //Modelo = modelo;
                //Marca = marca;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }

            public Moto() {
            
            }

            public string GetMarca() {
                return Marca;
            }

            public void SetMarca(string marca) {
                Marca = marca;
            }

            public string GetModelo() {
                return Modelo;
            }

            public void SetModelo(string modelo) {
                Modelo = modelo;
            }

            public int GetCilindrada() {
                return Cilindrada;
            }

            public void SetCilindrada(int cilindrada) {
                Cilindrada = cilindrada;
            }

        }

        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetModelo("CG TITAN");
            moto2.SetMarca("Honda");
            moto2.SetCilindrada(-150);

            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
        }
    }
}
