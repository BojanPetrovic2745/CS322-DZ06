using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06_BojanPetrovic2745
{
    class Automobil : Vozilo
    {

        private int maksimalniBrojPutnika;

        public Automobil(int id, double t, double m) : base(id, t, m)
        {

        }

        public int MaksimalniBrojPutnika
        {
            get { return maksimalniBrojPutnika; }
            set { maksimalniBrojPutnika = value; }
        }

        public override double Tezina { get; set; }
        public override double MaksimalnaBrzina { get; set; }
        public override int IdentifikacioniBroj { get; set; }

        public override void PrintVozilo()
        {
            Console.WriteLine(IdentifikacioniBroj + " " + Tezina + " " + MaksimalnaBrzina + " " + MaksimalniBrojPutnika);
        }


    }
}
