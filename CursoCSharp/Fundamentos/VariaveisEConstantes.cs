using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14159;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = false;
            bool estaNevando = true;

            Console.WriteLine("Está chovendo? " + estaChovendo + " Está nevando: " + estaNevando);

            byte idade = 40;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGol = sbyte.MinValue;
            Console.WriteLine("Saldo de gol é " + saldoDeGol);

            short salario = short.MaxValue;
            Console.WriteLine("Seu salário futuro vai ser: " + salario);

            int menorValorInt = int.MinValue;
            int maiorValorInt = int.MaxValue;

            Console.WriteLine("Menor valor int: " + menorValorInt + " Maior valor int: " + maiorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populção Mundial" + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador: " + precoComputador);

            double precoMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple: " + precoMercadoApple);

            decimal distanciaEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre estrelas: " + distanciaEstrelas);


            char letra = 'b';
            Console.WriteLine("a letra é: " + letra);

            string sentenca = "minha sentença";
            Console.WriteLine("o texto é: " + sentenca);


        }
    }
}
