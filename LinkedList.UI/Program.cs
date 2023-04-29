
using LinkedList.Logic;
using System.Diagnostics;

Console.WriteLine("Parcial");
var carList = new DoubleList<Car>();


carList.Add(new Car { Brand = "Toyota",     Model = "Prado TXL",             Year = 2023, Color = "BLaco Perlado", Price = 435000000 });
carList.Add(new Car { Brand = "Lexus",      Model = "LX600 F Sport",         Year = 2023, Color = "Gris Raton",    Price = 680000000 });
carList.Add(new Car { Brand = "Chevrolet",  Model = "Dmax",                  Year = 2020, Color = "Azul",          Price = 95000000  });
carList.Add(new Car { Brand = "Ford",       Model = "Raptor",                Year = 2022, Color = "Negro",         Price = 335000000 });
carList.Add(new Car { Brand = "Mazda",      Model = "CX 30",                 Year = 2021, Color = "BLaco ",        Price = 128000000 });
carList.Add(new Car { Brand = "Nissan",     Model = "Frontier",              Year = 2018, Color = "Rojo pasion",   Price = 59000000 });
carList.Add(new Car { Brand = "Volkswagen", Model = "Amarok",                Year = 2019, Color = "Gris Plata",    Price = 90000000 });
carList.Add(new Car { Brand = "Tesla",      Model = "model S",               Year = 2018, Color = "BLaco Perlado", Price = 330000000 });
carList.Add(new Car { Brand = "Volvo",      Model = "Xc60 T8 Ultimate Dark", Year = 2023, Color = "Estratoperla",  Price = 568000000 });
carList.Add(new Car { Brand = "Renault",    Model = "Sandero Stepway",       Year = 2009, Color = "Gris",          Price = 28500000 });
carList.Add(new Car { Brand = "Kia",        Model = "Sportage",              Year = 2017, Color = "Vinotinto",     Price = 88000000 });
carList.Add(new Car { Brand = "Toyota",     Model = "Hilux",                 Year = 2029, Color = "BLaco Perlado", Price = 259000000 });
Console.WriteLine(carList);

Console.WriteLine("<---------Filtro marcas---------------> ");
var brand = carList.GetBrand("Toyota");
Console.WriteLine(brand);

Console.WriteLine("<---------Filtro por AÑos---------------> ");
var year = carList.GetYear(2022, 2023);
Console.WriteLine(year);

Console.WriteLine("<---------Filtro de Precios---------------> ");
var price = carList.GetPrice(200000000,300000000);

Console.WriteLine(price);

Console.WriteLine("<---------Filtros---------------> ");
var filteredCars = carList.GetSeveralFilters("Honda", "*", "Blue", 2010, 20000.00m);
Console.WriteLine(filteredCars);

Console.WriteLine("<---------Filtros de menor y mayor precio---------------> ");
Car[] minMaxCars = carList.GetMinMax(carList);
Console.WriteLine($"Carro con menor precio: {minMaxCars[0]}");
Console.WriteLine($"Carro con mayor precio: {minMaxCars[1]}");
