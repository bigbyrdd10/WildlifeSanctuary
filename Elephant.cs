public class Elephant : Mammal
{
    public Elephant(string name, int age)
        : base(name, age)
    {
    }

    public override string GetSound()
    {
        return "Trumpet";
    }

    public override string GetAnimalType()
    {
        return "Elephant";
    }

    public override string Describe()
    {
        return base.Describe() + ", Species: Elephant";
    }
}