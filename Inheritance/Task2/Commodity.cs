namespace Task2
{
    public class Commodity
    {
        public Commodity()
        {
            Name = default;
            Price = default;
        }

        public Commodity(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString() => $"{Name};{Price}";
    }
}
