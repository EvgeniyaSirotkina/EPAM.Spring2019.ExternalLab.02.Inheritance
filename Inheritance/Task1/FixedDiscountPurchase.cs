using System;

namespace Task1
{
    public class FixedDiscountPurchase : Purchase
    {
        public FixedDiscountPurchase()
        {
            Discount = default;
        }

        public FixedDiscountPurchase(string name, decimal price, int quantity, decimal discount)
            : base(name, price, quantity)
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

            if (Discount > Price)
            {
                throw new ArgumentException("Discount cannot be greater than price.");
            }

            if (Discount == 0)
            {
                return base.GetCost();
            }

            return (Price - Discount) * Quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()};{Discount}";
        }
    }
}
