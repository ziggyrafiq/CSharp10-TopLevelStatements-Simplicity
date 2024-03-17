namespace CSharp10_TopLevelStatements_Simplicity;
public static class SimplifyingControlFlow
{
    public static void CodeExample()
    {
        // C# 9 top-level statement with control flow
        bool isEvening = DateTime.Now.Hour >= 18;

        if (isEvening)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Hello!");
        }

    }
}
