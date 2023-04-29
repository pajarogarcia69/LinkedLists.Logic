
using LinkedList.Logic;
using System.Diagnostics;

Console.WriteLine("PArcial");
var car = new DoubleList<Car>();
var year = car.GetYear(2018, 2022);

car.Add(new Car { Brand = "Toyota",     Model = "Prado TXL",             Year = 2023, Color = "BLaco Perlado", Price = 435000000 });
car.Add(new Car { Brand = "Lexus",      Model = "LX600 F Sport",         Year = 2023, Color = "Gris Raton",    Price = 680000000 });
car.Add(new Car { Brand = "Chevrolet",  Model = "Dmax",                  Year = 2020, Color = "Azul",          Price = 95000000  });
car.Add(new Car { Brand = "Ford",       Model = "Raptor",                Year = 2022, Color = "Negro",         Price = 335000000 });
car.Add(new Car { Brand = "Mazda",      Model = "CX 30",                 Year = 2021, Color = "BLaco ",        Price = 128000000 });
car.Add(new Car { Brand = "Nissan",     Model = "Frontier",              Year = 2018, Color = "Rojo pasion",   Price = 59000000 });
car.Add(new Car { Brand = "Volkswagen", Model = "Amarok",                Year = 2019, Color = "Gris Plata",    Price = 90000000 });
car.Add(new Car { Brand = "Tesla",      Model = "model S",               Year = 2018, Color = "BLaco Perlado", Price = 330000000 });
car.Add(new Car { Brand = "Volvo",      Model = "Xc60 T8 Ultimate Dark", Year = 2023, Color = "Estratoperla",  Price = 568000000 });
car.Add(new Car { Brand = "Renault",    Model = "Sandero Stepway",       Year = 2009, Color = "Gris",          Price = 28500000 });
car.Add(new Car { Brand = "Kia",        Model = "Sportage",              Year = 2017, Color = "Vinotinto",     Price = 88000000 });
car.Add(new Car { Brand = "Toyota",     Model = "Hilux",                 Year = 2029, Color = "BLaco Perlado", Price = 259000000 });
Console.WriteLine(car);
Console.WriteLine(year);
var brand = car.GetBrand("Toyota");
Console.WriteLine(brand);
var price = car.GetPrice(20000000,300000000);
Console.WriteLine(price);
var filteredCars = car.GetSeveralFilters("*", "*", "Gris", 2019, 450000000);
Console.WriteLine(filteredCars);
Car[] minMaxCars = car.GetMinMax(car);
Console.WriteLine($"Carro con menor precio: {minMaxCars[0]}");
Console.WriteLine($"Carro con mayor precio: {minMaxCars[1]}");
