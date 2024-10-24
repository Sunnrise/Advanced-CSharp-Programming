#region Attributes Entry
//[AttributeUsage(AttributeTargets.All)]
//class MyAttribute : Attribute
//{
//    public MyAttribute(int i)
//    {

//    }
//    public int MyProperty1 { get; set; }
//    public int MyProperty2 { get; set; }
//    public int MyProperty3 { get; set; }
//    public int f;
//    public void Method()
//    {

//    }
//}

//class my1 : Attribute
//{

//}
//class my2 : Attribute
//{

//}
//class my3 : Attribute
//{

//}

//[my1,my2,my3]//or [my1][my2][my3]
//public class MyClass
//{
//        [My(5)]
//        public MyClass()
//        {

//        }
//        [My(5)]
//        void Method()
//        {

//        }
//        [MyAttribute(5)]
//        public int MyProperty { get; set; }
//}
#endregion


using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyAttribute>() is not null).ToList();

foreach (var type in types)
{
    var attributes = type.GetCustomAttributes<MyAttribute>();
    foreach (var attribute in attributes)
    {
        Console.WriteLine($"{type.Name}---{attribute.MyProperty1}");
    }
}

[AttributeUsage(AttributeTargets.All)]
class MyAttribute : Attribute
{
    public int MyProperty1 { get; set; }
}

[My(MyProperty1 = i)]
class MyClass
{
    const int i = 23;
}

[My(MyProperty1 = 5)]
class MyClass1
{

}

[My(MyProperty1 = 23)]
class MyClass2
{

}


class MyClass3
{

}

