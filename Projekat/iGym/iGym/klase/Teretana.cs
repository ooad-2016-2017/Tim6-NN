using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Teretana
    {
        String admin = "admin";
        String sifra = "sifra";
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

        public void RegistrujNovogClana(string ime, string prezime, DateTime d, string a, string br, DateTime cl, double iznos)
        {
            if (ProvjeriPostojiLiClan(ime, prezime, d)) throw new Exception("Clan vec postoji!");
            Clan c = new Clan(ime, prezime, d, a, br, cl, iznos);
            dodajClana(c);
        }

        public void UplataClanarine(int registracijskiBroj)
        {
            bool b = false;
            foreach (Clan x in clanovi)
            {
                if(x.RegistracijskiBroj == registracijskiBroj)
                {
                    x.PosljednjaUplataClanarine = DateTime.Now;
                    b = true;
                    break;
                }
            }
            if (!b) throw new Exception("Nije pronadjen korisnik s tim registracijskim brojem");
        }

        public int VratiRegistracijskiBrojClana(string i, string p, DateTime d)
        {
            foreach(Clan x in clanovi)
            {
                if (x.Ime == i && x.Prezime == p && x.DatumRodjenja == d)
                {
                    return x.RegistracijskiBroj;
                }
            }
            throw new Exception("Nije pronadjen korisnik s tim reg. br");
        }

        
        public Boolean ProvjeriPostojiLiClan(string ime, string prezime, DateTime d)
        {
            foreach (Clan x in clanovi)
            {
                if (x.Ime == ime && x.Prezime == prezime && x.DatumRodjenja == d) return true;
            }
            return true;
        }

        public Boolean provjeriPostojiLiKorisnickoIme(string ime)
        {
            foreach (Clan x in clanovi)
            {
                if (x.KorisnickoIme == ime ) return true;
            }
            return true;
        }
        
        public Boolean provjeriPristupnePodatke(string ime, string sifra)
        {
            foreach(Clan x in clanovi)
            {
                if(x.KorisnickoIme==ime)
                {
                    if (x.Sifra == sifra)
                        return true;
                    else throw new Exception("Neispravna sifra.");
                }
            }
            throw new Exception("Neispravno korisnicko ime.");
        }
    }
}
