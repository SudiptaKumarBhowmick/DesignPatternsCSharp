﻿using DesignPatternsCSharp.IteratorPattern.AbstractIterator;
using DesignPatternsCSharp.IteratorPattern.ConcreteCollection;
using DesignPatternsCSharp.IteratorPattern.Product;

namespace DesignPatternsCSharp.IteratorPattern.ConcreteIterator
{
    public class Iterator : IAbstractIterator
    {
        Collection collection;
        int current = 0;
        int step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        // Gets first item
        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            current += step;
            if (!IsDone)
                return CurrentItem;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        // Gets current iterator item
        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
