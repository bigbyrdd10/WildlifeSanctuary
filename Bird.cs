public class Bird : Animal, IRescuable
{
    public Bird(string name, int age)
        : base(name, age)
    {
    }

    public override string GetSound()
    {
        return "Chirp";
    }

    public override string GetAnimalType()
    {
        return "Bird";
    }

    public override string Describe()
    {
        return base.Describe() + ", Species: Bird";
    }

    public string Rescue()
    {
        return $"Bird {Name} rescued.";
    }
}
