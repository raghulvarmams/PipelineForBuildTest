// See https://aka.ms/new-console-template for more information
using PipelineForBuildTest;

Console.WriteLine("This Application is used to Add/ Concatinate the given inputs");

Console.WriteLine("Enter the First Value");
dynamic value1 = Console.ReadLine();
Console.WriteLine("Enter the Second Value");
dynamic value2 = Console.ReadLine();

Concatinator genericAdder = new Concatinator();

var response = genericAdder.AddorConcat(value1, value2);
Console.WriteLine("Response: "+response.ToString());