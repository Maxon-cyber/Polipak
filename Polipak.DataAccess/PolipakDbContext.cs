using Microsoft.EntityFrameworkCore;
using Polipak.Entities;

namespace Polipak.DataAccess;

public class PolipakDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }

    public PolipakDbContext() : base()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Настройка сущности User
        modelBuilder.Entity<User>()
            .HasKey(u => u.UserId);

        // Настройка сущности Product
        modelBuilder.Entity<Product>()
            .HasKey(p => p.ProductId);

        // Настройка сущности Order
        modelBuilder.Entity<Order>()
            .HasKey(o => o.OrderId);
        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId);

        // Настройка сущности OrderProduct
        modelBuilder.Entity<OrderProduct>()
            .HasKey(op => new { op.OrderId, op.ProductId });
        modelBuilder.Entity<OrderProduct>()
            .HasOne(op => op.Order)
            .WithMany(o => o.OrderProducts)
            .HasForeignKey(op => op.OrderId);
        modelBuilder.Entity<OrderProduct>()
            .HasOne(op => op.Product)
            .WithMany(p => p.OrderProducts)
            .HasForeignKey(op => op.ProductId);

        base.OnModelCreating(modelBuilder);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
       .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=PolipakDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}