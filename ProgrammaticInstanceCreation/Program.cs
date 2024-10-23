#region Instance Creation with Activator Class
//Type type = typeof(MyClass);
//MyClass m = (MyClass)Activator.CreateInstance(type);


//class MyClass
//{
//    public MyClass()
//    {
//        Console.WriteLine($"{nameof(MyClass)} instance has been created!!");
//    }
//}
#endregion

#region Instance Creation with DynamicObject

//using System.Dynamic;

//dynamic obj = new MyClass();

//obj.Property1 = "Alperengunes";
//obj.Property2 = 24;

//Console.WriteLine(obj.Property1);


//class MyClass : DynamicObject
//{
//    public MyClass()
//    {
//        Console.WriteLine($"{nameof(MyClass)} instance has been created!!");
//    }
//    readonly private Dictionary<string, object> properties = new();
//    public override bool TrySetMember(SetMemberBinder binder, object? value)
//    {
//        properties.Add(binder.Name, value);
//        return true;
//    }
//    public override bool TryGetMember(GetMemberBinder binder, out object? result)
//    {
//        return properties.TryGetValue(binder.Name, out result);
//    }
//}


#endregion

#region Instance Creation with Dynamic Keyword
using System.Dynamic;

dynamic obj= new ExpandoObject();
obj.Property1 = "24";
obj.Property2 = 24;


class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance has been created!!");
    }
    readonly private Dictionary<string, object> properties = new();
    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        properties.Add(binder.Name, value);
        return true;
    }
    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return properties.TryGetValue(binder.Name, out result);
    }
}
#endregion

