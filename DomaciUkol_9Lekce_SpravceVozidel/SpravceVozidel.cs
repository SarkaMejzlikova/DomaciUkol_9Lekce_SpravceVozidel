using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_9Lekce_SpravceVozidel
{
    public class SpravceVozidel
    {
        List<Vozidlo> vozidla = new List<Vozidlo>();

        public void NoveAuto()
        {
            Console.WriteLine("Zadejte následující údaje:");
            
            Console.Write("Model: ");
            string m = Console.ReadLine();
            
            Console.Write("Rok výroby: ");
            string rokV = Console.ReadLine();
            int rv;
            while(!Int32.TryParse(rokV, out rv) || rv < 1989 || rv > DateTime.Now.Year)
            {
                Console.WriteLine("Nezadali jste správný rok výroby, zkuste to znovu.");
                rokV = Console.ReadLine();
            }

            Console.Write("Barva: ");
            string b = Console.ReadLine();
            
            Console.Write("Počet dveří: ");
            string pocetD = Console.ReadLine();
            int pd;
            while (!Int32.TryParse(pocetD, out pd) || pd < 3 || pd > 5)
            {
                Console.WriteLine("Nezadali jste správný počet dveří, zkuste to znovu.");
                pocetD = Console.ReadLine();
            }

            Automobil auto = new Automobil( model: m, pocetDveri: pd, rokVyroby: rv, barva: b);
            vozidla.Add(auto);
        }

        public void NovyMotocykl()
        {
            Console.WriteLine("Zadejte následující údaje:");

            Console.Write("Typ Motocyklu: ");
            string tm = Console.ReadLine();

            Console.Write("Rok výroby: ");
            string rokV = Console.ReadLine();
            int rv;
            while (!Int32.TryParse(rokV, out rv) || rv < 1989 || rv > DateTime.Now.Year)
            {
                Console.WriteLine("Nezadali jste správný rok výroby, zkuste to znovu.");
                rokV = Console.ReadLine();
            }

            Console.Write("Barva: ");
            string b = Console.ReadLine();

            Console.Write("Počet kol: ");
            string pocetK = Console.ReadLine();
            int pk;
            while (!Int32.TryParse(pocetK, out pk) || pk < 1 || pk > 3)
            {
                Console.WriteLine("Nezadali jste správný počet kol, zkuste to znovu.");
                pocetK = Console.ReadLine();
            }

            Motocykl moto = new Motocykl( typMotockylu: tm, pocetKol: pk, rokVyroby: rv, barva: b );
            vozidla.Add(moto);
        }

        public void VypisVozidel()
        {
            Console.WriteLine("Seznam vozidel je následující:\n");
            foreach (var v in vozidla)
            {
                if(v is Automobil)
                {
                    Automobil a = (Automobil)v;
                    Console.WriteLine(a.TypVozidla + " - Model: " + a.Model + "; Rok výroby: " + a.RokVyroby + "; Barva: " + a.Barva + "; Počet dveří: " + a.PocetDveri + ";");
                }
                else if (v is Motocykl)
                {
                    Motocykl m = (Motocykl)v;
                    Console.WriteLine(m.TypVozidla + " - Typ motocyklu: " + m.TypMotocyklu + "; Rok výroby: " + m.RokVyroby + "; Barva: " + m.Barva + "; Počet kol: " + m.PocetKol);
                }

            }
        }

    }
}
