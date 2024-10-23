#region Action
Action action1 = () => Console.WriteLine("AlperenGunes");

Action<bool> action2 = (b) => Console.WriteLine("Action<T>");

Action<bool, int, int> action3 = (b, i1, i2) => Console.WriteLine("Action<T>");
#endregion

#region Func
// return type is int and no parameter
Func<int> func1 = () => 5;

// return type is bool and params are int, char
Func<int, char, bool> func2 = (i, c) => i == 5 && c == 'A';

// return type is (int, char) tuple and params are byte, int, string
Func<byte, int, string, (int, char)> func3 = (b, i, s) => (i, s[0]);
#endregion

#region Predicate
Predicate<bool> predicate1 = (b) => b;

Predicate<int> predicate2 = (i) => i == 5;
#endregion

#region Lambda Discard Parameters

Func<int, int, string, char> func = (_, _, s) => 'Z';

#endregion