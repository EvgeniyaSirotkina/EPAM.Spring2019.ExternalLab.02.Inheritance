﻿namespace Task1
{
    public class Purchase
    {
        public Purchase()
        {
            Name = default;
            Price = default;
            Quantity = default;
        }

        public Purchase(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual decimal GetCost() => Price * Quantity;

        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Price.GetHashCode();
            hashcode = 31 * hashcode + Quantity.GetHashCode();

            return hashcode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Purchase))
                return false;
            else
                return Name == ((Purchase)obj).Name &&
                        Price == ((Purchase)obj).Price;
        }

        public override string ToString() => $"{Name};{Price};{Quantity}";
    }
}
