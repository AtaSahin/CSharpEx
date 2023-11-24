using System;

public class Calisan
{
    private string ad;
    private decimal maas;
    private string pozisyon;

    public Calisan(string ad, decimal maas, string pozisyon)
    {
        Ad = ad;
        Maas = maas;
        Pozisyon = pozisyon;
    }


    public string Ad
    {
        get { return ad; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                ad = value;
            }
            else
            {
                Console.WriteLine("Geçersiz ad değeri.....!");
            }
        }
    }


    public decimal Maas
    {
        get { return maas; }
        set
        {
            if (value >= 0)
            {
                maas = value;
            }
            else
            {
                Console.WriteLine("Geçersiz maaş değeri....");
            }
        }
    }


    public string Pozisyon
    {
        get { return pozisyon; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                pozisyon = value;
            }
            else
            {
                Console.WriteLine("Geçersiz pozisyon değeri.....");
            }
        }
    }


    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Maaş: {Maas}, Pozisyon: {Pozisyon}");
    }
}

class Program
{
    static void Main()
    {

        Calisan calisan = new Calisan("Ata", 1000, "Yazılım Personeli");


        calisan.BilgileriYazdir();

        calisan.Ad = "";
        calisan.Maas = -1000;
        calisan.Pozisyon = "";


        calisan.BilgileriYazdir();
    }
}
