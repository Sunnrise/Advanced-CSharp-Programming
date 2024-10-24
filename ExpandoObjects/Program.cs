
using System.Dynamic;

dynamic person = new ExpandoObject();

person.name = "Alperen";
person.age = 24;
person.surname = "Gunes";
person.yearOfBirth= new Func<int>(() => DateTime.Now.Year - person.age);

IDictionary<string, object> dataDictionary = (IDictionary<string, object>)person;
foreach(KeyValuePair<string, object> item in dataDictionary)
{
    if (item.Value is Delegate)
    {
        Console.WriteLine($"{item.Key}: {((Func<int>)item.Value).Invoke()}");
    }
    else
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
