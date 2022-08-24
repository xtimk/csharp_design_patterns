using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder.CarBuilders
{
    public abstract class CarBuilder
    {
        // public string getModel();
        // public string getEngine();
        // public string getSuspension();
        // public int getHorsePower();
        // public string getTires();
        protected ICar car;

        public ICar GetCar()
        {
            return car;
        }
        
        public abstract void BuildModel();
        public abstract void BuildEngine();
        public abstract void BuildSuspensions();
        public abstract void BuildTires();
        public void SetGarageDirector(string garage)
        {
            car.Garage = garage;
        }
    }
}