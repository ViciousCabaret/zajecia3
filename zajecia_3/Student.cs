namespace zajecia_3
{
    public class Student:Osoba
    {
        private uint _nrIndeksu;

        public Student(string imie, string nazwisko, uint index) : base(imie, nazwisko)
        {
            this._nrIndeksu = index;
        }

        public override string ToString()
        {
            return base.ToString() + " " + _nrIndeksu;
        }
    }
}