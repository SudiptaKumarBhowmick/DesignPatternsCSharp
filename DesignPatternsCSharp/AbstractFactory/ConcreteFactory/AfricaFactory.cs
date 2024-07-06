using DesignPatternsCSharp.AbstractFactory.AbstractProduct;
using DesignPatternsCSharp.AbstractFactory.Factory;
using DesignPatternsCSharp.AbstractFactory.Product;

namespace DesignPatternsCSharp.AbstractFactory.ConcreteFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
