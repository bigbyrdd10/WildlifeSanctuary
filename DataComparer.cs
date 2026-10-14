public class DateComparer : IComparer<RangerReport>
{
    public int Compare(
        RangerReport? x,
        RangerReport? y)
    {
        return x!.Date.CompareTo(y!.Date);
    }
}