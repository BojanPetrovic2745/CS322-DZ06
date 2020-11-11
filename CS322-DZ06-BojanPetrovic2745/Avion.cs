using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06_BojanPetrovic2745
{
    class Avion : Vozilo
    {

        private double maksimalnaVisina;
        private double rasponKrila;

        public override double Tezina { get; set; }
        public override double MaksimalnaBrzina { get; set; }
        public override int IdentifikacioniBroj { get; set; }

        public Avion(int d, double m, double n) : base(d, m, n) { }

        public double MaksimalnaVisina
        {
            get { return maksimalnaVisina; }
            set { maksimalnaVisina = value; }
        }

        public double RasponKrila
        {
            get { return rasponKrila; }
            set { rasponKrila = value; }
        }

        public override void PrintVozilo()
        {
            Console.WriteLine(IdentifikacioniBroj + " " + Tezina + " " + MaksimalnaBrzina + " " + MaksimalnaBrzina + " " + RasponKrila);
        }


    }
}
