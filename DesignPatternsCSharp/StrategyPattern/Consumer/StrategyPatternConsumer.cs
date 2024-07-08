using DesignPatternsCSharp.StrategyPattern.ConcreteStrategy;
using DesignPatternsCSharp.StrategyPattern.StrategyContext;

namespace DesignPatternsCSharp.StrategyPattern.Consumer
{
    public class StrategyPatternConsumer
    {
        public void ConsumeStrategyPattern()
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();
        }
    }
}
