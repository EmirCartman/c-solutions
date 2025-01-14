using System;
using System.Collections.Generic;

public class OgrenciNotSistemi
{
    private Dictionary<string, int> dersNotlari;

    public OgrenciNotSistemi()
    {
        dersNotlari = new Dictionary<string, int>();
    }

    
    public void NotEkle(string dersAdi, int not)
    {
        dersNotlari[dersAdi] = not;
    }

   
    public int this[string dersAdi]
    {
        get
        {
            if (dersNotlari.ContainsKey(dersAdi))
            {
                return dersNotlari[dersAdi];
            }
            else
            {
                Console.WriteLine($"Hata: '{dersAdi}' adında bir ders bulunamadı.");
                return -1; 
            }
        }
    }

    
    public void NotlariListele()
    {
        foreach (var ders in dersNotlari)
        {
            Console.WriteLine($"{ders.Key}: {ders.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        OgrenciNotSistemi ogrenci = new OgrenciNotSistemi();

        
        ogrenci.NotEkle("Matematik", 90);
        ogrenci.NotEkle("Fizik", 85);
        ogrenci.NotEkle("Kimya", 78);

        
        Console.WriteLine("Öğrencinin Ders Notları:");
        ogrenci.NotlariListele();

       
        Console.WriteLine($"\nMatematik Notu: {ogrenci["Matematik"]}");

       
        Console.WriteLine($"\nGeçersiz Ders Notu: {ogrenci["Biyoloji"]}");
    }
}
