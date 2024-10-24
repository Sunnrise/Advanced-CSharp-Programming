using System.Runtime.InteropServices;
using System.Security;



#region Secure String Usage

string debitCardNumber = "1234 5678 9012 3456";
SecureString secureString= new();

debitCardNumber.ToList().ForEach(c => secureString.AppendChar(c));
secureString.MakeReadOnly();


#endregion

#region Access to data
#region 1. Method

//IntPtr bstr = Marshal.SecureStringToBSTR(secureString);

//var value = Marshal.PtrToStringUni(bstr);
//Console.WriteLine(value);

#endregion

#region 2. Method

//IntPtr bstr = Marshal.SecureStringToBSTR(secureString);

//var value = Marshal.PtrToStringBSTR(bstr);
//Console.WriteLine(value);

#endregion

#region 3. Method

var bstr = Marshal.SecureStringToBSTR(secureString);

char[] chars = new char[secureString.Length];
Marshal.Copy(bstr, chars, 0, secureString.Length);
var value = string.Join("", chars);
Marshal.ZeroFreeBSTR(bstr);
Console.WriteLine(value);



#endregion
#endregion