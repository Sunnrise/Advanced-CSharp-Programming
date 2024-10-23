int a = 1;
int b = 0;

//try
//{
//    Console.WriteLine(a / b);
//}

//catch (Exception ex)
//{

//}

try
{
    while (true)
    {
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.Z)
        {
            throw new CustomException("Dont type Z")
            {
                MyProperty = "My custom property"
            };
        }

        else
        {
            Console.WriteLine("You typed: " + key.KeyChar);
        }
    }
}
catch (CustomException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class CustomException : Exception
{
    public string MyProperty { get; set; }
    public CustomException(): base("Custom Exception")
    {

    }
    public CustomException(string message): base (message)
    {

    }


}