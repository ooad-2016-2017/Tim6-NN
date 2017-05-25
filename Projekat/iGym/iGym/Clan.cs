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
        DateTime posljednjaUplataClanarine;
        double iznosClanarine;
        int registracijskiBroj;

        public Clan(string i, string p, DateTime d, string a, string br, DateTime cl, double iznos): base(i,p,d,a,br)
        {
            PosljednjaUplataClanarine = cl;
            IznosClanarine = iznos;
            RegistracijskiBroj = dajNoviRegBr();
        }
        public void postaviKorisnickoImeISifru(string ime, string sifra)
        {
            KorisnickoIme = ime;
            Sifra = sifra;
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

        public DateTime PosljednjaUplataClanarine
        {
            get
            {
                return posljednjaUplataClanarine;
            }

            set
            {
                posljednjaUplataClanarine = value;
            }
        }

        public double IznosClanarine
        {
            get
            {
                return iznosClanarine;
            }

            set
            {
                iznosClanarine = value;
            }
        }

        public int RegistracijskiBroj
        {
            get
            {
                return registracijskiBroj;
            }

            set
            {
                registracijskiBroj = value;
            }
        }

        int dajNoviRegBr()
        {
            return regBr++;
        }

        

    }
}
