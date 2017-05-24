using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class ProgramVjezbanja
    {
        List<Vjezba> vjezbe;
        public ProgramVjezbanja()
        {
            vjezbe = new List<Vjezba>();
        }

        public void dodajVjezbu(Vjezba v)
        {
            vjezbe.Add(v);
        }
    }
}
