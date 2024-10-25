namespace StaticAnonymousMethods
{
    internal class Program
    {
        delegate void XHandler();
        static void Main(string[] args)
        {
            const int a = 5;
            XHandler xHandler = static () =>
            {
                Console.WriteLine(a);
            };
            xHandler();


        }
    }
}
