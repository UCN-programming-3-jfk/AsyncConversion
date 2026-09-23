namespace AsyncConversion.DataAccess.Model;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Customer(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"Customer {Id:00}, Name:{Name}, Email:{Email}";
    }
}