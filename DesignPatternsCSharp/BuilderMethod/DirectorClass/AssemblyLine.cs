using DesignPatternsCSharp.BuilderMethod.BuilderClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderMethod.DirectorClass
{
    /// 
    /// The Director class
    /// 
    public class AssemblyLine
    {
        // Builder uses a complex series of steps
        public void Assemble(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.AddDough();
            pizzaBuilder.AddSauce();
            pizzaBuilder.AddCheeses();
            pizzaBuilder.AddMeats();
            pizzaBuilder.AddVeggies();
            pizzaBuilder.AddExtras();
        }
    }
}
