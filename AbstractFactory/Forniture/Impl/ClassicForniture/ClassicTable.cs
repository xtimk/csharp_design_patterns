using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Forniture.Impl.ClassicForniture
{
    public class ClassicTable : IForniture
    {
        private string _style;
        private string _name;
        public ClassicTable()
        {
            _style = "Classic";
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