namespace builder.Models
{
    public class Product
    {
        public Product(ProductTypes type)
        {
            Type = type;
        }
        public ProductTypes Type { get; set; }
        public string Category { get; set; }
        public string Logistic { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Product type: {Type}");
            Console.WriteLine($"Product Category: {Category}");
            Console.WriteLine($"Product Logistic: {Logistic}");
        }
    }
}
