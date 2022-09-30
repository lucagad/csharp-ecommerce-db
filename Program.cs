using csharp_ecommerce_db;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Vuoi inserire i dati di Default nel DB? (si/no)");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "si":
                defaultValue();
                break;
            case "no":
                break;
        }
        
        int sceltaMenu = MenuIniziale();

        switch (sceltaMenu)
        {
            // Stampa Clienti
            case 1:
                getTenCustomers();
                MenuIniziale();
                break;
            // Stampa Dipendenti
            case 2:
                getTenEmployees();
                MenuIniziale();
                break;
        }

    }
    static void defaultValue()
    {
    
        using (EcommerceContext db = new EcommerceContext()) 
        {
            // Creazione Dipendenti
            Employee nuovoDipendente = new Employee { Name = "Luca", Surname = "Bianchi", Level = "Stagista" };            
            Employee nuovoDipendente2 = new Employee { Name = "Luca", Surname = "Rossi", Level = "Boss" };
            Employee nuovoDipendente3 = new Employee { Name = "Paolo", Surname = "Verdi", Level = "Manager" };
            
            db.Add(nuovoDipendente);
            db.Add(nuovoDipendente2);
            db.Add(nuovoDipendente3);
            
            // Creazione Prodotti
            Product nuovoProdotto = new Product { Name = "Penna", Description = "Penna a sfera", Price = 0.5 };
            Product nuovoProdotto2 = new Product { Name = "Matita", Description = "Matita", Price = 0.9 };
            Product nuovoProdotto3 = new Product { Name = "Gomma", Description = "Gomma per cancellare", Price = 1.5 };

            db.Add(nuovoProdotto);
            db.Add(nuovoProdotto2);
            db.Add(nuovoProdotto3);
            
            // Creazione Clienti
            Customer nuovoCliente = new Customer { Name = "Michele", Surname = "Pasquini", Email = "m.pasquini@gmail.com"};
            Customer nuovoCliente2 = new Customer { Name = "Claudia", Surname = "Santini", Email = "c.santini@gmail.com"};
            
            db.Add(nuovoCliente);
            db.Add(nuovoCliente2);
            
            // Creazione Clienti
            Order nuovoOrdine = new Order { CustomerId = 1, EmployeeId = 2, Date = DateTime.Today, Amount = 3, Status = "Pagato"};
            
            db.Add(nuovoOrdine);

            db.SaveChanges();
            
            Console.WriteLine("Dati Inseriti");
            
        }
    }

    // Menu inziale
    static int MenuIniziale()
    {
        Console.WriteLine(" ");
        Console.WriteLine("-- MENU INIZIALE -- ");
        Console.WriteLine("Cosa vuoi fare?");
        Console.WriteLine("1 - Stampa i primi 10 Clienti");
        Console.WriteLine("2 - Stampa i primi 10 Dipendenti");
        Console.WriteLine(" ");

        int sceltaMenu = Convert.ToInt32(Console.ReadLine());

        return sceltaMenu;
    }
    static void getTenEmployees()
    {
        using (EcommerceContext db = new EcommerceContext())
        {
            // Read
            List<Employee> employees = db.Employees.OrderBy(employee => employee.Name).Take(10).ToList<Employee>();
            Console.WriteLine("----- LISTA DIPENDENTI -----");
            foreach (var employee in employees)
            {
                Console.Write(" - " + employee.Name + " ");
                Console.Write(employee.Surname + " ");
                Console.Write("(" + employee.Level + ") \n");

            }
        }
    }
    
    static void getTenCustomers()
    {
        using (EcommerceContext db = new EcommerceContext())
        {
            // Read
            List<Customer> customers = db.Customers.OrderBy(customer => customer.Name).Take(10).ToList<Customer>();
            Console.WriteLine("----- LISTA CLIENTI -----");
            foreach (var customer in customers)
            {
                Console.Write(" - " + customer.Name+" ");
                Console.Write(customer.Surname + " ");
                Console.Write("(" + customer.Email + ") \n");

            }
        }
    }
    
}

