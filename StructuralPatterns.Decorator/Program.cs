// See https://aka.ms/new-console-template for more information

using StructuralPatterns.Decorator;
using StructuralPatterns.Decorator.Decorators;

var repo = new Repository();
Console.WriteLine("Add new item without logging");
repo.Add("New item");
Console.WriteLine("Delete the item without logging");
repo.Delete("The item");
Console.WriteLine("Find the item without logging");
repo.Delete("The item");

Console.WriteLine("-----------------------------");

var logginDecorator = new LoggingDecorator(repo);
Console.WriteLine("Add new item with logging");
logginDecorator.Add("New item");
Console.WriteLine("Delete the item with logging");
logginDecorator.Delete("The item");
Console.WriteLine("Find the item with logging");
logginDecorator.Delete("The item");

Console.ReadKey();
