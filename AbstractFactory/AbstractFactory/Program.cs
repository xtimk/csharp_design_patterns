// See https://aka.ms/new-console-template for more information
using AbstractFactory.Factories;
using AbstractFactory.Factories.Impl;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<ClassicFornitureFactory>()
    .AddSingleton<ModernFornitureFactory>()
    .BuildServiceProvider();

IFornitureFactory factory = serviceProvider.GetRequiredService<ClassicFornitureFactory>();
var element = factory.CreateChair();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = serviceProvider.GetRequiredService<ModernFornitureFactory>();
element = factory.CreateChair();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = serviceProvider.GetRequiredService<ClassicFornitureFactory>();
element = factory.CreateTable();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

factory = serviceProvider.GetRequiredService<ModernFornitureFactory>();
element = factory.CreateTable();
Console.WriteLine(element.GetStyle() + "-" + element.GetName());

// This will throw a not implemented ex
try
{
    element = factory.CreateSofa();
} catch (Exception ex)
{
    Console.WriteLine("Ooops..\n" + ex);
}