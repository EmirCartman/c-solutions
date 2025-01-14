using System;

public class SatrancTahtasi
{
    private string[,] tahtadakiTaslar;

    public SatrancTahtasi()
    {
       
        tahtadakiTaslar = new string[8, 8];
    }

   
    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                return "Hata: Geçersiz bir kareye erişilmeye çalışıldı.";
            }
            return tahtadakiTaslar[satir, sutun] ?? "Boş"; 
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                Console.WriteLine("Hata: Geçersiz bir kareye taş yerleştirilemez.");
            }
            else
            {
                tahtadakiTaslar[satir, sutun] = value;
            }
        }
    }

   
    public void TahtayiGoster()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"{(tahtadakiTaslar[i, j] ?? "Boş"),-8}");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        SatrancTahtasi tahta = new SatrancTahtasi();

       
        tahta[0, 0] = "Kale";  
        tahta[0, 1] = "At";    
        tahta[7, 4] = "Şah"; 

      
        Console.WriteLine("Satranç Tahtası Durumu:");
        tahta.TahtayiGoster();

        
        Console.WriteLine($"\nA1 karesindeki taş: {tahta[0, 0]}");
        Console.WriteLine($"D5 karesindeki taş: {tahta[4, 3]}");

      
        Console.WriteLine($"\nGeçersiz kare erişimi: {tahta[8, 8]}");
    }
}
