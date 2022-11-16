namespace Helpers;

public static class Int32Extensions
{
    public static int Factorial(this Int32 a)
    {
        if (a <= 1)
            return 1;
        return a * Factorial(a - 1);
    }
}