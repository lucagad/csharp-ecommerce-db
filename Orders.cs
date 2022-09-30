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

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    
    public List<Product> Products { get; set; } 
    public List<Payment> Payments { get; set; } 


}


