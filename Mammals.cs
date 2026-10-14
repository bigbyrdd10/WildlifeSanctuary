// Abstract middle class
public abstract class Mammal : Animal
{
    protected Mammal(string name, int age)
        : base(name, age)
    {
    }

    public override string Describe()
    {
        return base.Describe() + ", Category: Mammal";
    }
}