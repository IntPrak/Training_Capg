using System;

class DigitFrequency
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int[] freq = new int[10];

        while (number != 0)
        {
            freq[number % 10]++;
            number /= 10;
        }

        for (int i = 0; i < 10; i++)
            Console.WriteLine("Digit " + i + " occurs " + freq[i] + " times");
    }
}
