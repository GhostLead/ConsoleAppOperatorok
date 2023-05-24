using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOperatorok
{
    internal class Kifejezesek
    {

        int szam1;
        string szoveg;
        int szam2;

        public Kifejezesek(string TXTsor) {

            var mezok = TXTsor.Split();
            this.szam1 = int.Parse(mezok[0]);
            this.szoveg = mezok[1];
            this.szam2 = int.Parse(mezok[2]);

        }
        public Kifejezesek(int szam1, string szoveg, int szam2)
        {
            this.szam1 = szam1;
            this.szoveg = szoveg;
            this.szam2 = szam2;
        }

        public int Szam1 { get => szam1; set => szam1 = value; }
        public string Szoveg { get => szoveg; set => szoveg = value; }
        public int Szam2 { get => szam2; set => szam2 = value; }
    }
}
