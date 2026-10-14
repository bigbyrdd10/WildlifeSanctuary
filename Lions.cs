public class Lion : Mammal, IRescuable
{
    public Lion(string name, int age)
        : base(name, age)
    {
    }

    public override string GetSound()
    {
        return "Roar";
    }

    public override string GetAnimalType()
    {
        return "Lion";
    }

    public override string Describe()
    {
        return base.Describe() + ", Species: Lion";
    }

    public string Rescue()
    {
        return $"Lion {Name} rescued.";
    }
}