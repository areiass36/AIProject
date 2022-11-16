namespace Models;
public struct Ship
{
    public int Key { get; set; }
    public int Size { get; set; }
    public int ArriveTime { get; set; }
    public int StayTime { get; set; }
    public int AwaitTime { get; set; }

    public override string ToString()
    {
        return Key.ToString();
    }

    public override bool Equals(object? obj)
    {
        if (obj is Ship ship)
            return Key == ship.Key;
        return false;
    }

    public override int GetHashCode() => Key.GetHashCode();
}