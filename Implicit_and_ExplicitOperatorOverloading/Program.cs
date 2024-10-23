Console.WriteLine();
A a1 = new B(); // Implicit conversion
A a2 = (A)new B(); // Explicit conversion

// Implicit conversion
B b = (B)new A();
class A 
{
    public static explicit operator B(A i)
    {
        return new B();
    }

}
class B
{
    public static implicit operator A(B i)
    {
        return new A() { };
    }
}