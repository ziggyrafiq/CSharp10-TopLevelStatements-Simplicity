namespace CSharp10_TopLevelStatements_Simplicity;
public static class UnderstandingTopLevelStatements
{
    public static void SimpleExample()
    {
        // No need for a Main method
        // We can write executable code at the top level
        Console.WriteLine("Welcome to C# 9 Top-Level Statements!");

        int sum = AddNumbers(5, 7);
        Console.WriteLine($"The sum of 5 and 7 is: {sum}");

        // Define functions at the top level
        int AddNumbers(int a, int b) => a + b;

    }
}
