using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int eachGets = chocolates / children;
        int remaining = chocolates % children;

        Console.WriteLine("The number of chocolates each child gets is " +
                          eachGets + " and the number of remaining chocolates is " + remaining);
    }
}
