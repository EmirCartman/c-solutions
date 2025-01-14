using System;

public class SekilAlanlari
{
    
    public double AlanHesapla(double kenar)
    {
        return kenar * kenar;
    }

  
    public double AlanHesapla(double uzunKenar, double kisaKenar)
    {
        return uzunKenar * kisaKenar;
    }

   
    public double AlanHesapla(double yaricap, bool daire)
    {
        return Math.PI * yaricap * yaricap;
    }
}

class Program
{
    static void Main()
    {
        SekilAlanlari alanlar = new SekilAlanlari();

        
        double kareAlani = alanlar.AlanHesapla(4);
        Console.WriteLine("Karenin Alanı (kenar=4): " + kareAlani);

       
        double dikdortgenAlani = alanlar.AlanHesapla(5, 3);
        Console.WriteLine("Dikdörtgenin Alanı (uzun kenar=5, kısa kenar=3): " + dikdortgenAlani);

     
        double daireAlani = alanlar.AlanHesapla(3, true);
        Console.WriteLine("Dairenin Alanı (yarıçap=3): " + daireAlani);
    }
}
