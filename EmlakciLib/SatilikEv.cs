namespace EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv() { }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış Fiyat:{this.Satisfiyat}";
        }
    }
}
