using System;

class NaturalSumWhile
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sumLoop = 0, i = 1;
            while (i <= n)
            {
                sumLoop += i;
                i++;
            }

            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine("Sum using loop: " + sumLoop);
            Console.WriteLine("Sum using formula: " + sumFormula);
        }
    }
}
