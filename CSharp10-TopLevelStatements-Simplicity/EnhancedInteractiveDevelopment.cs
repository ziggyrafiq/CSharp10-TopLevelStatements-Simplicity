namespace CSharp10_TopLevelStatements_Simplicity;
public static class EnhancedInteractiveDevelopment
{
    public static void ExampleCode() 
    {
        // Enhanced interactive development with top-level statements
        Console.WriteLine("Interactive C# 9 development!");

        var number = 42;

        // We can experiment with code snippets directly
        var squared = Square(number);
        Console.WriteLine($"The square of {number} is: {squared}");

        // Functions can be defined and tested interactively
        int Square(int x) => x * x;

    }
}
