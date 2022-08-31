using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia("123456789", "Modelo1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Zap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone("122332432", "Modelo2", "1111132331", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Zap");