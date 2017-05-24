using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Clan : Osoba
    {
        static int regBr=100;
        string korisnickoIme;
        string sifra;
        int registracijskiBroj;

        public Clan(string i, string p, DateTime d, string a, string br, string kor, string sif): base(i,p,d,a,br)
        {
            KorisnickoIme = kor;
            Sifra = sif;
            registracijskiBroj = dajNoviRegBr();
        }

        public string KorisnickoIme
        {
            get
            {
                return korisnickoIme;
            }

            set
            {
                korisnickoIme = value;
            }
        }

        public string Sifra
        {
            get
            {
                return sifra;
            }

            set
            {
                sifra = value;
            }
        }

        int dajNoviRegBr()
        {
            return regBr++;
        }

        

    }
}
