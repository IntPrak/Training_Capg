using System;

class FirstSmallest
{
    static void Main()
    {
        Console.Write("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter number3: ");
        int number3 = int.Parse(Console.ReadLine());

        bool isSmallest = number1 < number2 && number1 < number3;

        Console.WriteLine("Is the first number the smallest? " + isSmallest);
    }
}
