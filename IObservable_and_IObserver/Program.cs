
#region IObservableSample

//MyObservable observable = new();

//using var sub1=observable.Subscribe(new MyObserver("A"));
//using var sub2=observable.Subscribe(new MyObserver("B"));
//using var sub3=observable.Subscribe(new MyObserver("C"));

//observable.NotifyObservers(1);
//observable.NotifyObservers(2);
//observable.NotifyObservers(3);
//observable.NotifyObservers(4);

//class MyObservable : IObservable<int>
//{
//    List<IObserver<int>> _observers = new();
//    public IDisposable Subscribe(IObserver<int> observer)
//    {
//        if (!_observers.Contains(observer))
//            _observers.Add(observer);
//        return new UnSubscription(() =>
//        { 
//            _observers.Remove(observer);
//            observer.OnCompleted();
//        });
//    }
//    public void NotifyObservers(int value) => _observers.ForEach(observer => observer.OnNext(value));
//}

//class UnSubscription(Action unSubscription) : IDisposable
//{
//    public void Dispose()
//    {
//        unSubscription?.Invoke();
//        unSubscription = null;
//    }
//}

//class MyObserver(string observerName) : IObserver<int>
//{
//    public void OnCompleted() => Console.WriteLine($"observer {observerName} Completed");
//    public void OnError(Exception error) => Console.WriteLine($"observer {observerName} Error: {error.Message}");
//    public void OnNext(int value) => Console.WriteLine($"observer {observerName} Value: {value}");
//}
#endregion 

#region ISubjectSample

using System.Reactive.Subjects;

ISubject<int> subject = new Subject<int>();
MyObserver observer1 = new("A");
MyObserver observer2 = new("B");
MyObserver observer3 = new("C");

var aSubscribe=subject.Subscribe(observer1);
var bSubscribe=subject.Subscribe(observer2);
var cSubscribe =subject.Subscribe(observer3);

subject.OnNext(1);
subject.OnNext(2);
subject.OnNext(3);

bSubscribe.Dispose();

subject.OnNext(1);
subject.OnNext(2);
subject.OnNext(3);


class MyObserver(string observerName) : IObserver<int>
{
    public void OnCompleted() => Console.WriteLine($"observer {observerName} Completed");
    public void OnError(Exception error) => Console.WriteLine($"observer {observerName} Error: {error.Message}");
    public void OnNext(int value) => Console.WriteLine($"observer {observerName} Value: {value}");
}
#endregion