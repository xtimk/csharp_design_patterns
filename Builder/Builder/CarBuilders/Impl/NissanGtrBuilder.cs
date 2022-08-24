namespace Builder.CarBuilders.Impl
{
    public class NissanGtrBuilder : CarBuilder
    {
        public NissanGtrBuilder()
        {
            car = new Car();
        }

        public override void BuildModel()
        {
            car.Model = "Nissan GT-R";
        }
        public override void BuildEngine()
        {
            car.Engine = "3.8 L twin-turbocharged VR38DETT V6";
        }

        public override void BuildSuspensions()
        {
            car.Suspensions = "Suspensions Nissans";
        }

        public override void BuildTires()
        {
            car.Tires = "Style new wheels";
        }
    }
}