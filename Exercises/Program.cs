using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutiorial
{
    class Program
    {
        public class Musteri
        {
            public int ID;
            public string Adi;

            public Musteri(int ID, string Adi)
            {
                this.ID = ID;
                this.Adi = Adi;
                Console.WriteLine("Musteri olusturuldu");
            }
            public Musteri()
            {
                Console.WriteLine("Musteri methodu 2");
            }
            public Musteri(int ID)
            {
                Console.WriteLine("Musteri methodu 3");
            }
            public void PrintName()
            {
                Console.WriteLine("ID: {0} Adi: {1}", ID, Adi);
            }
        }

        static void Main()
        {

            Musteri m = new Musteri();

            m.ID = 1;
            m.Adi = "Ata";
            m.PrintName();
            Musteri m2 = new Musteri(2);
            m2.Adi = "Sahin";
            m2.PrintName();
            Musteri m3 = new Musteri(3, "Adil");
            m3.PrintName();
        }
    }
}
