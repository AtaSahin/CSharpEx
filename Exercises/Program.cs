using System;

public class Ogrenci
{
    private string ad;
    private int yas;


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


    public int Yas
    {
        get { return yas; }
        set
        {

            if (value >= 0)
            {
                yas = value;
            }
            else
            {
                Console.WriteLine("Geçersiz yaş değeri....");
            }
        }
    }


    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {ad}, Yas: {yas}");
    }
}

class Program
{
    static void Main()
    {

        Ogrenci ogrenci = new Ogrenci();

        ogrenci.Ad = "Ata";
        ogrenci.Yas = 23;


        ogrenci.BilgileriYazdir();


        ogrenci.Ad = "";
        ogrenci.Yas = -5;


        ogrenci.BilgileriYazdir();
    }
}
