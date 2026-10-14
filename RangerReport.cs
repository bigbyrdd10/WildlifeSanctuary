public class RangerReport :
    IEquatable<RangerReport>,
    IComparable<RangerReport>
{
    public string RangerId { get; }
    public DateTime Date { get; }
    public double DistanceTracked { get; }

    public RangerReport(
        string rangerId,
        DateTime date,
        double distanceTracked)
    {
        RangerId = rangerId;
        Date = date;
        DistanceTracked = distanceTracked;
    }

    public bool Equals(RangerReport? other)
    {
        if (other == null)
            return false;

        return RangerId == other.RangerId
            && Date == other.Date;
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as RangerReport);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(RangerId, Date);
    }

    public int CompareTo(RangerReport? other)
    {
        return DistanceTracked.CompareTo(other!.DistanceTracked);
    }

    public override string ToString()
    {
        return $"{RangerId} {Date.ToShortDateString()} {DistanceTracked}";
    }
}