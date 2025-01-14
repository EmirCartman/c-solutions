using System;

public struct Zaman
{
   
    private int hour;
    private int minute;

    public int Hour
    {
        get => hour;
        set => hour = (value >= 0 && value < 24) ? value : 0;
    }

    public int Minute
    {
        get => minute;
        set => minute = (value >= 0 && value < 60) ? value : 0;
    }

    
    public Zaman(int hour, int minute)
    {
        this.hour = (hour >= 0 && hour < 24) ? hour : 0;
        this.minute = (minute >= 0 && minute < 60) ? minute : 0;
    }

    
    public int ToplamDakika()
    {
        return (hour * 60) + minute;
    }

    
    public int DakikaFarki(Zaman other)
    {
        return Math.Abs(this.ToplamDakika() - other.ToplamDakika());
    }
}

class Program
{
    static void Main()
    {
        
        Zaman zaman1 = new Zaman(12, 30);   
        Zaman zaman2 = new Zaman(15, 45);   
        Zaman zaman3 = new Zaman(25, 70);  

        Console.WriteLine($"Zaman 1: {zaman1.Hour} saat, {zaman1.Minute} dakika");
        Console.WriteLine($"Zaman 2: {zaman2.Hour} saat, {zaman2.Minute} dakika");
        Console.WriteLine($"Zaman 3: {zaman3.Hour} saat, {zaman3.Minute} dakika (Geçersiz zaman, 0 yapılır)");

       
        Console.WriteLine($"\nZaman 1'in toplam dakika değeri: {zaman1.ToplamDakika()} dakika");
        Console.WriteLine($"Zaman 2'nin toplam dakika değeri: {zaman2.ToplamDakika()} dakika");

      
        Console.WriteLine($"\nZaman 1 ve Zaman 2 arasındaki dakika farkı: {zaman1.DakikaFarki(zaman2)} dakika");
    }
}
