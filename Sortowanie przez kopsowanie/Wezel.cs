namespace Sortowanie_przez_kopsowanie
{
    internal class Wezel
    {
        public int value;
        public Wezel rodzic;
        public Wezel dzieckoL;
        public Wezel dzieckoP;

        public Wezel(int value = 0)
        {
            this.value = value;
        }

        public Wezel Dodaj(int n)
        {
            if (dzieckoL == null)
            {
                dzieckoL = new Wezel(n);
                dzieckoL.rodzic = this;
                return dzieckoL;
            }
            else if (dzieckoP == null)
            {
                dzieckoP = new Wezel(n);
                dzieckoP.rodzic = this;
                return dzieckoP;
            }
            throw new InvalidOperationException("Proba dodania do wezla, ktory ma juz dwoje dzieci.");
        }
    }
}
