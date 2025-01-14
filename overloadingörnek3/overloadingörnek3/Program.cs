using System;

public class ZamanHesaplayici
{
   
    public int ZamanFarki(DateTime tarih1, DateTime tarih2)
    {
        return (int)(tarih2 - tarih1).TotalDays;
    }

  
    public int ZamanFarki(DateTime tarih1, DateTime tarih2, bool saatCinsinden)
    {
        return (int)(tarih2 - tarih1).TotalHours;
    }

    
    public (int Yil, int Ay, int Gun) ZamanFarki(DateTime tarih1, DateTime tarih2, bool yilAyGunCinsinden)
    {
        int yilFarki = tarih2.Year - tarih1.Year;
        int ayFarki = tarih2.Month - tarih1.Month;
        int gunFarki = tarih2.Day - tarih1.Day;

        if (gunFarki < 0)
        {
            ayFarki--;
            gunFarki += DateTime.DaysInMonth(tarih2.Year, tarih2.Month == 1 ? 12 : tarih2.Month - 1);
        }

        if (ayFarki < 0)
        {
            yilFarki--;
            ayFarki += 12;
        }

        return (yilFarki, ayFarki, gunFarki);
    }
}

class Program
{
    static void Main()
    {
        ZamanHesaplayici hesaplayici = new ZamanHesaplayici();

        DateTime tarih1 = new DateTime(2022, 1, 1);
        DateTime tarih2 = new DateTime(2024, 11, 26);

        
        int gunFarki = hesaplayici.ZamanFarki(tarih1, tarih2);
        Console.WriteLine("Gün cinsinden fark: " + gunFarki);

      
        int saatFarki = hesaplayici.ZamanFarki(tarih1, tarih2, true);
        Console.WriteLine("Saat cinsinden fark: " + saatFarki);

        
        var yilAyGunFarki = hesaplayici.ZamanFarki(tarih1, tarih2, true);
        Console.WriteLine($"Yıl, ay ve gün cinsinden fark: {yilAyGunFarki.Yil} yıl, {yilAyGunFarki.Ay} ay, {yilAyGunFarki.Gun} gün");
    }
}
