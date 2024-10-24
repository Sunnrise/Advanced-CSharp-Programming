
using System.Diagnostics;

Person person = new Person
{
    x = 123,
    Name = "AlperenGunes",
    City = "Eskisehir",
    Country = "TR"
};

var p= person;


Console.WriteLine();

[DebuggerDisplay("Name : {Name} | x : {x} | Age : {Age}")] //Shift+F9 to see the result
class Person
{
    public int x;
    public string Name { get; set; }
    int Age { get; set; } = 24;
    public string City { get; set; }
    public string Country { get; set; }
}