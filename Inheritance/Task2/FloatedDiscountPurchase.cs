using System;

namespace Task2
{
    public class FloatedDiscountPurchase : AbstractPurchase
    {
        private const int DiscountQuantity = 3;

        public FloatedDiscountPurchase()
        {
            Discount = default;
        }

        public FloatedDiscountPurchase(Commodity commodity, int quantity, double discount)
            : base(commodity, quantity)
        {
            Discount = discount;
        }

        public double Discount { get; set; }

        public override decimal GetCost()
        {
            if (Discount < 0 || Discount > 100)
            {
                throw new ArgumentOutOfRangeException("Discount must be in range 0...100.");
            }

            if (Quantity >= DiscountQuantity)
            {
                return (decimal)(100 - Discount) * Commodity.Price * Quantity / 100;
            }

            return Commodity.Price * Quantity;
        }

        public override string ToString()
        {
            if (Quantity >= DiscountQuantity)
            {
                return $"{base.ToString()};{Discount};{GetCost()}";
            }

            return $"{base.ToString()};{GetCost()}";
        }
    }
}
