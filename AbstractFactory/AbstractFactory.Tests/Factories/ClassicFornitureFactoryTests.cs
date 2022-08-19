using System;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Impl;
using AbstractFactory.Forniture.Impl.ClassicForniture;
using Xunit;

namespace AbstractFactory.Tests;
public class ClassicFornitureFactoryTests
{
    private IFornitureFactory _classicFornitureFactory;
    public ClassicFornitureFactoryTests()
    {   
        _classicFornitureFactory = new ClassicFornitureFactory();
    }

    [Fact]
    public void ClassicFornitureFactory_CreateTable_ShouldCreate_ClassicTableObj()
    {
        var table = _classicFornitureFactory.CreateTable();
        Assert.IsType<ClassicTable>(table);
    }

    [Fact]
    public void ClassicFornitureFactory_CreateChair_ShouldCreate_ClassicChairObj()
    {
        var chair = _classicFornitureFactory.CreateChair();
        Assert.IsType<ClassicChair>(chair);
    }
}