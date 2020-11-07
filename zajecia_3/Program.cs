using System;

namespace zajecia_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Osoba example1 = new Osoba();
            Osoba example2 = new Student();
            Student example3 = new Student();

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