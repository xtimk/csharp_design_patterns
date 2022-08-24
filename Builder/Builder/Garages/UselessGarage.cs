using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Builder.CarBuilders;

namespace Builder.Garages
{
    public class UselessGarage
    {
        // this garage only builds the models..
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.SetGarageDirector("UselessGarage");
            carBuilder.BuildModel();
        }
    }
}