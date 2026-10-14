// Abstract root class
public abstract class Animal
{
    private readonly List<HealthRecord> healthRecords = new();

    public string Name { get; }
    public int Age { get; }

    protected Animal(string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        if (age < 0)
            throw new ArgumentException("Age cannot be negative.");

        Name = name;
        Age = age;
    }

    public void AddHealthRecord(string note)
    {
        healthRecords.Add(new HealthRecord(note));
    }

    public abstract string GetSound();
    public abstract string GetAnimalType();

    public virtual string Describe()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public string DisplayInfo()
    {
        return Describe() + $" Sound: {GetSound()}";
    }
}
