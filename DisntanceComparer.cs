public class DistanceComparer : IComparer<RangerReport>
{
    public int Compare(
        RangerReport? x,
        RangerReport? y)
    {
        return y!.DistanceTracked.CompareTo(x!.DistanceTracked);
    }
}