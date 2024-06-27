using DesignPatternsCSharp.FactoryMethod.ConcreteProduct;
using DesignPatternsCSharp.FactoryMethod.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.FactoryMethod.ConcreteCreator
{
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
