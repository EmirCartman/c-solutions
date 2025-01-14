using System;
using System.Collections.Generic;

public class Kitaplik
{
    private List<string> kitaplar;

    public Kitaplik()
    {
        kitaplar = new List<string>();
    }

    
    public void KitapEkle(string kitapAdi)
    {
        kitaplar.Add(kitapAdi);
    }

    
    public string this[int indeks]
    {
        get
        {
            if (indeks < 0 || indeks >= kitaplar.Count)
            {
                return "Geçersiz indeks: Bu indekste bir kitap bulunmamaktadır.";
            }
            return kitaplar[indeks];
        }
        set
        {
            if (indeks < 0 || indeks >= kitaplar.Count)
            {
                Console.WriteLine("Geçersiz indeks: Bu indekste bir kitap güncellenemez.");
            }
            else
            {
                kitaplar[indeks] = value;
            }
        }
    }

    
    public void KitaplariListele()
    {
        for (int i = 0; i < kitaplar.Count; i++)
        {
            Console.WriteLine($"{i}: {kitaplar[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Kitaplik kitaplik = new Kitaplik();

       
        kitaplik.KitapEkle("Savaş ve Barış");
        kitaplik.KitapEkle("Suç ve Ceza");
        kitaplik.KitapEkle("1984");

       
        Console.WriteLine("Kitaplar:");
        kitaplik.KitaplariListele();

        
        Console.WriteLine($"\n0. indekste bulunan kitap: {kitaplik[0]}");

       
        kitaplik[1] = "Beyaz Gemi";

       
        Console.WriteLine("\nGüncellenmiş Kitaplar:");
        kitaplik.KitaplariListele();

        
        Console.WriteLine($"\nGeçersiz indeksle erişim: {kitaplik[10]}");
    }
}
