using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.API {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ?
                Environment.GetEnvironmentVariable("HOME")
                :
                Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            Console.WriteLine("aqui: ", home);
            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo {
        public static void Executar() {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
        }
    }
}
