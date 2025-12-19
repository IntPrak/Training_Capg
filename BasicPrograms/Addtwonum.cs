using System;

class AddTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("Sum = " + sum);
    }
}
