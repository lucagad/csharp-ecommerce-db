using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace csharp_ecommerce_db;

[Table("payments")]
public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public string Status { get; set; }  
    [Required]
    public double Amount { get; set; }   
    
    public int OrderId { get; set; }
    public Order Order { get; set; }
}


