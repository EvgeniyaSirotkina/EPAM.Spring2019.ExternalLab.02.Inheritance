using System;

namespace Task2
{
    public class TransportPurchase : AbstractPurchase
    {
        public TransportPurchase()
        {
            TransportExpenses = default;
        }

        public TransportPurchase(Commodity commodity, int quantity, decimal transport)
            : base(commodity, quantity)
        {
            TransportExpenses = transport;
        }

        public decimal TransportExpenses { get; set; }

        public override decimal GetCost()
        {
            if (TransportExpenses < 0)
            {
                throw new ArgumentOutOfRangeException("Transport expenses can't be negative.");
            }

            if (TransportExpenses == 0)
            {
                return (Commodity.Price * Quantity);
            }

            return Commodity.Price * Quantity + TransportExpenses;
        }

        public override string ToString() => $"{base.ToString()};{TransportExpenses};{GetCost()}";
    }
}
