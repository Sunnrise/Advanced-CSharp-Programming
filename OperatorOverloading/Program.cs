
//Console.WriteLine("Hello, World!");

//Student student = new Student()
//{
//    Name= "Alperen"
//};
//Book book = new Book()
//{
//    Name = "C# Programming",
//    Author = "GencayHoca"
//};
////student.Books.Add(book);
//var result = student + book;

////Server.Download(3);
////Server.Upload(3);
//Server server = new();
//if (server >>3)
//{
//    Console.WriteLine("Upload is successful");
//}
//if (server << 3)
//{
//    Console.WriteLine("Download is successful");
//}

//MyClass my = new();
//my++;
//Console.WriteLine(my.Count);


Database db = new();
bool connectionState= db + DatabaseType.SqlServer;
Console.WriteLine(connectionState);

class Server
{
    public static void Download(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"Downloading {i + 1}. file");
        }
    }
    public static void Upload(int fileCount)
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"Uploading {i + 1}. file");
        }
    }
    public static bool operator >>(Server server, int fileCount)
    {
        Upload(fileCount);
        return true;
    }
    public static bool operator <<(Server server, int fileCount)
    {
        Download(fileCount);
        return true;
    }


}

public class Student
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}


public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }

    public static Student operator +(Student s, Book b)
    {
        s.Books.Add(b);
        return s;
    }
}
public class MyClass
{
    public int Count { get; set; }
    public static int operator +(Book b, MyClass mc)
    {
        return 3;
    }
    public static int operator <(Book b, MyClass mc)
    {
        return 1;
    }
    public static int operator >(Book b, MyClass mc)
    {
        return 2;
    }
    //++ operator should be take one parameter and it should be same type as its class and it should return same type as its class
    public static MyClass operator ++(MyClass mc)
    {
        mc.Count++;
        return mc;
    }
    public static MyClass operator --(MyClass mc)
    {
        mc.Count--;
        return mc;
    }

    //true and false operator overloading, should be take one parameter and should return bool
    public static bool operator true(MyClass mc)
    {

        return true;
    }
    public static bool operator false(MyClass mc)
    {
        return false;
    }
}

class Database
{
    static string _connectionString;
    public static bool operator +(Database db, DatabaseType dbType)
    {
        _connectionString = dbType switch
        {
            DatabaseType.SqlServer => "Server=.;Database=Northwind;Integrated Security=true",
            DatabaseType.Oracle => "Server=.;Database=Northwind;Integrated Security=true",
            DatabaseType.MySql => "Server=.;Database=Northwind;Integrated Security=true",
        };
        OpenConnection(_connectionString);
        return true;
    }

    static bool OpenConnection(string connectionString)
    {
        Console.WriteLine("Connection is opened");
        return true;
    }

}
enum DatabaseType
{
    SqlServer,
    Oracle,
    MySql
}