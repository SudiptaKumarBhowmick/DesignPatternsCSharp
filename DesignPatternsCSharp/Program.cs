using DesignPatternsCSharp.BuilderMethod.Consumer;
using DesignPatternsCSharp.FactoryMethod.Consumer;

namespace DesignPatternsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodConsumer factoryMethodConsumer = new FactoryMethodConsumer();
            //factoryMethodConsumer.ConsumeFactoryMethod();


            BuilderMethodConsumer builderMethodConsumer = new BuilderMethodConsumer();
            builderMethodConsumer.ConsumeBuilderMethod();


            Console.ReadKey();
        }
    }
}
