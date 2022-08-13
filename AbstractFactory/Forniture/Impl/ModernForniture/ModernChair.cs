using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Forniture.Impl.ModernForniture
{
    public class ModernChair : IForniture
    {
        // Property that exists only on classic chair
        public string ClassicChairSerial { get; set; }
        private string _style;
        private string _name;
        public ModernChair()
        {
            _style = "Modern";
            _name = "Chair";
            ClassicChairSerial = Guid.NewGuid().ToString();

        }

        public string GetName()
        {
            return _name;
        }

        public string GetStyle()
        {
            return _style;
        }

        public void SitOnMe()
        {
            Console.WriteLine("Someone sitted into " + _style + "-" + _name );
        }
    }
}