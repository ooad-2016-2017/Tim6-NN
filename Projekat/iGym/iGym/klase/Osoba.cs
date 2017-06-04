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
                if (Validacije.OsobaJelIspravnoIme(value))
                    ime = value;
                else throw new Exception("Ime nije validno");
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                if (Validacije.OsobaJelIspravnoPrezime(value))
                    prezime = value;
                else throw new Exception("Prezime nije validno");
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
                if (Validacije.OsobaJelIspravnaAdresa(value))
                    adresa = value;
                else throw new Exception("Adresa nije validna");
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
                if (Validacije.OsobaJelIspravanBrTel(value))
                    kontaktTelefon = value;
                else throw new Exception("Br.tel nije validan");
                
            }
        }
    }
}
