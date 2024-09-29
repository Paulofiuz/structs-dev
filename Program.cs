namespace structs
{
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product(1, "Tv led", 2000.55);

            Console.Write("Id do produto: " + product.Id);
            Console.Write(" Nome do produto: " + product.Name);
            Console.Write(" Preço do produto: " +product.Price);

        }
    }

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;

        }
        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}