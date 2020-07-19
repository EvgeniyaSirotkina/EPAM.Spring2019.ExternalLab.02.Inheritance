using System;

namespace Task2
{
    public abstract class AbstractPurchase : IComparable<AbstractPurchase>
    {
        public AbstractPurchase()
        {
            Commodity = default;
            Quantity = default;
        }

        public AbstractPurchase(Commodity commodity, int quantity)
        {
            Commodity = commodity ?? throw new ArgumentNullException(nameof(commodity));
            Quantity = quantity;
        }

        public Commodity Commodity { get; set; }

        public int Quantity { get; set; }

        public abstract decimal GetCost();

        public int CompareTo(AbstractPurchase purchase) => (int)(purchase.GetCost() - GetCost());

        public override string ToString() => $"{Commodity};{Quantity}";
    }
}
