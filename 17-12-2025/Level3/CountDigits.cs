using System;

class CountDigits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;
        int temp = number;

        while (temp != 0)
        {
            temp = temp / 10;
            count++;
        }

        Console.WriteLine("Number of digits in " + number + " is " + count);
    }
}
