﻿using DesignPatternsCSharp.AbstractFactory.Consumer;
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


            //BuilderMethodConsumer builderMethodConsumer = new BuilderMethodConsumer();
            //builderMethodConsumer.ConsumeBuilderMethod();


            AbstractFactoryConsumer abstractFactoryConsumer = new AbstractFactoryConsumer();
            abstractFactoryConsumer.ConsumeAbstractFactory();


            Console.ReadKey();
        }
    }
}
