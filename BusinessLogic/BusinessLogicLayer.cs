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


    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        return await DataAccess.GetCustomersAsync();
    }
}