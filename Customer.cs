using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace csharp_ecommerce_db;

[Table("customers")]
[Index(nameof(Email), IsUnique = true)]
public class Customer
{
    [Key]
    public int CustomerId { get; set; } 
    [Required]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }   
    [Required]
    public string Email { get; set; }   

    // Relazione con Lista Ordini
    public List<Order> Orders { get; set; } 
}


