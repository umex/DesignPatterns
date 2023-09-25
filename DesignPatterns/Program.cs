// See https://aka.ms/new-console-template for more information
using DesignPatterns.Builder.Builder;
using DesignPatterns.Builder.BuilderInheritance;
using DesignPatterns.Builder.FacetedBuilder;
using DesignPatterns.Builder.FunctionalBuilder;
using DesignPatterns.Builder.StepwiseBuilder;
using DesignPatterns.SOLID.DIP;
using DesignPatterns.SOLID.LP;
using DesignPatterns.SOLID.OCP;
using DesignPatterns.SOLID.SRP;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


//SOLID SRP - single responsibility principle
/*
var j = new Journal();
j.AddEntry("I laughed today.");
j.AddEntry("I ate a bug.");
Console.WriteLine(j);

var p = new Persistence();
var filename = @"c:\temp\journal.txt";
p.SaveToFile(j, filename);
Process.Start(filename);
*/

//SOLID OCP - open closed principle
/*
var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

var pf = new ProductFilter();
Console.WriteLine("Green products (old):");
foreach (var p in pf.FilterByColor(products, Color.Green))
    Console.WriteLine($" - {p.Name} is green");

// ^^ BEFORE

// vv AFTER
var bf = new BetterFilter();
Console.WriteLine("Green products (new):");
foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
    Console.WriteLine($" - {p.Name} is green");

Console.WriteLine("Large products");
foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
    Console.WriteLine($" - {p.Name} is large");

Console.WriteLine("Large blue items");
foreach (var p in bf.Filter(products,
  new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
)
{
    Console.WriteLine($" - {p.Name} is big and blue");
}
*/

//SOLID LP - Liskov principle
/*
static int Area(Rectangle r) => r.Width * r.Height;
Rectangle rc = new Rectangle(2, 3);
Console.WriteLine($"{rc} has area {Area(rc)}");

// should be able to substitute a base type for a subtype
//Square
Rectangle sq = new Square();
sq.Width = 4;
Console.WriteLine($"{sq} has area {Area(sq)}");
*/

//SOLID DIP - Dependency inversion principle
/*
var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Matt" };

// low-level module
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);
3
new Research(relationships);
*/

//Builder - Fluent Builder
//BuilderMain.Main(new string[3]);

//Builder - Inheritance builder
//BuilderInheritanceMain.Main(new string[3]);

//Builder - Stepwise builder
//StepwiseBuilderMain.Main(new string[3]);

//Builder - Functional builder
//FunctionalBuilder.Main(new string[3]);

//Builder - Facets builder
FactetedBuilderMain.Main(new string[3]);