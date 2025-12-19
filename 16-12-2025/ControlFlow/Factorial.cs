using System;

class FactorialFor
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; i <= number; i++)
            factorial *= i;

        Console.WriteLine("Factorial is " + factorial);
    }
}
