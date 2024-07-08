using DesignPatternsCSharp.ObserverPattern.AbstractSubject;

namespace DesignPatternsCSharp.ObserverPattern.AbstractObserver
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
