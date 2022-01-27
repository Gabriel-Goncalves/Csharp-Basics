using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {
    internal class PrimeiraExcecao {

        public class Conta {
            double Saldo;

            public Conta(double saldo) {
                Saldo = saldo;
            }

            public void Sacar(double valor) {
                if (valor > Saldo) {
                    throw new ArgumentException("Saldo insuficiente!");
                }

                Saldo -= valor;
            }
        }

        public static void Executar() {
            Conta conta = new Conta(1_234.34);

            try {
                int.Parse("adsfa");
                conta.Sacar(1_500);
                Console.WriteLine("Retirada bem sucedida!");
            } catch (ArgumentException ae) { // quando a excecao é especificada irá apenas cair dentro desse bloco caso seja de fato a excecao esperada, mas caso utilize o tipo generico vai cair independente do tipo do erro
                Console.WriteLine(ae.Message);
            } catch (Exception ex) {  // Exceção genérica qualquer erro lançado cai nesse caso, diferente dos especificados
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado!");  // finally sempre será executado
            }
        }
    }
}
