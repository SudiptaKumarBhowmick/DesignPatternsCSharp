﻿using DesignPatternsCSharp.PrototypePattern.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.PrototypePattern.ConcretePrototype
{
    public class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;
        // Constructor
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0},{1},{2}",
                red, green, blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
