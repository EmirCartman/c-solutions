using System;

public class Otopark
{
    private string[,] parkYerleri;

    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        parkYerleri = new string[katSayisi, parkYeriSayisi];
    }

    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                return "Hata: Geçersiz bir park yeri.";
            }
            return parkYerleri[kat, parkYeri] ?? "Empty";
        }
        set
        {
            if (kat < 0 || kat >= parkYerleri.GetLength(0) || parkYeri < 0 || parkYeri >= parkYerleri.GetLength(1))
            {
                Console.WriteLine("Hata: Geçersiz bir park yerine erişilmeye çalışıldı.");
            }
            else
            {
                parkYerleri[kat, parkYeri] = value;
            }
        }
    }

    
    public void OtoparkDurumu()
    {
        for (int i = 0; i < parkYerleri.GetLength(0); i++)
        {
            Console.WriteLine($"Kat {i + 1}:");
            for (int j = 0; j < parkYerleri.GetLength(1); j++)
            {
                Console.WriteLine($"  Park Yeri {j + 1}: {(parkYerleri[i, j] ?? "Empty")}");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
       
        Otopark otopark = new Otopark(3, 5);

       
        otopark[0, 0] = "34ABC123"; 
        otopark[1, 2] = "06DEF456"; 
        otopark[2, 4] = "35GHI789"; 

      
        Console.WriteLine("Otopark Durumu:");
        otopark.OtoparkDurumu();

        
        Console.WriteLine($"\n1. Kat 1. Park Yeri: {otopark[0, 0]}");
        Console.WriteLine($"3. Kat 5. Park Yeri: {otopark[2, 4]}");

        
        Console.WriteLine($"2. Kat 2. Park Yeri: {otopark[1, 1]}");

        
        Console.WriteLine($"\nGeçersiz Park Yeri: {otopark[3, 5]}");
    }
}
