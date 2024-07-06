using DesignPatternsCSharp.AbstractFactory.AbstractProduct;

namespace DesignPatternsCSharp.AbstractFactory.Product
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
