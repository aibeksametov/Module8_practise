using System;

class App
{
    static void Main()
    {
        string[] products = { "Milk", "Juicy", "Orange", "Egg" };
        double[] prices = { 2.5, 1.0, 3.0, 2.0 };

        DateTime currentTime = DateTime.Now;
        int discount = 0;
        if (currentTime.Hour >= 8 && currentTime.Hour < 12)
        {
            discount = 5;
        }

        Console.WriteLine("Available products:");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i]} - {prices[i]:C}");
        }

        Console.Write("Enter nub=mber of products: ");
        string input = Console.ReadLine();
        string[] selectedProductIndices = input.Split(',');

        double totalCost = 0;
        foreach (string index in selectedProductIndices)
        {
            int productIndex;
            if (int.TryParse(index, out productIndex) && productIndex >= 1 && productIndex <= products.Length)
            {
                totalCost += prices[productIndex - 1];
            }
        }

        double discountedTotalCost = totalCost - (totalCost * discount / 100);

        Console.WriteLine($"Total Cost: {totalCost:C}");
        Console.WriteLine($"Discounted total cost: {discountedTotalCost:C}");
    }
}
