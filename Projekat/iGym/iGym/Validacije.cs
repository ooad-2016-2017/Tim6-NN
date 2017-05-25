using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public static class Validacije
    {
        public static Boolean OsobaJelIspravnoIme(string ime)
        {
            if (ime == "" || ime.Length>20 || ime.Any(char.IsDigit)) return false;

            return true;
        }
        public static Boolean OsobaJelIspravnoPrezime(string prezime)
        {
            if (prezime == "" || prezime.Length > 20 || prezime.Any(char.IsDigit)) return false;

            return true;
        }
        public static Boolean OsobaJelIspravnaAdresa(string adresa)
        {
            if (adresa == "") return false;
            return true;
        }

        public static Boolean OsobaJelIspravanBrTel(string br)
        {
            if (br == "" || br.Length > 10) return false;
            return true;
        }

    }
}
