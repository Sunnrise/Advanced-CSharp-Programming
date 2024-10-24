//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<string> collection= new() { string.Empty, "John", "Doe", "Jane", "Alperen", "gunes" };// Collection Initializer
//collection.Add("John");
//collection.Add("Doe");
//collection.Add("Jane");
//collection.Add("Alperen");
//collection.Add("gunes");

using System.Collections;

//MyClass m = new() {1,3,5,7 };
MyClass m = new()
{
    1,3,5,7,
    {3,"alperen"},
    {5,"gunes"},
    {7,"gunes"},
    ("alperen", 'a', 3)
};

class MyClass : IEnumerable<int>
{
    List<int> numbers = new();
    public int prop1 { get; set; }
    public int prop2 { get; set; }

    //public void Add(int i)
    //{
    //    numbers.Add(i);
    //}
    public void Add(int i, string a)
    {
        numbers.Add(i);
    }
    public void Add(int i)
    {
        numbers.Add(i);
    }
    public void Add((string s, char c, int i)a)
    {
        numbers.Add(a.i);
    }

    public IEnumerator<int> GetEnumerator()
        => numbers.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
        => numbers.GetEnumerator();
}