using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiftyönlüörnek2
{
    class Program
    {

        public class Doktor
        {
            public string  Ad{ get; set; }
            public string Brans { get; set; }
            public List<Hastalar> hasta;

            public Doktor(string ad, string brans)
            {
                Ad = ad;
                Brans = brans;
                hasta = new List<Hastalar>();
            }

            public void HastaEkle(Hastalar hasta)
            {
                if (!hasta.Contains(Hasta))
                {
                    hasta.Add(Hasta);
                }

            }

        }
        public class Hastalar
        {

            public string Ad { get; set; }
            public string TCNo { get; set; }
            Doktor Doktor;

            public Hastalar(string ad, string soyad)
            {
                Ad = ad;
                soyad = soyad;

            }
            public void DoktorAtama(string ad,string brans)
            {
                Doktor = new Doktor(ad, brans);

            }

        }
















        static void Main(string[] args)
        {





        }
}
