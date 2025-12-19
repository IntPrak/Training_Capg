using System;

class AreaOfTriangle
{
    static void Main()
    {
        Console.Write("Enter base: ");
        double baseValue = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = 0.5 * baseValue * height;

        Console.WriteLine("Area of triangle is " + area);
    }
}
