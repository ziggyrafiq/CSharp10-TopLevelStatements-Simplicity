namespace CSharp10_TopLevelStatements_Simplicity.ErrorHandling;
public static class Calculator
{
    // Function with error handling
    public static int DivideNumbers(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new ArgumentException("Cannot divide by zero.");
        }

        return dividend / divisor;
    }
}
