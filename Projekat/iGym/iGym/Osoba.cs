using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public abstract class Osoba
    {
        string ime;
        string prezime;
        DateTime datumRodjenja;
        string adresa;
        string kontaktTelefon;

        public Osoba()
        { }
        public Osoba(string i, string p, DateTime d, string a, string br)
        {
            Ime = i;
            Prezime = p;
            DatumRodjenja = d;
            Adresa = a;
            KontaktTelefon = br;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return Prezime1;
            }

            set
            {
                Prezime1 = value;
            }
        }

        public string Prezime1
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string KontaktTelefon
        {
            get
            {
                return kontaktTelefon;
            }

            set
            {
                kontaktTelefon = value;
            }
        }
    }
}
