using System;
using System.Runtime.InteropServices;

namespace zajecia_3
{
    public class Osoba
    {
        private string _imie;
        private string _nazwisko;
        
        public Osoba(string imie, string nazwisko)
        {
            this._imie = imie;
            this._nazwisko = nazwisko;
        }

        public Osoba()
        {
            this._imie = "paramless imie";
            this._nazwisko = "paramless nazwisko";
        }

        public override string ToString()
        {
            return _imie + " " + _nazwisko;
        }
    }
}