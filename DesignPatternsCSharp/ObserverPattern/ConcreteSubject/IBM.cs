using DesignPatternsCSharp.ObserverPattern.AbstractSubject;

namespace DesignPatternsCSharp.ObserverPattern.ConcreteSubject
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
