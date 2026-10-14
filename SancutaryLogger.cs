using System.IO;

public class SanctuaryLogger : IDisposable
{
    private StreamWriter writer;
    private bool disposed;

    public SanctuaryLogger(string fileName)
    {
        writer = new StreamWriter(fileName);
    }

    public void Write(string message)
    {
        writer.WriteLine(message);
    }

    public void Dispose()
    {
        if (!disposed)
        {
            writer.WriteLine("Logger disposed.");
            writer.Close();
            disposed = true;
        }
    }
}