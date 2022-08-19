using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_Programirnaje_projekat___program
{
    class Termin
    {
        private string ime_prezime;
        private string tablica_Grad;
        private int tablica_Broj;
        private string tablica_Slova;
        private DateTime datum;

        public string Ime_prezime   { get { return ime_prezime; }set { ime_prezime = value; } }
        public string Tablica_Grad  { get { return tablica_Grad; } set { tablica_Grad = value; } }
        public int Tablica_Broj     { get { return tablica_Broj; } set { tablica_Broj = value; } }
        public string Tablica_Slova { get { return tablica_Slova; } set { tablica_Slova = value; } }
        public DateTime Datum       { get { return datum; } set { datum = value; } }

        public Termin() { }

        public Termin(string impr,string tabG,int tabB,string tabS, DateTime dat)
        {
            ime_prezime = impr;
            tablica_Grad = tabG;
            Tablica_Broj = tabB;
            tablica_Slova = tabS;
            datum = dat;
        }
    }
}
