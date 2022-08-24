using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICar
    {
        public string Garage { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Tires { get; set; }
        public string Suspensions { get; set; }
        public void GetAllCarDetails();
    }
}