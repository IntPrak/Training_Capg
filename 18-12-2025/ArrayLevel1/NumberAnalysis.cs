using System;

class NumberAnalysis
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                Console.WriteLine(numbers[i] + " is Positive and " +
                                  (numbers[i] % 2 == 0 ? "Even" : "Odd"));
            }
            else if (numbers[i] < 0)
                Console.WriteLine(numbers[i] + " is Negative");
            else
                Console.WriteLine("Zero");
        }

        if (numbers[0] == numbers[4])
            Console.WriteLine("First and last elements are Equal");
        else if (numbers[0] > numbers[4])
            Console.WriteLine("First element is Greater than Last");
        else
            Console.WriteLine("First element is Less than Last");
    }
}
