using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_9Lekce_SpravceVozidel
{
    public class Vozidlo
    {
        // properties
        public readonly string TypVozidla;
        public readonly int RokVyroby;
        public readonly string Barva;

        // constructor
        public Vozidlo(string typVozidla, int rokVyroby, string barva)
        {
            TypVozidla = typVozidla;
            RokVyroby = rokVyroby;
            Barva = barva;
        }
    }
}
