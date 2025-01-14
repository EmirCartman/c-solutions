using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiftyönlüörnek4
{
    class Program
    {

        public class Sirket
        {
            public string Ad { get; set; }
            public string Konum { get; set; }
            public List<Calısanlar> Calısan { get; set; }
          
            public void CalısanEkle(Calısanlar calısan)
            {

                if (!Calısan.Contains(calısan))
                {
                    Calısan.Add(calısan);
                }
            }


        }

        public class Calısanlar
        {
            public string Ad { get; set;  }
            public string Departman { get; set; }
            Sirket sirket;


            public Calısanlar(string ad, string departman)
            {

                Ad = ad;
                Departman = departman;

            }

            public void SirketEkleme(string Ad,string Konum)
            {
                sirket = new Sirket(Ad, Konum);

            }


        }












        static void Main(string[] args)
        {
        }
    }
}
