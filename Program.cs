using csharp_ecommerce_db;

public class Program
{
    static void Main()
    {
        using (EcommerceContext db = new EcommerceContext()) 
        {
            // Create
            Employee nuovoDipendente = new Employee { Name = "Luca", Surname = "Bianchi", Level = "Stagista" };
            db.Add(nuovoDipendente);
            db.SaveChanges();
            
        }
        
    }
}