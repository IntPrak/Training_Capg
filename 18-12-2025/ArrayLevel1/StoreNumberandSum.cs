using System;

class StoreNumbersAndSum
{
    static void Main()
    {
        double[] numbers = new double[10];
        double total = 0;
        int index = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
                break;

            numbers[index] = input;
            index++;
        }

        for (int i = 0; i < index; i++)
            total += numbers[i];

        Console.WriteLine("Sum of numbers is " + total);
    }
}
