using DesignPatternsCSharp.IteratorPattern.Product;

namespace DesignPatternsCSharp.IteratorPattern.AbstractIterator
{
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
