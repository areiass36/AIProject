using Helpers;

namespace Models;

public class ShipList
{
    public IList<Ship> Value { get; init; }
    public int GeneralAwaitTime { get; private set; }
    public ShipList(IList<Ship> ships)
    {
        Value = ships;
    }

    public IEnumerable<ShipList> GetPermutation() => GetPermutationInternal(this, 0, Value.Count() - 1, new());
    private IEnumerable<ShipList> GetPermutationInternal(ShipList ships, int begin, int end, List<ShipList> list)
    {
        if (begin != end)
            for (int i = begin; i < ships.Value.Count(); i++)
            {
                ships.Value.Swap(begin, i);
                GetPermutationInternal(ships, begin + 1, end, list);
                ships.Value.Swap(begin, i);
            }
        else
        {
            var newItem = new ShipList(new List<Ship>(ships.Value));
            newItem.CalculateGeneralAwaitTime();
            list.Add(newItem);
        }
        return list;
    }

    private void CalculateGeneralAwaitTime()
    {
        for (int i = 1; i < Value.Count(); i++)
        {
            var prev = Value[i - 1];
            var curr = Value[i];
            curr.AwaitTime = prev.StayTime - curr.ArriveTime;
            curr.ArriveTime = prev.StayTime;
            curr.StayTime += curr.AwaitTime;

            this.GeneralAwaitTime += curr.AwaitTime;
        }
    }

    public override string ToString()
    {
        var result = "[\n";
        foreach (var e in Value)
        {
            result += e.ToString() + ",\n";
        }
        result += "]";
        return result;
    }

    public override bool Equals(object? obj)
    {
        if (obj is ShipList shipList)
            return Value.SequenceEqual(shipList.Value);
        return false;
    }

    public override int GetHashCode() => Value.GetHashCode();
}