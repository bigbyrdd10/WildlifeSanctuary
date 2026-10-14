// Composition class
public class HealthRecord
{
    public string Note { get; }
    public DateTime Date { get; }

    public HealthRecord(string note)
    {
        Note = note;
        Date = DateTime.Now;
    }
}