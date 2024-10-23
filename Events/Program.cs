string path= @"C:\Users\alper\Desktop\ıvır zıvır";
PathControl pathControl = new();
pathControl.PathControlEvent += (sizeMB) => Console.WriteLine($"Path has been exceeded 50MB Last Size->{sizeMB}");
await pathControl.Control(path);

class PathControl
{
    public delegate void PathHandler(float sizeMB);
    public event PathHandler PathControlEvent;

    public async Task Control(string path)
    {
        while (true)
        {
            await Task.Delay(1000);
            DirectoryInfo directoryInfo = new(path);
            var files = directoryInfo.GetFiles();
            float size= await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
            float sizeMB = (size / 1024) / 1024;
            if (sizeMB > 100)
            {
                PathControlEvent?.Invoke(sizeMB);
            }
        }
    }
}

//MyEventPublisher p = new();
//MyEventPublisher.XHandler xdelegate= new MyEventPublisher.XHandler(X);
//p.MyEvent += X;

//p.RaiseEvent();
//p.MyEvent -= X;
//void X()
//{
//    Console.WriteLine("Event has been triggered");
//}
//class MyEventPublisher
//{
//    public delegate void XHandler();
//    XHandler xdelegate;

//    public event XHandler MyEvent
//    {
//        add
//        {
//            Console.WriteLine("Event has been added");
//            xdelegate += value;
//        }
//        remove
//        {
//            Console.WriteLine("Event has been removed");
//            xdelegate -= value;
//        }
//    }

//    public void RaiseEvent()
//    {
//        //MyEvent?.Invoke();
//        xdelegate?.Invoke();
//    }
//}