using DesignPatternsCSharp.AbstractFactory.Consumer;
using DesignPatternsCSharp.BuilderMethod.Consumer;
using DesignPatternsCSharp.CommandPattern.Consumer;
using DesignPatternsCSharp.FacadePattern.Consumer;
using DesignPatternsCSharp.FactoryMethod.Consumer;
using DesignPatternsCSharp.IteratorPattern.Consumer;
using DesignPatternsCSharp.PrototypePattern.Consumer;

namespace DesignPatternsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethodConsumer factoryMethodConsumer = new FactoryMethodConsumer();
            //factoryMethodConsumer.ConsumeFactoryMethod();


            //BuilderMethodConsumer builderMethodConsumer = new BuilderMethodConsumer();
            //builderMethodConsumer.ConsumeBuilderMethod();


            //AbstractFactoryConsumer abstractFactoryConsumer = new AbstractFactoryConsumer();
            //abstractFactoryConsumer.ConsumeAbstractFactory();


            //PrototypePatternConsumer prototypePatternConsumer = new PrototypePatternConsumer();
            //prototypePatternConsumer.ConsumePrototypePattern();


            //CommandPatternConsumer commandPatternConsumer = new CommandPatternConsumer();
            //commandPatternConsumer.ConsumeCommandPattern();


            //FacadePatternConsumer facadePatternConsumer = new FacadePatternConsumer();
            //facadePatternConsumer.ConsumeFacadePattern();


            IteratorPatternConsumer iteratorPatternConsumer = new IteratorPatternConsumer();
            iteratorPatternConsumer.ConsumeIteratorPattern();


            Console.ReadKey();
        }
    }
}
