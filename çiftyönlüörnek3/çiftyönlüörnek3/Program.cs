using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiftyönlüörnek3
{
    class Program
    {


        public class Yazar
        {

            public string Ad { get; set; }
            public string Ulke { get; set; }
            public List <Kitap> Kitaplar { get; set; }

            public Yazar(string ad,string soyad)
            {
                Ad = ad;
                soyad = soyad;
                Kitaplar = new List<Kitap>();
            }


            public void KitapEkle()
            {

                if (Kitaplar.Contains(kitap))
                {
                    Kitaplar.Add(kitap);
                }

            }

        }

        public class Kitap
        {
            public string Baslık { get; set; }
            public DateTime YayinTarihi { get; set; }
            public Yazar Yazar;

            public Kitap(string baslsık, DateTime yayıntarihi)
            {
                Baslık = Baslık;
                YayinTarihi = yayıntarihi;

            }

            public void YazarAtama(string Ad, string Ulke)
            {
                Yazar = new Yazar(Ad, Ulke);

            }

        }












        static void Main(string[] args)
        {
        }
    }
}
