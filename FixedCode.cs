public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Check for division by zero
        if (MyProperty != 0)
        {
            int result = 10 / MyProperty;
        }
        else
        {
            // Handle the case where MyProperty is zero
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}