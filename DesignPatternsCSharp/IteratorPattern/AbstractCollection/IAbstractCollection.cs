using DesignPatternsCSharp.IteratorPattern.ConcreteIterator;

namespace DesignPatternsCSharp.IteratorPattern.AbstractCollection
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
