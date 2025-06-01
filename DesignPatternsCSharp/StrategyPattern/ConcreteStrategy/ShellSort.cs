using DesignPatternsCSharp.StrategyPattern.StrategyAbstract;

namespace DesignPatternsCSharp.StrategyPattern.ConcreteStrategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort();  not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
