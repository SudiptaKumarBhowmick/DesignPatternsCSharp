﻿using DesignPatternsCSharp.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.FactoryMethod.ConcreteProduct
{
    public class IntroductionPage : Page
    {
        public override void PrintMessage()
        {
            Console.WriteLine("Printing message from introduction page");
        }
    }
}
