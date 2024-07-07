using DesignPatternsCSharp.FacadePattern.Facade;

namespace DesignPatternsCSharp.FacadePattern.Consumer
{
    public class FacadePatternConsumer
    {
        public void ConsumeFacadePattern()
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");

            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();

            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");

            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}
