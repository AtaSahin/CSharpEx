using System;


public interface IArayuz
{
    void Metot1();
    string Metot2(int sayi);
}


public class IlkSinif : IArayuz
{
    public void Metot1()
    {
        Console.WriteLine("IlkSinif - Metot1 çağrıldı.");
    }

    public string Metot2(int sayi)
    {
        return $"IlkSinif - Metot2 çağrıldı. Parametre: {sayi}";
    }
}


public class IkinciSinif : IArayuz
{
    public void Metot1()
    {
        Console.WriteLine("IkinciSinif - Metot1 çağrıldı.");
    }

    public string Metot2(int sayi)
    {
        return $"IkinciSinif - Metot2 çağrıldı. Parametre: {sayi}";
    }
}


public class AnaSinif
{
    public void ArayuzKullanimi(IArayuz arayuz)
    {
        arayuz.Metot1();
        string sonuc = arayuz.Metot2(99);
        Console.WriteLine(sonuc);
    }
}

class Program
{
    static void Main()
    {

        IlkSinif ilkSinifOrnegi = new IlkSinif();
        IkinciSinif ikinciSinifOrnegi = new IkinciSinif();


        AnaSinif anaSinifOrnegi = new AnaSinif();


        anaSinifOrnegi.ArayuzKullanimi(ilkSinifOrnegi);
        Console.WriteLine("---------------");
        anaSinifOrnegi.ArayuzKullanimi(ikinciSinifOrnegi);
    }
}
