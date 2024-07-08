using DesignPatternsCSharp.StrategyPattern.StrategyAbstract;

namespace DesignPatternsCSharp.StrategyPattern.ConcreteStrategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}
