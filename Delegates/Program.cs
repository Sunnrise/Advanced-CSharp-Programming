XHandler xdelegate= new XHandler(X);
XHandler xdelegate2 = X;
XHandler xdelegate3 = () => { };
XHandler xdelegate4 = delegate (){ };

xdelegate();
xdelegate.Invoke();

YHandler ydelegate = new YHandler(Y);
YHandler ydelegate2 = Y;
YHandler ydelegate3 = (A a, (string, int) p) => (1, 'a');
//YHandler ydelegate3=(a,p)=>
//{
//    return (1, 'a');
//};
YHandler ydelegate4 = delegate (A a, (string, int) p) 
{ 
    return (1, 'a'); 
};

(int, char) r = ydelegate4(new(), ("alperen", 24));
var r2 = ydelegate4.Invoke(new(), ("alperen", 24));

void X()
{
    Console.WriteLine("X-method");
}

(int,char)Y(A a, (string, int) p)
{
    return (1, 'a');
}

public delegate void XHandler();

public delegate (int, char) YHandler(A a,(string,int)p);

public class A
{
   
}
