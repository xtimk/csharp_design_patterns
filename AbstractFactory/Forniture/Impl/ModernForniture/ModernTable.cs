using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Forniture.Impl.ModernForniture
{
    public class ModernTable : IForniture
    {
        private string _style;
        private string _name;
        public ModernTable()
        {
            _style = "Modern";
            _name = "Table";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetStyle()
        {
            return _style;
        }
    }
}