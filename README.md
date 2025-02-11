*What is Exception Handling?*
Exception handling is a programming construct that allows developers to manage errors or exceptional conditions that may occur during the execution of a program. It provides a way to respond to unexpected situations without crashing the application, enabling smoother user experiences and more robust software.

*Key Concepts of Exception Handling*
1-Exceptions:
An exception is an event that disrupts the normal flow of a program's execution. It can occur due to various reasons, such as invalid user input, file not found, network issues, or division by zero.
2-Try-Catch Block:
The most common mechanism for handling exceptions is the try-catch block.
Try: Code that might throw an exception is placed inside the try block.
Catch: If an exception occurs, control is passed to the catch block, where you can define how to handle the error
ex:
try
{
    // Code that may cause an exception
    int result = 10 / 0; // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    // Handle the exception
    Console.WriteLine("Cannot divide by zero: " + ex.Message);
}
3-Finally Block:
The finally block can be added after the try-catch blocks. Code inside the finally block will execute regardless of whether an exception was thrown or caught. This is useful for cleaning up resources, such as closing files or database connections.
ex:
finally
{
    // Cleanup code
    Console.WriteLine("This will always execute.");
}
4-Throwing Exceptions:
You can also throw exceptions intentionally using the throw keyword. This is useful for signaling error conditions in your code.
ex:
if (value < 0)
{
    throw new ArgumentOutOfRangeException("Value cannot be negative.");
}
5-Custom Exceptions:
Developers can define their own exception classes by inheriting from the base Exception class. This allows for more specific error handling tailored to the application’s needs.
ex:
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

*Importance of Exception Handling*
Improves Reliability:
Exception handling allows programs to recover from unexpected errors gracefully, making them more reliable.
Enhances User Experience:
Instead of abrupt crashes, users can receive informative messages, guiding them on how to proceed.
Encourages Clean Code:
By separating error handling from regular code, developers can write cleaner and more maintainable code.
Resource Management:
Proper exception handling ensures that resources (like files, network connections, etc.) are released appropriately, avoiding resource leaks.
