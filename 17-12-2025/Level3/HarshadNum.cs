using System;

class HarshadNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int sum = 0;

        while (temp != 0)
        {
            sum += temp % 10;
            temp = temp / 10;
        }

        if (number % sum == 0)
            Console.WriteLine(number + " is a Harshad Number");
        else
            Console.WriteLine(number + " is not a Harshad Number");
    }
}
