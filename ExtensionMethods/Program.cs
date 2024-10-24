EventArgs e = new();

e.X();

MyClass c = new();
c.Y();
class MyClass
{

}


static class ExtensionMethods
{
    public static void X(this EventArgs i)
    {
        Console.WriteLine("ExtensionMethod X");
        
    }
    public static void Y(this MyClass i)
    {
        Console.WriteLine("ExtensionMethod Y");
        
    }
}