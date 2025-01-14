using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çiftyönlüörnek5
{
    class Program
    {
        public class Ebeveyn { 

        public string Ad { get; set; }
        public int Yas { get; set; }
        public List <Cocuk> Cocuklar { get; set; }

        public Ebeveyn (String ad, int yas)
        {
            Ad = ad;
            Yas = yas;
            Cocuklar = new List<Cocuk>();


        }

        public void CocukEkle(Cocuk cocuk)
        {

            if (!Cocuklar.Contains(cocuk))
            {
                Cocuklar.Add(cocuk);

            }


        }

        }




        public class Cocuk
        {

            public string Ad { get; set; }
            public int Yas { get; set; }
            Ebeveyn ebeveyn;
        }

        public Cocuk ( string ad, int yas)
        {

            Ad = ad;
            Yas = yas;

        }

        public void EbeveynAtama(String Ad,int Yas)
        {
            ebeveyn = new Ebeveyn(Ad, Yas);

        }










        static void Main(string[] args)
        {
        }
    }
}
