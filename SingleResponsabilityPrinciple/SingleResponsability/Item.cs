namespace SingleResponsability;

public class Item
{
    public Item(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double Subtotal()
    {
        return Quantity * Product.Price;
    }
}