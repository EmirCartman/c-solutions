using System;
using System.Collections.Generic;

public class Kitap
{
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
    }
}

public class Yazar
{
    public string Ad { get; set; }
    public string Ulke { get; set; }
    public List<Kitap> Kitaplar { get; private set; }

    public Yazar(string ad, string ulke)
    {
        Ad = ad;
        Ulke = ulke;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap);
    }
}

class Program
{
    static void Main()
    {
        // Yazar oluşturma
        Yazar yazar = new Yazar("Orhan Pamuk", "Türkiye");

        // Kitap oluşturma ve yazara ekleme
        Kitap kitap1 = new Kitap("Masumiyet Müzesi", "9789750506085");
        yazar.KitapEkle(kitap1);

        Kitap kitap2 = new Kitap("Kara Kitap", "9789754705859");
        yazar.KitapEkle(kitap2);

        // Yazar ve kitapları yazdırma
        Console.WriteLine("Yazar: " + yazar.Ad);
        Console.WriteLine("Ülke: " + yazar.Ulke);
        Console.WriteLine("Kitapları:");

        foreach (var kitap in yazar.Kitaplar)
        {
            Console.WriteLine("- " + kitap.Baslik + " (ISBN: " + kitap.ISBN + ")");
        }
    }
}
