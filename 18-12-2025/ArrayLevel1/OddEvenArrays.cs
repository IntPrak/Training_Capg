using System;

class OddEvenArrays
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Invalid Natural Number");
            return;
        }

        int[] even = new int[number / 2 + 1];
        int[] odd = new int[number / 2 + 1];
        int e = 0, o = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[e++] = i;
            else
                odd[o++] = i;
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < o; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < e; i++)
            Console.Write(even[i] + " ");
    }
}
