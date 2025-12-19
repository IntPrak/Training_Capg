using System;

class HandshakesMethod
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int handshakes = CalculateHandshakes(numberOfStudents);

        Console.WriteLine("The maximum number of handshakes is " + handshakes);
    }

    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}
