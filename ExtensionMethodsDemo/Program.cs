// See https://aka.ms/new-console-template for more information
using ExtensionMethodsDemo;

Console.WriteLine("Hello, World!");

int n1 = 2;
Console.WriteLine(n1.Pow(3));
Console.WriteLine(n1.ConcatTwoNumsToStr(147,"Bar"));

string str = "Bar";
Console.WriteLine(str.AddNameToStart("Queen"));

var mapEntity = new MapEntity()
{
    EntityName="Jerusalem",
    Y = 2,
    X = 3
};
Console.WriteLine(mapEntity.ToString());

mapEntity.MoveDegree(2);
Console.WriteLine(mapEntity.ToString());

