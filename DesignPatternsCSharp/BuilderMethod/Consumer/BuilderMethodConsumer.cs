using DesignPatternsCSharp.BuilderMethod.BuilderClass;
using DesignPatternsCSharp.BuilderMethod.ConcreteBuilderClass;
using DesignPatternsCSharp.BuilderMethod.DirectorClass;

namespace DesignPatternsCSharp.BuilderMethod.Consumer
{
    public class BuilderMethodConsumer
    {
        public void ConsumeBuilderMethod()
        {
            //https://dev.to/kalkwst/the-builder-pattern-in-c-5bcc
            PizzaBuilder builder;

            // Create a pizza assembly line
            AssemblyLine shop = new AssemblyLine();

            // Construct and display pizzas
            builder = new MeatFeastHot();
            shop.Assemble(builder);
            builder.Pizza.Display();

            builder = new HotNSpicyVeg();
            shop.Assemble(builder);
            builder.Pizza.Display();
        }
    }
}
