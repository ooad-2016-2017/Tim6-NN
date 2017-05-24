using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iGym
{
    public class Trener : Zaposlenik
    {
        
        List<ProgramVjezbanja> programi;

        public Trener(string i, string p, DateTime d, string a, string br, double pl) : base(i,p,d,a,br,pl)
        {
            
            programi = new List<ProgramVjezbanja>();
        }  
    }
}
