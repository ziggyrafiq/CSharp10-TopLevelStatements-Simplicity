namespace CSharp10_TopLevelStatements_Simplicity;
public static class ImprovedReadability
{
    public static void CodeExample() 
    {
        // No need for a Main method, improving readability

        ShowWelcomeMessage();

        int result = AddNumbers(10, 15);
        Console.WriteLine($"The result is: {result}");

        // Functions can be defined at the top level
        void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to C# 9 Top-Level Statements!");
        }

        int AddNumbers(int a, int b) => a + b;


    }
}
