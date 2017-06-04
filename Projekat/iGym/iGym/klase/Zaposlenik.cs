using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
     public class Zaposlenik : Osoba
    {
        double plata;

        public double Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }

        protected Zaposlenik(string i, string p, DateTime d, string n, string h, double pl) : base(i, p, d, n, h)
        {
            Plata = pl;
        }
        protected Zaposlenik() { }

    }
}
