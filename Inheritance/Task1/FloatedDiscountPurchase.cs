using System;

namespace Task1
{
    public class FloatedDiscountPurchase : Purchase
    {
        private const int DiscountQuantity = 15;

        public FloatedDiscountPurchase()
        {
            Discount = default;
        }

        public FloatedDiscountPurchase(string name, decimal price, int quantity, double discount)
            : base(name, price, quantity)
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
                return (decimal)(100 - Discount) * base.GetCost() / 100;
            }

            return base.GetCost();
        }

        public override string ToString()
        {
            if (Quantity >= DiscountQuantity)
            {
                return $"{base.ToString()};{Discount}";
            }

            return $"{base.ToString()}";
        }
    }
}
