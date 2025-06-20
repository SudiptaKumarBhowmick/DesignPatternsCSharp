﻿using DesignPatternsCSharp.AbstractFactory.AbstractProduct;
using DesignPatternsCSharp.AbstractFactory.Factory;

namespace DesignPatternsCSharp.AbstractFactory.Client
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
