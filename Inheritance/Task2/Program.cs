using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Task 2 ===\n");

            // #1 Create an array of six objects (2 for each classes)
            var purchases = new AbstractPurchase[]
                {
                    new FixedDiscountPurchase(new Commodity("Flash Card 4Gb", 27m), 4, 5),
                    new FixedDiscountPurchase(new Commodity("Samsung A3 32Gb", 238m), 2, 45m),
                    new FloatedDiscountPurchase(new Commodity("Cable USB to miniUSB", 8m), 5, 15),
                    new FloatedDiscountPurchase(new Commodity("Acer Aspire NP-Y18 4Gb GeForce 940MX", 1450m), 1, 15),
                    new TransportPurchase(new Commodity("Apple Watch", 845m), 1, 15m),
                    new TransportPurchase(new Commodity("FiiO M6", 419m), 2, 15m),
                };

            try
            {
                // #2 Print objects from array to console using ToString()
                PrintPurchases(purchases);

                // #3 Sort objects in descending order using the Sort() method of the Array class
                Array.Sort(purchases);

                // #4 Print objects from array to console using ToString()
                PrintPurchases(purchases);

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

        private static void PrintPurchases(AbstractPurchase[] purchases)
        {
            foreach (var purchase in purchases)
            {
                Console.WriteLine(purchase);
            }

            Console.WriteLine();
        }
    }
}
