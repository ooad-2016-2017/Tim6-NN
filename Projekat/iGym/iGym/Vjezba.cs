using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Vjezba
    {
        string naziv;

        public Vjezba(string n)
        {
            Naziv = n;
        }
        public Vjezba()
        { }

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
    }
}
