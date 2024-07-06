using DesignPatternsCSharp.AbstractFactory.AbstractProduct;
using DesignPatternsCSharp.AbstractFactory.Factory;
using DesignPatternsCSharp.AbstractFactory.Product;

namespace DesignPatternsCSharp.AbstractFactory.ConcreteFactory
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
