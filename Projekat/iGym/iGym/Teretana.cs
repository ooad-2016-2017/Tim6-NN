using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Teretana
    {
        List<Trener> treneri;
        List<Clan> clanovi;
        List<ProgramVjezbanja> programi;

        public Teretana()
        {
            treneri = new List<Trener>();
            clanovi = new List<Clan>();
            programi = new List<ProgramVjezbanja>();
        }

        public void dodajClana(Clan c)
        {
            clanovi.Add(c);
        }
        public void dodajTrenera(Trener t)
        {
            treneri.Add(t);
        }
        public void dodajProgramVjezbanja(ProgramVjezbanja p)
        {
            programi.Add(p);
        }
    }
}
