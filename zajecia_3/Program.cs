using System;

namespace zajecia_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string imie = "imie";
            string nazwisko = "nazwisko";
            uint indeks = 123;
            
            Osoba example1 = new Osoba(imie, nazwisko);
            Osoba example2 = new Student(imie, nazwisko, indeks);
            Student example3 = new Student(imie, nazwisko, indeks);

            Console.WriteLine(example1.ToString());
            Console.WriteLine(example2.ToString());
            Console.WriteLine(example3.ToString());
            
            Osoba[] osoby = new Osoba[3];
            
            osoby[0] = example1;
            osoby[1] = example2;
            osoby[2] = example3;

            foreach (Osoba osoba in osoby)
            {
                Console.WriteLine(osoba.ToString());
            }
        }
    }
}