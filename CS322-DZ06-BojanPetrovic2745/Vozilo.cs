using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06_BojanPetrovic2745
{
    abstract class Vozilo
    {

        public Vozilo(int id, double t, double m)
        {
            IdentifikacioniBroj = id;
            Tezina = t;
            MaksimalnaBrzina = m;
        }


        public abstract int IdentifikacioniBroj {
            get; set;
        }

        public abstract double Tezina
        {
            get; set;
        }

        public abstract double MaksimalnaBrzina
        {
            get; set;
        }

        public abstract void PrintVozilo();
    }
}
