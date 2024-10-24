// See https://aka.ms/new-console-template for more information
using AccessModifiersClassLibrary;

Console.WriteLine("Hello, World!");

Class1 c1 = new();

c1.X();
c1.Y(); // Error: 'Class1.Y()' is inaccessible due to its protection level(private)
c1.Z(); // Error: 'Class1.Z()' is inaccessible due to its protection level(protected)

Class2 c2 = new(); // Error: 'Class2' is inaccessible due to its protection level(private)

c1.V(); // Error: 'Class1.V()' is inaccessible due to its protection level(protected internal)

class MyClass: Class1
{
    public MyClass()
    {
        V(); // We can call V() from MyClass because MyClass is a subclass of Class1
        U(); // Error: 'Class1.U()' is inaccessible due to its protection level('private' protected)
    }
}