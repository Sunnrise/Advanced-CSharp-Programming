using System.Reflection;
using System.Reflection.Emit;

////Assembly assembly = Assembly.Load("Reflections");
//////or
//Assembly assembly = Assembly.GetExecutingAssembly();

//var types = assembly.GetTypes();

//Assembly classLibraryAssembly = Assembly.Load("ReflectionsClassLibrary");

//var types2 = classLibraryAssembly.GetTypes();

//Console.WriteLine();

//MyClass m = new();
//Type type = m.GetType();

//Type type1 = typeof(MyClass);

//var assembly = Assembly.GetExecutingAssembly();
//var type2 = assembly.GetType(nameof(MyClass));

//Console.WriteLine();

//Type types = typeof(MyClass);

//var methods = types.GetMethods();

//var properties = types.GetProperties();
#region Reflection
#region Read property value and set value

//MyClass m = new();
//Type type = m.GetType();
//PropertyInfo propertyInfo = type.GetProperty(nameof(MyClass.MyProperty1));

//propertyInfo.SetValue(m, 23);
//Console.WriteLine(propertyInfo.GetValue(m));

#endregion
#region Invoke Method
//MyClass m = new();
//Type type = m.GetType();

//MethodInfo methodInfo = type.GetMethod(nameof(MyClass.Z));

//methodInfo.Invoke(m, new object[] { 23, 24, "Alperen" });

////methodInfo.Invoke(m, null);
#endregion
#endregion
#region Dynamic Method

//DynamicMethod dynamicMethod = new(

//    name: "Addition",
//    returnType: typeof(int),
//    parameterTypes: new Type[] { typeof(int), typeof(int) },
//    m: typeof(MyClass).Module
//    );
//ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
//iLGenerator.Emit(OpCodes.Ldarg_0);
//iLGenerator.Emit(OpCodes.Ldarg_1);
//iLGenerator.Emit(OpCodes.Add);
//iLGenerator.Emit(OpCodes.Ret);

//Func<int, int, int> additionDelegate = (Func<int, int, int>)dynamicMethod.CreateDelegate(typeof(Func<int, int, int>));

//var r1 =additionDelegate(23, 24);
//var r2 =additionDelegate.Invoke(23, 24);

//Console.WriteLine(r1);
//Console.WriteLine(r2);

#endregion

#region NonPublic member getting

var type = typeof(MyClass);

var property = type.GetProperty("MyProperty3", BindingFlags.NonPublic | BindingFlags.Instance);

var method= type.GetMethod("Y", BindingFlags.NonPublic | BindingFlags.Instance);

method.Invoke(new MyClass(), null);

property.GetValue(new MyClass());

Console.WriteLine(property.GetValue(new MyClass()));

#endregion

class MyClass
{
    private int x;
    private int y;
    public int z;
    public void X()
        => Console.WriteLine("X method");
     void Y()
        => Console.WriteLine("Y method");
    public void Z(int a, int b, string c)
    => Console.WriteLine("z method"+a+b+c);
    public int MyProperty1 { get; set; }
    public int MyProperty2 { get; set; }
    int MyProperty3 { get; set; } = 50;

}