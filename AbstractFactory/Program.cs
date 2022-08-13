// See https://aka.ms/new-console-template for more information
using AbstractFactory.Factories;
using AbstractFactory.Factories.Impl;

IFornitureFactory factory = new ClassicFornitureFactory();
var element = factory.CreateChair();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = new ModernFornitureFactory();
element = factory.CreateChair();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = new ClassicFornitureFactory();
element = factory.CreateTable();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = new ModernFornitureFactory();
element = factory.CreateTable();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

// This will throw a not implemented ex
try
{
    element = factory.CreateSofa();
} catch (Exception ex)
{
    Console.WriteLine("Ooops.. " + ex);
}