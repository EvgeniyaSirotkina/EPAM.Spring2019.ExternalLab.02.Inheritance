using System;

namespace Task2
{
    public class FixedDiscountPurchase : AbstractPurchase
    {
        public FixedDiscountPurchase()
        {
            Discount = default;
        }

        public FixedDiscountPurchase(Commodity commodity, int quantity, decimal discount)
            : base(commodity, quantity)
        {
            Discount = discount;
        }

        public decimal Discount { get; set; }

        public override decimal GetCost()
        {
            if (Discount < 0)
            {
                throw new ArgumentOutOfRangeException("Discount can't be negative.");
            }

            if (Discount > Commodity.Price)
            {
                throw new ArgumentException("Discount cannot be greater than price.");
            }

            if (Discount == 0)
            {
                return (Commodity.Price * Quantity);
            }

            return (Commodity.Price - Discount) * Quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()};{Discount};{GetCost()}";
        }
    }
}
