using AsyncConversion.BusinessLogic;
using AsyncConversion.DataAccess;
using AsyncConversion.UI;

namespace AsyncConversion;

internal class Program
{
    static void Main(string[] args)
    {
        DataAccess.DataAccessLayer dataAccess = new();
        BusinessLogic.BusinessLogicLayer businessLogicLayer = new(dataAccess);
        UILayer ui = new(businessLogicLayer);

        ui.Run();

    }
}
