using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class planIshrane
    {
        List<Obrok> obroci;

        public planIshrane()
        {
            obroci = new List<Obrok>();
        }

        public void dodajObrok(Obrok o)
        {
            obroci.Add(o);
        }
        //fale dvije metode !!!!
    }
}
