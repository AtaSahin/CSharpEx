﻿using System;

namespace MethodsTutorial
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ParametreMethodu(Numbers);

            int i = 5;
            OrnekMethod2(ref i);
            int Toplam;
            int Carpim;
            Hesapla(5, 6, out Toplam, out Carpim);
            Console.WriteLine("Toplam: {0} Çarpım: {1}", Toplam, Carpim);
            Console.ReadKey();
        }

        public static void OrnekMethod(int a)
        {
            a = 5;
        }

        public static void OrnekMethod2(ref int b)
        {
            b = 100;
        }

        public static void Hesapla(int Fn, int Sn, out int Toplam, out int Carpim)
        {
            Toplam = Fn + Sn;
            Carpim = Fn * Sn;
        }
        public static void ParametreMethodu(params int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

    }
}