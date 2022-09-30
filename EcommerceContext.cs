using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

public class EcommerceContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=localhost;Initial Catalog=db_ecommerce;Persist Security Info=True;User ID=sa;Password=NET2022!");
    }
    
}