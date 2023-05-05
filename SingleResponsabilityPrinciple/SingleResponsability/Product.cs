namespace SingleResponsability;

public class Product
{
    public Product(string description, double price)
    {
        Description = description;
        Price = price;
    }

    public string Description { get; set; }
    public double Price { get; set; }
}