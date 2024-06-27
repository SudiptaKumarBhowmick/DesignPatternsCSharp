using DesignPatternsCSharp.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.FactoryMethod.Creator
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();       
        }

        public List<Page> Pages
        {
            get
            {
                return _pages;
            }
        }

        //Factory method
        public abstract void CreatePages();
    }
}
