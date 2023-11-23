using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTutorial
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            int sonuc = p.Topla(5, 6);
            Console.WriteLine("toplam = " + sonuc);
            int sonuc2 = Carp(5, 6);
            Console.WriteLine("carpim = " + sonuc2);
            p.EkranaYazdir("Merhaba");
            Console.ReadKey();
        }
        private int Topla(int a, int b)
        {
            return a + b;

        }
        static int Carp(int x, int y)
        {
            return x * y;
        }

        private void EkranaYazdir(string metin)
        {
            Console.WriteLine(metin);
        }

    }

}
