using EmlakciLib;

namespace Emlakci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KiralikEv k1 = new KiralikEv(2000, 1000, 3, "KiralikEv", 2, 100);
            KiralikEv k2 = new KiralikEv(2500, 1200, 4, "KiralikEv", 3, 120);
            KiralikEv k3 = new KiralikEv(3000, 1500, 5, "KiralikEv", 4, 150);

            var s1 = new SatilikEv(60000, 4, "SatilikEv", 3, 120);
            var s2 = new SatilikEv(70000, 5, "SatilikEv", 4, 150);
            var s3 = new SatilikEv(80000, 6, "SatilikEv", 5, 200);

            Ev[] evler = { k1, k2, k3, s1, s2, s3 };

            foreach (var ev in evler)
            {
                Console.WriteLine(ev.ToString());
                Console.WriteLine("-------------------------");
            }
        }
    }
}
