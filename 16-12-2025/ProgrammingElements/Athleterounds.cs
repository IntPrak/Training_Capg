using System;

class AthleteRounds
{
    static void Main()
    {
        Console.Write("Enter side1 (meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side2 (meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side3 (meters): ");
        double side3 = double.Parse(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000;
        double rounds = totalDistance / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds);
    }
}
