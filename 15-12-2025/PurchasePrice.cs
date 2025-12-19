using System;

class PurchasePrice
{
    static void Main()
    {
        Console.Write("Enter unit price: ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        double totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is INR " + totalPrice +
                          " if the quantity " + quantity +
                          " and unit price is INR " + unitPrice);
    }
}
