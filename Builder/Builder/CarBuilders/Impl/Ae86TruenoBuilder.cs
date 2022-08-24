using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.CarBuilders.Impl
{
    public class Ae86TruenoBuilder : CarBuilder
    {
        public Ae86TruenoBuilder()
        {
            car = new Car();
        }
        public override void BuildModel()
        {
            car.Model = "Toyota AE86-Trueno";
        }

        public override void BuildEngine()
        {
            car.Engine = "1.6 L 4A-C I4 SOHC";
        }

        public override void BuildSuspensions()
        {
            car.Suspensions = "Suspensions AE86";
        }

        public override void BuildTires()
        {
            car.Tires = "Amazing old wheels";
        }
    }
}