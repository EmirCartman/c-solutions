using System;

class Hesap
{
    public string HesapNo { get; set; }
    public decimal Bakiye { get; set; }
    public string HesapSahibi { get; set; }

    public virtual void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Yeni Bakiye: {Bakiye}");
    }

    public virtual void ParaCek(decimal miktar)
    {
        if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
        else
        {
            Bakiye -= miktar;
            Console.WriteLine($"Yeni Bakiye: {Bakiye}");
        }
    }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye}, Hesap Sahibi: {HesapSahibi}");
    }
}

class VadesizHesap : Hesap
{
    public decimal EkHesapLimiti { get; set; }

    public override void ParaCek(decimal miktar)
    {
        if (miktar > (Bakiye + EkHesapLimiti))
        {
            Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
        }
        else
        {
            Bakiye -= miktar;
            Console.WriteLine($"Yeni Bakiye: {Bakiye}");
        }
    }
}

class VadeliHesap : Hesap
{
    public int VadeSuresi { get; set; }
    public decimal FaizOrani { get; set; }

    public override void ParaCek(decimal miktar)
    {
        if (VadeSuresi > 0)
        {
            Console.WriteLine("Vade dolmadan para çekemezsiniz!");
        }
        else
        {
            base.ParaCek(miktar);
        }
    }
}

class Program3
{
    static void Main()
    {
        Console.WriteLine("Hesap Türünü Seçin (1: Vadesiz, 2: Vadeli): ");
        int secim = int.Parse(Console.ReadLine());

        if (secim == 1)
        {
            VadesizHesap vadesiz = new VadesizHesap();
            Console.Write("Hesap No: "); vadesiz.HesapNo = Console.ReadLine();
            Console.Write("Hesap Sahibi: "); vadesiz.HesapSahibi = Console.ReadLine();
            Console.Write("Bakiye: "); vadesiz.Bakiye = decimal.Parse(Console.ReadLine());
            Console.Write("Ek Hesap Limiti: "); vadesiz.EkHesapLimiti = decimal.Parse(Console.ReadLine());
            vadesiz.BilgiYazdir();
            Console.Write("Para çekilecek miktar: ");
            decimal miktar = decimal.Parse(Console.ReadLine());
            vadesiz.ParaCek(miktar);
        }
        else if (secim == 2)
        {
            VadeliHesap vadeli = new VadeliHesap();
            Console.Write("Hesap No: "); vadeli.HesapNo = Console.ReadLine();
            Console.Write("Hesap Sahibi: "); vadeli.HesapSahibi = Console.ReadLine();
            Console.Write("Bakiye: "); vadeli.Bakiye = decimal.Parse(Console.ReadLine());
            Console.Write("Vade Süre: "); vadeli.VadeSuresi = int.Parse(Console.ReadLine());
            vadeli.BilgiYazdir();
            Console.Write("Para çekilecek miktar: ");
            decimal miktar = decimal.Parse(Console.ReadLine());
            vadeli.ParaCek(miktar);
        }
    }
}
