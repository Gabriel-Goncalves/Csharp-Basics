﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {
    internal class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtd");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
                try {
                    using (StreamReader sr = new StreamReader(path)) {
                        var texto = sr.ReadToEnd();
                        Console.WriteLine(texto);
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
