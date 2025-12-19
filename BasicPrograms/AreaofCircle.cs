using System;

class AreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
