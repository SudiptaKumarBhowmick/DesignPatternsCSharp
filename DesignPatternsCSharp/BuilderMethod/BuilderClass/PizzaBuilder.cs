using DesignPatternsCSharp.BuilderMethod.ProductClass;

namespace DesignPatternsCSharp.BuilderMethod.BuilderClass
{
    /// 
    /// The Builder Abstract class
    /// 
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        // Get the pizza instance
        public Pizza Pizza
        {
            get { return pizza; }
        }

        public abstract void AddDough();
        public abstract void AddSauce();
        public abstract void AddMeats();
        public abstract void AddCheeses();
        public abstract void AddVeggies();
        public abstract void AddExtras();
    }

}