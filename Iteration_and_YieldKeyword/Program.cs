#region Make a Class Iterative, IEnumerable, IEnumerator

//using System.Collections;
//Store store = new Store();
//foreach (var item in store)
//{
//    Console.WriteLine(item);
//}
//class Store : IEnumerable<string>
//{
//    public List<string> items = new List<string>() { "pencil", "rubber", "eraser", "notebook" };

//    public IEnumerator<string> GetEnumerator()
//    {
//        //return items.GetEnumerator();
//        return new StoreEnumerator(items);
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        //return items.GetEnumerator();
//        return new StoreEnumerator(items);
//    }
//}
//class StoreEnumerator : IEnumerator<string>
//{
//     List<string> _source;

//    public StoreEnumerator(List<string> source) => _source = source;

//    int _currentIndex = -1;
//    public string Current => _source[_currentIndex];
//    object IEnumerator.Current => _source[_currentIndex];
//    public void Dispose() => _source= null;
//    public bool MoveNext() => ++_currentIndex < _source.Count;
//    public void Reset() => _currentIndex = -1;
//}

#endregion

#region Yield Keyword

using System.Collections;

var names = GetNames(); // It doesn't execute the method, Deferred Execution


foreach (var name in GetNames())
{
    Console.WriteLine(name);
}

//IEnumerable GetNames()
//{
//    //List<string> names = new() { "John", "Doe", "Jane", "Alperen", "gunes" };
//    //return names;
//    Console.WriteLine("process1");
//    yield return "John";
//    yield return "Doe";
//    Console.WriteLine("process2");
//    yield return "Jane";
//    yield return "Alperen";
//    yield return "gunes";
//    Console.WriteLine("process3");
//}
//// OR
IEnumerable GetNames()
{
    List<string> names = new() { "John", "Doe", "Jane", "Alperen", "gunes" };
    foreach (var name in names)
    {
        yield return name;
    }
}


#endregion