using AsyncConversion.BusinessLogic;
using AsyncConversion.DataAccess;
using AsyncConversion.UI;

namespace AsyncConversion;

internal class Program
{
    public static async Task Main(string[] args)
    {
        DataAccessLayer dataAccess = new();
        BusinessLogicLayer businessLogicLayer = new(dataAccess);
        UILayer ui = new(businessLogicLayer);

       await ui.Run();

    }
}
