using System;
using System.Collections.Generic;

public class Urun
{
    public string Ad { get; set; }
    private int Fiyat { get; set; } // Fiyat private olarak belirtilmiş

    public Urun(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public int UrunBilgisi()
    {
        return Fiyat; // Fiyat bilgisini döndürür
    }
}

public class Siparis
{
    public DateTime Tarih { get; set; }
    public decimal Toplam { get; private set; }
    private List<Urun> Urunler { get; set; }

    public Siparis()
    {
        Tarih = DateTime.Now;
        Urunler = new List<Urun>();
        Toplam = 0;
    }

    public void UrunEkle(Urun urun)
    {
        Urunler.Add(urun);
        Toplam += urun.UrunBilgisi(); // Toplam tutara ürün fiyatını ekler
    }

    public void SiparisBilgisi()
    {
        Console.WriteLine("Sipariş Tarihi: " + Tarih);
        Console.WriteLine("Sipariş Toplamı: " + Toplam + " TL");
        Console.WriteLine("Ürünler:");
        foreach (var urun in Urunler)
        {
            Console.WriteLine("- " + urun.Ad);
        }
    }
}

class Program
{
    static void Main()
    {
        // Ürünler oluşturma
        Urun urun1 = new Urun("Bilgisayar", 15000);
        Urun urun2 = new Urun("Klavye", 500);
        Urun urun3 = new Urun("Mouse", 300);

        // Sipariş oluşturma
        Siparis siparis = new Siparis();

        // Siparişe ürün ekleme
        siparis.UrunEkle(urun1);
        siparis.UrunEkle(urun2);
        siparis.UrunEkle(urun3);

        // Sipariş bilgilerini yazdırma
        siparis.SiparisBilgisi();
    }
}
