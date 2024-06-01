namespace Polipak.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public byte[] Image { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
}