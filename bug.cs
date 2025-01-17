public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); // This might print 0, or throw an exception depending on the context.
        MyProperty = 10;
    }
}