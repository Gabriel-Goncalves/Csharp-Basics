using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_433_033.89;
        }
    }

    //class SouFilho : SemFilho { }  // Não é possível

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() {
        //    return false;
        //}
    }

    internal class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
