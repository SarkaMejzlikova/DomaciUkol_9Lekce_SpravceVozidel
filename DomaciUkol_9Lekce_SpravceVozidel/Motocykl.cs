using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_9Lekce_SpravceVozidel
{
    public class Motocykl : Vozidlo  
    {
        // properties
        public readonly string TypMotocyklu;
        public readonly int PocetKol;

        // constructor
        public Motocykl(string typMotockylu, int pocetKol, int rokVyroby, string barva) : base("Motocykl", rokVyroby, barva)
        {
            TypMotocyklu = typMotockylu;
            PocetKol = pocetKol;

        }
    }
}
