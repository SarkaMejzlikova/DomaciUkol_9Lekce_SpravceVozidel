using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_9Lekce_SpravceVozidel
{
    public class Automobil : Vozidlo
    {
        // properties
        public readonly int PocetDveri;
        public readonly string Model;

        // constructor
        public Automobil(int pocetDveri, string model, int rokVyroby, string barva) : base("Automobil", rokVyroby, barva)
        {
            PocetDveri = pocetDveri;
            Model = model;
        }
    }
}
