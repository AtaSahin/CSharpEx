using System;

public class Islemci
{
    private string islemciMarka;

    public string IslemciMarka
    {
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                islemciMarka = value;
            }
            else
            {
                Console.WriteLine("Geçersiz işlemci markası.");
            }
        }
    }

    public void BilgiYazdir()
    {
        Console.WriteLine($"İşlemci Markası: {islemciMarka}");
    }
}

class Program
{
    static void Main()
    {
        Islemci bilgisayarIslemci = new Islemci();
        bilgisayarIslemci.IslemciMarka = "Intel";


        bilgisayarIslemci.IslemciMarka = "";

        bilgisayarIslemci.BilgiYazdir();
    }
}
