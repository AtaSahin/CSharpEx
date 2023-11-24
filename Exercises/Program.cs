using System;

public class Circle
{

    public double Radius { get; set; }


    public static double CalculateArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}

class Program
{
    static void Main()
    {

        Console.Write("Dairenin yarıçapını girin: ");
        double radius = Convert.ToDouble(Console.ReadLine());


        double area = Circle.CalculateArea(radius);


        Console.WriteLine("Dairenin Alanı: " + area);
    }
}
