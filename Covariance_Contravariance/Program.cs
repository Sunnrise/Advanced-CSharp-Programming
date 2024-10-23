#region Entry


//// polymorphism
//A a= new Z();

////covariance
//object[] names= new string[3] {"Alperen", "Gunes", "Software" };

//// covariance
//A[] aArrays = new Z[3];

//// covariance
//IEnumerable<object> cars = new List<string>() { "Opel", "Togg", "Tofaş" };

//// covariance
//IEnumerable<A> asd = new List<Z>() { new(), new()};

//// covariance
//Func<A> funcA = GetZ;

//Z GetZ() => new();

//// contravariance
//Action<string> xDelegate = xMethod;

//void xMethod(object x) { }

//// contravariance

//Action<Z> zDelegate = AMethod;

//void AMethod(A a) { }



#endregion

#region Covariance

#region Array Types
//object[] x = new string[3] { "Alperen", "Gunes", "Software" };
////x[0]= 123; // Error It can be assigned but when the program runs it will throw an exception
#endregion

#region Delegate Types

#endregion

#region Return Types

#endregion

#region Generic Types

//IAnimal<object> animal = new Animal<string>();

//IAnimal<A> aAnimal = new Animal<Z>();

//interface IAnimal<out T> { }
//class Animal<T> : IAnimal<T> { }
#endregion

#endregion

#region Contravariance
#region Delegate Types
//Action<A> aDelegate = aDelegate => { };
//Action<Z> zDelegate = aDelegate;
#endregion

#region Generic Types
IAnimal<string> animal = new Animal<object>();

IAnimal<Z> aAnimal = new Animal<A>();
IAnimal<Z> ZAnimal = new Animal<Z>();
IAnimal<Z> oAnimal = new Animal<object>();


interface IAnimal<in T> { }
class Animal<T> : IAnimal<T> { }
#endregion

#endregion
class A
{
    public virtual A X() => new();
}

class Z : A 
{
    public override A X()=> new();
}