using System;

public class MatematikselIslemler
{
    public int Topla(int a, int b)
    {
        return a + b;
    }

 
    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    
    public int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }
}

class Program
{
    static void Main()
    {
        MatematikselIslemler islemler = new MatematikselIslemler();

      
        int sonuc1 = islemler.Topla(3, 5);
        Console.WriteLine("3 + 5 = " + sonuc1);

       
        int sonuc2 = islemler.Topla(2, 4, 6);
        Console.WriteLine("2 + 4 + 6 = " + sonuc2);

     
        int[] sayilar = { 1, 2, 3, 4, 5 };
        int sonuc3 = islemler.Topla(sayilar);
        Console.WriteLine("1 + 2 + 3 + 4 + 5 = " + sonuc3);
    }
}
