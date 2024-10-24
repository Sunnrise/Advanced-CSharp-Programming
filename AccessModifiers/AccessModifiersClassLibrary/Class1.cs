namespace AccessModifiersClassLibrary
{
    public class Class1
    {
        public void X() 
        {
            Y(); // We can call Y() from X() because they are in the same class
        }
        void Y() 
        {
            Z(); // We can call Z() from Y() because they are in the same class
        } // Y() is private by default

        protected void Z() { } // Z() is protected

        internal void W() { } // W() is internal
        protected internal void V() { } // V() is protected internal
        private protected void U() { } // U() is private protected
    }
    class Class2 : Class1
    {
        public Class2()
        {
            Class1 c1 = new();
            c1.Z(); // Error: 'Class1.Z()' is inaccessible due to its protection level(protected)
            Z(); // We can call Z() from Class2 because Class2 is a subclass of Class1
            c1.W(); // We can call W() from Class2 because W() is internal
            c1.V(); // We can call V() from Class2 because V() is protected internal
            c1.U(); // Error: 'Class1.U()' is inaccessible due to its protection level(private 'protected')
            U(); // We can call U() from Class2 because Class2 is a subclass of Class1 (U() is private 'protected')
        }
    }
}
