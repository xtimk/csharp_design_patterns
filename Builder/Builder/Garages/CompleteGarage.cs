using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.CarBuilders;

namespace Builder
{
    public class CompleteGarage
    {
        // A Complete garage, that builds all parts of the car
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.SetGarageDirector("CompleteGarage");
            carBuilder.BuildModel();
            carBuilder.BuildEngine();
            carBuilder.BuildSuspensions();
            carBuilder.BuildTires();
        }
    }
}