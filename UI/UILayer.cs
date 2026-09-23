using AsyncConversion.BusinessLogic;
namespace AsyncConversion.UI;
public class UILayer
{
    public BusinessLogicLayer BusinessLogicLayer { get; }
    public UILayer(BusinessLogicLayer businessLogicLayer)
    {
        BusinessLogicLayer = businessLogicLayer;
    }


    public async Task Run()
    {
        Console.WriteLine("Would you like to see the customers? (Yes/No)");
        if (Console.ReadLine().ToUpper().Contains("Y"))
        {
            Console.WriteLine("CUSTOMERS");
            var customers = await BusinessLogicLayer.GetCustomersAsync();
            customers.ToList().ForEach(Console.WriteLine);
        }
    }
}