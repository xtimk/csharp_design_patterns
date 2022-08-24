// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.CarBuilders;
using Builder.CarBuilders.Impl;
using Builder.Garages;

CarBuilder builder;
var complete_garage = new CompleteGarage();

builder = new Ae86TruenoBuilder();
complete_garage.Construct(builder);
builder.GetCar().GetAllCarDetails();

builder = new NissanGtrBuilder();
complete_garage.Construct(builder);
builder.GetCar().GetAllCarDetails();

var useless_garage = new UselessGarage();
builder = new Ae86TruenoBuilder();
useless_garage.Construct(builder);
builder.GetCar().GetAllCarDetails();
