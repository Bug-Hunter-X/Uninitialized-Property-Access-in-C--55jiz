public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Or another default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it will print a consistent value.
    }
} 

//Alternative solution to explicitly initialize the property
public class ExampleClass2
{
    public int MyProperty { get; set; } = 10;

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it will print 10
    }
}