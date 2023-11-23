using System;

namespace MethodOverloadingExample
{
    class Calculator
    {

        public int Topla(int a, int b)
        {
            return a + b;
        }


        public double Topla(double a, double b)
        {
            return a + b;
        }


        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }


        public int Carp(int a, int b)
        {
            return a * b;
        }


        public double Carp(double a, double b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator hesapMakinesi = new Calculator();


            int toplamInt = hesapMakinesi.Topla(5, 3);
            Console.WriteLine("Toplam (integer): " + toplamInt);

            double toplamDouble = hesapMakinesi.Topla(5.5, 3.3);
            Console.WriteLine("Toplam (double): " + toplamDouble);


            int toplamUcInt = hesapMakinesi.Topla(2, 4, 6);
            Console.WriteLine("Toplam (üç integer): " + toplamUcInt);


            int carpimInt = hesapMakinesi.Carp(4, 3);
            Console.WriteLine("Çarpım (integer): " + carpimInt);


            double carpimDouble = hesapMakinesi.Carp(4.5, 2.5);
            Console.WriteLine("Çarpım (double): " + carpimDouble);

            Console.ReadKey();
        }
    }
}
