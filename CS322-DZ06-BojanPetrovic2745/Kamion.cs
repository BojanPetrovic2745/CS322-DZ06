using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06_BojanPetrovic2745
{
    class Kamion : Vozilo
    {
        private double maksimalnaTezinaTereta;
        
        public Kamion(int d, double s, double m): base(d, s, m) { }

        public override double Tezina { get; set; }
        public override double MaksimalnaBrzina { get; set; }
        public override int IdentifikacioniBroj { get; set; }

        public double MaksimalnaTezinaTereta
        {
            get { return maksimalnaTezinaTereta; }
            set { maksimalnaTezinaTereta = value; }
        }

        public override void PrintVozilo()
        {
            Console.WriteLine(IdentifikacioniBroj + " " + Tezina + " " + MaksimalnaBrzina + " " + MaksimalnaTezinaTereta);
        }
    }
}
