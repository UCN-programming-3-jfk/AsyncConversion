using AsyncConversion.DataAccess.Model;
namespace AsyncConversion.DataAccess;
public class DataAccessLayer
{
    public Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        return Task.FromResult<IEnumerable<Customer>>(new List<Customer>{
            new Customer(1, "Alice Jensen", "alice.jensen@example.com"),
            new Customer(2, "Brian Nielsen", "brian.nielsen@example.com"),
            new Customer(3, "Clara Hansen", "clara.hansen@example.com"),
            new Customer(4, "David Sørensen", "david.sorensen@example.com"),
            new Customer(5, "Emma Pedersen", "emma.pedersen@example.com")
        });
    }
}