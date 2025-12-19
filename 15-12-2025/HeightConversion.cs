using System;

class HeightConversion
{
    static void Main()
    {
        Console.Write("Enter height in centimeters: ");
        double cm = double.Parse(Console.ReadLine());

        double totalInches = cm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine("Your Height in cm is " + cm +
                          " while in feet is " + feet +
                          " and inches is " + inches);
    }
}
