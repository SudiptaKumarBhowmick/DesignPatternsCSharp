
using DesignPatternsCSharp.FactoryMethod.ConcreteCreator;
using DesignPatternsCSharp.FactoryMethod.Creator;
using DesignPatternsCSharp.FactoryMethod.Product;

namespace DesignPatternsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of factory method");

            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                    page.PrintMessage();

                    Console.WriteLine("\n");
                }
            }

            Console.ReadKey();
        }
    }
}
