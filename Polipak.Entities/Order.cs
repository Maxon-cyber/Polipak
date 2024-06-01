namespace Polipak.Entities;

public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int Quantity { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
}