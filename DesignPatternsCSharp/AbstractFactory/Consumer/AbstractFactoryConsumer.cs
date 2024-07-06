using DesignPatternsCSharp.AbstractFactory.Client;
using DesignPatternsCSharp.AbstractFactory.ConcreteFactory;
using DesignPatternsCSharp.AbstractFactory.Factory;

namespace DesignPatternsCSharp.AbstractFactory.Consumer
{
    public class AbstractFactoryConsumer
    {
        //https://www.dofactory.com/net/abstract-factory-design-pattern
        public void ConsumeAbstractFactory()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
