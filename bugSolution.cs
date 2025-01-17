public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize MyProperty with a default value

    public void MyMethod() {
        // Now MyProperty has a default value before being used.
        Console.WriteLine(MyProperty); // This will print 0
        MyProperty = 10;
    }
}