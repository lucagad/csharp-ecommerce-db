using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace csharp_ecommerce_db;

[Table("orders")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public double Amount { get; set; } 
    [Required]
    public string Status { get; set; }   

    // Relazione con Customer
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    // Relazione con Employee
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    // Relazione con Lista Prodotti
    public List<Product> Products { get; set; } 
    
    // Relazione con Lista Payments
    public List<Payment> Payments { get; set; } 


}


