

#region Entry

//IA.S3();

//A.S();
//A.S2();

//xx<A> x = new xx<A>();
//xx<Z> z = new xx<Z>();

//class xx<T> where T : IA
//{
//    public xx()
//    {
//        T.S();
//        T.S2();
//    }
//}

//interface IA
//{
//    static abstract void S();
//    abstract static void S2();

//    static void S3()
//    {
//        Console.WriteLine("default s3 method has been called");
//    }
//}

//class A : IA
//{
//    public static void S()
//    {
//        Console.WriteLine(" s method has been called");
//    }

//    public static void S2()
//    {
//        Console.WriteLine(" s2 method has been called");
//    }
//}

//class S : IA
//{
//    static void IA.S()
//    {
//        throw new NotImplementedException();
//    }

//    static void IA.S2()
//    {
//        throw new NotImplementedException();
//    }
//}

//class Z : IA
//{
//    public static void S()
//    {
//        Console.WriteLine(" s method has been called - Z");
//    }

//    public static void S2()
//    {
//        Console.WriteLine(" s2 method has been called - Z");
//    }
//}

#endregion

xx<X> x = new xx<X>();

interface IX
{
    int Value { get; }
    static abstract int operator +(IX x);
    static abstract int operator -(IX x);
    static abstract int operator +(IX x, IX x2);
    static abstract int operator -(IX x, IX x2);
    static abstract long operator *(IX x, IX x2);
    static abstract decimal operator /(IX x, IX x2);
    static abstract int operator +(IX x, A a);
    static abstract int operator *(IX x, B b);
}
class A
{
    public int a;

}
class B
{
    public int b;
}

class X : IX
{
    public int Value => 0;

    static int IX.operator +(IX x) => x.Value + 1;

    static int IX.operator +(IX x, IX x2) => x.Value + x2.Value;


    static int IX.operator +(IX x, A a) => x.Value + a.a;


    static int IX.operator -(IX x) => x.Value - 1;


    static int IX.operator -(IX x, IX x2) => x.Value - x2.Value;

    static long IX.operator *(IX x, IX x2) => x.Value * x2.Value;

    static int IX.operator *(IX x, B b) => x.Value * b.b;

    static decimal IX.operator /(IX x, IX x2) => x.Value / x2.Value;
}

class xx<T> where T : IX, new()
{
    public xx()
    {
        T t1 = new();
        T t2 = new();

        _ = t1 + t2;
        _ = t1;
        _ = t1 * new B();
    }
    
}