public static class Generator
{
    private static Random random = new();
    public static int GetMinute() => random.Next(0, 1441);
    //2, 4
    public static int GetShipSize() => (random.Next(2) + 1) * 2;//(int)Math.Pow(2, random.Next(3));
}