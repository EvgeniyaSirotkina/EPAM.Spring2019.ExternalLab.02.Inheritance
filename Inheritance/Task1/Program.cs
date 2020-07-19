using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Task 1 ===\n");

            // #1 Create an array of six objects (2 for the base class, 2 for each other classes)
            var purchases = new Purchase[]
                {
                    new Purchase("Tomato", .35m, 15),
                    new Purchase("Juce", 1.72m, 4),
                    new FixedDiscountPurchase("Cheese", 3.64m, 5, 1.25m),
                    new FixedDiscountPurchase("Onion", .86m, 3, .13m),
                    new FloatedDiscountPurchase("Potatoes", .15m, 45, 15),
                    new FloatedDiscountPurchase("Cucumber", .43m, 13, 15),
                };

            try
            {
                // #2 Print the array to the console.
                // #3 Find the purchase with max cost and print to the console after the cycle.
                // #4 Determine if all purchases are equal (yes/no)
                var purchaseWithMaxCost = purchases[0];
                var isEqual = true;

                foreach (var purchase in purchases)
                {
                    if (isEqual)
                    {
                        isEqual = purchaseWithMaxCost.Equals(purchase);
                    }

                    if (purchase.GetCost() > purchaseWithMaxCost.GetCost())
                    {
                        purchaseWithMaxCost = purchase;
                    }

                    Console.WriteLine($"{purchase};{purchase.GetCost()}");
                }

                Console.WriteLine();
                Console.WriteLine(purchaseWithMaxCost);
                Console.WriteLine(isEqual ? "yes" : "no");

                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
