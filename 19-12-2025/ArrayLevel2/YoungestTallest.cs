using System;

class YoungestTallest
{
    static void Main()
    {
        int[] age = new int[3];
        double[] height = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            age[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + ": ");
            height[i] = double.Parse(Console.ReadLine());
        }

        int youngestIndex = 0, tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (age[i] < age[youngestIndex])
                youngestIndex = i;

            if (height[i] > height[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine("Youngest is " + names[youngestIndex]);
        Console.WriteLine("Tallest is " + names[tallestIndex]);
    }
}
