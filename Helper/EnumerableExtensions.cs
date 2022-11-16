namespace Helpers;

public static class EnumerableExtensions
{
    public static void Swap<T>(this IList<T> e, int a, int b)
    {
        var temp = e[a];
        e[a] = e[b];
        e[b] = temp;
    }
}