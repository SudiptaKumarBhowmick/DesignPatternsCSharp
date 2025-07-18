﻿using DesignPatternsCSharp.ObserverPattern.AbstractObserver;
using DesignPatternsCSharp.ObserverPattern.AbstractSubject;

namespace DesignPatternsCSharp.ObserverPattern.ConcreteObserver
{
    internal class Investor : IInvestor
    {
        private string name;
        private Stock stock;

        // Constructor
        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", name, stock.Symbol, stock.Price);
        }

        // Gets or sets the stock
        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}
