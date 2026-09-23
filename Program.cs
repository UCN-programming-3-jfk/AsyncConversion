using AsyncConversion.BusinessLogic;
using AsyncConversion.DataAccess;
using AsyncConversion.UI;

namespace AsyncConversion;
internal class Program
{
    static void Main(string[] args)
    {
        DataAccessLayer dataAccess = new();
        BusinessLogicLayer businessLogicLayer = new(dataAccess);
        UILayer ui = new(businessLogicLayer);

        ui.Run();
    }
}