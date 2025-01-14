using System;

public class Departman
{
    public string Ad { get; set; }
    public string Lokasyon { get; set; }

    public Departman(string ad, string lokasyon)
    {
        Ad = ad;
        Lokasyon = lokasyon;
    }
}

public class Calisan
{
    public string Ad { get; set; }
    public string Pozisyon { get; set; }
    public Departman Departman { get; private set; }

    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    public void DepartmanAtama(Departman departman)
    {
        Departman = departman;
    }
}

class Program
{
    static void Main()
    {
        // Departman oluşturma
        Departman yazilimDepartmani = new Departman("Yazılım", "İstanbul");

        // Çalışan oluşturma
        Calisan calisan1 = new Calisan("Ahmet Yılmaz", "Yazılım Geliştirici");

        // Çalışana departman atama
        calisan1.DepartmanAtama(yazilimDepartmani);

        // Çalışan ve departman bilgilerini yazdırma
        Console.WriteLine("Çalışan: " + calisan1.Ad);
        Console.WriteLine("Pozisyon: " + calisan1.Pozisyon);
        Console.WriteLine("Departman: " + calisan1.Departman.Ad);
        Console.WriteLine("Lokasyon: " + calisan1.Departman.Lokasyon);
    }
}
