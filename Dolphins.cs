public class Dolphin : Mammal
{
    public Dolphin(string name, int age)
        : base(name, age)
    {
    }

    public override string GetSound()
    {
        return "Click";
    }

    public override string GetAnimalType()
    {
        return "Dolphin";
    }

    public override string Describe()
    {
        return base.Describe() + ", Species: Dolphin";
    }
}