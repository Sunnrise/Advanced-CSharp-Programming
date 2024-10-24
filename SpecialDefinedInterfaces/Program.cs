#region IComparer

//Person p1 = new() { Name = "John", Age = 25 };
//Person p2 = new() { Name = "alperen", Age = 24 };
//Person p3 = new() { Name = "david", Age = 57 };
//Person p4 = new() { Name = "maria", Age = 50 };

//List<Person> people = new() { p1, p2, p3, p4 };
//people.ForEach(p => Console.WriteLine(p.Name));
//Console.WriteLine("******************");
//people.Sort(new AgeComparer());
//people.ForEach(p => Console.WriteLine(p.Name));

//AgeComparer ageComparer = new();
//var result = ageComparer.Compare(p1, p2);
//Console.WriteLine(result);

//class AgeComparer : IComparer<Person>
//{
//    public int Compare(Person x, Person y)
//    {
//        return x.Age.CompareTo(y.Age);
//        //It returns -1,0 , 1
//    }
//}
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

#endregion

#region IComparable

//Person p1 = new() { Name = "John", Age = 25 };
//Person p2 = new() { Name = "alperen", Age = 24 };
//var result = p1.CompareTo(p2);
//Console.WriteLine(result);

//class Person : IComparable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public int CompareTo(Person other)
//    {
//        return Age.CompareTo(other.Age);
//    }
//}

#endregion

#region IClonable

//Person p2 = new() { Name = "alperen", Age = 24 };
//p2.Clone();

//class Person : ICloneable
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public object Clone()
//    {
//        return this.MemberwiseClone();
//        // or 
//        //return new Person { Name = this.Name, Age = this.Age }; // we have define object type to Person
//    }
//}

#endregion

#region INofityPropertyChanged

//using System.ComponentModel;
//Person p = new() { Name = "Alperen", Age = 24 };
//p.PropertyChanged += (sender, e) =>
//{
//    Console.WriteLine($"{e.PropertyName} has been changed to {(sender as Person)?.Age}");
//};
//p.Age = 25;
//p.Age = 26;
//p.Age = 27;
//p.Age = 28;
//p.Age = 29;
//p.Age = 30;
//class Person : INotifyPropertyChanged
//{
//    public string Name { get; set; }
//    int age;
//    public int Age {
//        get 
//        {
//            return age;
//        }
//        set 
//        {
//            age = value;
//            PropertyChanged?.Invoke(this, new(nameof(Age)));
//        }
//    }

//    public event PropertyChangedEventHandler? PropertyChanged;
//}

#endregion

#region IEquatable

//Person p2 = new() { Name = "alperen", Age = 24 };
//Person p1 = new() { Name = "mustafa", Age = 53 };
//var result = p1.Equals(p2);
//Console.WriteLine(result);
//class Person : IEquatable<Person>
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public bool Equals(Person? other)
//    {
//        return Name == other?.Name && Age == other?.Age;
//    }
//}

#endregion

#region IEnumerable

//using System.Collections;

//SchoolBag schoolBag = new();

//ArrayList arrayList = new();

//foreach (var item in schoolBag)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("***********************");

//var result = schoolBag.Where(s=> s.EndsWith("r"));

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}



//class SchoolBag : IEnumerable<string>
//{
//    List<string> list = new List<string>() {"pencil", "rubber", "eraser", "notebook"};
//    public IEnumerator GetEnumerator()
//    {
//        return list.GetEnumerator();
//    }

//    IEnumerator<string> IEnumerable<string>.GetEnumerator()
//    {
//        return list.GetEnumerator();
//    }
//}

#endregion

#region IDisposable

using System.Data.SqlClient;
using MyDatabase m1 = new();
// or 
using(MyDatabase m2 = new())
{

}
class MyDatabase : IDisposable
{
    SqlConnection sqlConnection;
    SqlCommand sqlCommand;

    public void Dispose()
    {
        sqlConnection= null;
        sqlCommand = null;
    }
}

#endregion

#region IEnumerator

#endregion
