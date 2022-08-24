using Builder.CarBuilders;
using Builder.CarBuilders.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Builder.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var directorMock = new Mock<Ae86TruenoBuilder>();
        // directorMock.Setup(m => m.BuildEngine());
        var director = directorMock.Object;
        var complete_garage = new CompleteGarage();
        complete_garage.Construct(director);

        var car = director.GetCar();
        car.GetAllCarDetails();

    }
}