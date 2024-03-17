namespace CSharp10_TopLevelStatements_Simplicity;
public static class Conciseness
{
    public static void ExampleCode() 
    {
        // No explicit Main method or method definitions required

        Console.WriteLine("C# 9 brings conciseness with top-level statements!");

        int result = AddNumbers(8, 12);
        Console.WriteLine($"The sum is: {result}");

        // Function definition is concise at the top level
        int AddNumbers(int a, int b) => a + b;

    }
}
