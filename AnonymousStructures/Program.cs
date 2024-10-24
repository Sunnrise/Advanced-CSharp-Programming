#region Anonymous Objects

//var anonymousObject = new 
//{
//    A= "alperen",
//    Z = 24 
//};
//Console.WriteLine(anonymousObject.A);
//// Anonymous objects are read-only, so you can't change the value of the property.
#endregion

#region Anonymous Methods

//Additon add = new Additon((number1, number2) => number1 + number2);
//Additon add2 = (number1, number2) => number1 + number2;

//Additon add3 = delegate(int number1, int number2)
//{
//    return number1 + number2;
//};

//var function1 = () => {Console.WriteLine("Hello");};
//var function2 = (char Z) => { Console.WriteLine(Z); };
//var function3 = (int Z) => { return true; };
//var function4 = (int a, string z) => { return true; };


//delegate int Additon(int number1, int number2);

#endregion

#region Anonymous Collections

// Arrays


using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

var array = new[] { 1, 2, 3, 4, 5 };

// List
var y = new Collection()
{
    new { Name = "Alperen", Age = 24 },
    new { Name = "Alperen", Age = 24 },
    new { Name = "Alperen", Age = 24 }
};
#endregion