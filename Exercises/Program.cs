using System;

namespace ClassTutorial
{
    public class Musteri
    {
        public int ID;
        public string Adi;
        public string Soyadi;
        public void info()
        {
            Console.WriteLine("Müşteri ID: {0} İsim: {1} {2}", ID, Adi, Soyadi);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.ID = 1;
            m1.Adi = "Ahmet";
            m1.Soyadi = "Yılmaz";
            m1.info();
            Musteri m2 = new Musteri();
            m2.ID = 2;
            m2.Adi = "Mehmet";
            m2.Soyadi = "Yılmaz";
            m2.info();
        }
    }
}