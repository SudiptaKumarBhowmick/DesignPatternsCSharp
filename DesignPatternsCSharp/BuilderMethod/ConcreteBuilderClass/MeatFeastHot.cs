using DesignPatternsCSharp.BuilderMethod.BuilderClass;
using DesignPatternsCSharp.BuilderMethod.ProductClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.BuilderMethod.ConcreteBuilderClass
{
    /// 
    /// A ConcreteBuilder class
    /// 
    class MeatFeastHot : PizzaBuilder
    {
        public MeatFeastHot()
        {
            pizza = new Pizza("Meat Feast Hot");
        }

        public override void AddDough()
        {
            pizza["dough"] = "Wheat pizza dough";
        }

        public override void AddSauce()
        {
            pizza["sauce"] = "Tomato base";
        }

        public override void AddMeats()
        {
            pizza["meats"] = "Pepperoni, Ham, Beef, Chicken";
        }

        public override void AddCheeses()
        {
            pizza["cheeses"] = "Signature triple cheese blend, mozzarella";
        }

        public override void AddVeggies()
        {
            pizza["veggies"] = "";
        }

        public override void AddExtras()
        {
            pizza["extras"] = "jalapenos";
        }
    }
}
