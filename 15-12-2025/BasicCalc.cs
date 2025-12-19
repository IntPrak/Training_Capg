using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " +
                          number1 + " and " + number2 + " is " +
                          (number1 + number2) + ", " +
                          (number1 - number2) + ", " +
                          (number1 * number2) + ", " +
                          (number1 / number2));
    }
}
