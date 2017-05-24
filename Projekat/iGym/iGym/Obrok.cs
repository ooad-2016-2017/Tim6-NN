using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Obrok 
    {
        string naziv;
        string opis;

        public Obrok() { }
        public Obrok(string n, string o )
        {
            Naziv = n;
            Opis = o;
        }
        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }
    }
}
