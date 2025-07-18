﻿using DesignPatternsCSharp.AbstractFactory.AbstractProduct;

namespace DesignPatternsCSharp.AbstractFactory.Product
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
