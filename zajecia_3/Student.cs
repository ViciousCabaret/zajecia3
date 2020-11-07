namespace zajecia_3
{
    public class Student:Osoba
    {
        private uint _nrIndeksu;

        public Student() : base("imie", "nazwisko")
        {
            this._nrIndeksu = 123;
        }

        public override string ToString()
        {
            return base.ToString() + " " + _nrIndeksu;
        }
    }
}