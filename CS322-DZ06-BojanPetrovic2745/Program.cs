using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ06_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil v1 = new Automobil(1, 1500.0, 90.0);

            v1.MaksimalniBrojPutnika = 7;

            v1.PrintVozilo();

            Kamion v2 = new Kamion(2, 3500.0, 100.0);

            v2.MaksimalnaTezinaTereta = 300.0;

            v2.PrintVozilo();


            Avion v3 = new Avion(3, 1300.0, 400.0);

            v3.MaksimalnaVisina = 600;
            v3.RasponKrila = 10;

            v3.PrintVozilo();

            Vozilo v4 = new Automobil(4, 2000.0, 120.0);

            /*
              ovde nemamo pristup maksimalnom broju putnika, 
                    a to je zato što je to vidljivo samo u Automobilu ( ovde je osnovni tip Vozilo ).
             
             */

            v4.PrintVozilo();

        }
    }
}
