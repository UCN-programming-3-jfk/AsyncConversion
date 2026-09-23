using AsyncConversion.DataAccess;
using AsyncConversion.DataAccess.Model;

namespace AsyncConversion.BusinessLogic;

public class BusinessLogicLayer
{
    public DataAccessLayer DataAccess { get; }
    public BusinessLogicLayer(DataAccessLayer dataAccess)
    {
        DataAccess = dataAccess;
    }


    public IEnumerable<Customer> GetCustomers()
    {
        return DataAccess.GetCustomers();
    }
}