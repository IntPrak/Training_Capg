using System;

class FriendsComparison
{
    static void Main()
    {
        Console.Write("Enter Amar age and height: ");
        int amarAge = int.Parse(Console.ReadLine());
        double amarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar age and height: ");
        int akbarAge = int.Parse(Console.ReadLine());
        double akbarHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony age and height: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        double anthonyHeight = double.Parse(Console.ReadLine());

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        Console.WriteLine("Youngest age is " + youngestAge);
        Console.WriteLine("Tallest height is " + tallestHeight);
    }
}
