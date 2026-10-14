// Aggregation class
public class SanctuaryManager
{
    private readonly List<Animal> animals = new();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public List<Animal> GetAnimals()
    {
        return animals;
    }
}