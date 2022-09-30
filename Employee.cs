using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace csharp_ecommerce_db;

[Table("employees")]
public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Surname { get; set; }   
    public string Level { get; set; }   

    // Relazione con Lista Ordini
    public List<Order> Orders { get; set; } 

}


