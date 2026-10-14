using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== 1. Classes, UML, and Relationships ===");

        SanctuaryManager manager = new SanctuaryManager();

        Animal simba = new Lion("Simba", 5);
        simba.AddHealthRecord("Annual checkup passed");

        Animal dumbo = new Elephant("Dumbo", 10);

        manager.AddAnimal(simba);
        manager.AddAnimal(dumbo);

        foreach (Animal animal in manager.GetAnimals())
        {
            Console.WriteLine(animal.DisplayInfo());
        }

        Console.WriteLine("\n=== 2. Inheritance and Abstraction ===");

        List<Animal> animals = new List<Animal>()
        {
            new Lion("Leo", 4),
            new Elephant("Ella", 12),
            new Dolphin("Splash", 6),
            new Bird("Sunny", 2)
        };

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.DisplayInfo());
        }

        Console.WriteLine("\n=== 3. Polymorphism and Interfaces ===");

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.DisplayInfo());
        }

        RescueAnimal(new Lion("King", 7));
        RescueAnimal(new Bird("Blue", 1));

        Console.WriteLine("\n=== 4. Built-in Contracts and Collections ===");

        HashSet<RangerReport> reportSet = new HashSet<RangerReport>();

        RangerReport report1 =
            new RangerReport("R1",
            new DateTime(2026, 1, 1), 50);

        RangerReport duplicateReport =
            new RangerReport("R1",
            new DateTime(2026, 1, 1), 99);

        Console.WriteLine("HashSet count before duplicate:");
        reportSet.Add(report1);
        Console.WriteLine(reportSet.Count);

        reportSet.Add(duplicateReport);

        Console.WriteLine("HashSet count after duplicate:");
        Console.WriteLine(reportSet.Count);

        List<RangerReport> reports = new List<RangerReport>()
        {
            new RangerReport("R3",
                new DateTime(2026,5,1),30),

            new RangerReport("R1",
                new DateTime(2026,1,1),90),

            new RangerReport("R2",
                new DateTime(2026,3,1),60)
        };

        Console.WriteLine("\nNatural Sort (IComparable)");
        reports.Sort();

        foreach (RangerReport report in reports)
        {
            Console.WriteLine(report);
        }

        Console.WriteLine("\nDate Sort (IComparer)");
        reports.Sort(new DateComparer());

        foreach (RangerReport report in reports)
        {
            Console.WriteLine(report);
        }

        Console.WriteLine("\nDistance Sort (IComparer)");
        reports.Sort(new DistanceComparer());

        foreach (RangerReport report in reports)
        {
            Console.WriteLine(report);
        }

        Console.WriteLine("\n=== 5. Exceptions and Files ===");

        LoadDataFile();

        try
        {
            using (SanctuaryLogger logger =
                new SanctuaryLogger("log.txt"))
            {
                logger.Write("Program Started");
                logger.Write("Testing IDisposable");

                throw new InvalidOperationException(
                    "Intentional exception for project requirement.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught exception: "
                + ex.Message);
        }

        Console.WriteLine("\nLog File Contents:");

        if (File.Exists("log.txt"))
        {
            Console.WriteLine(File.ReadAllText("log.txt"));
        }

        Console.WriteLine("\nProgram completed successfully.");
    }

    public static void RescueAnimal(IRescuable animal)
    {
        Console.WriteLine(animal.Rescue());
    }

    public static void LoadDataFile()
    {
        string filePath =
            Path.Combine(AppContext.BaseDirectory, "data.txt");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("data.txt not found.");
            return;
        }

        foreach (string line in File.ReadAllLines(filePath))
        {
            try
            {
                string[] parts = line.Split(',');

                if (parts.Length != 3)
                {
                    throw new FormatException(
                        "Incorrect number of fields.");
                }

                string type = parts[0];
                string name = parts[1];
                int age = int.Parse(parts[2]);

                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException(
                        "Animal name is missing.");
                }

                Console.WriteLine(
                    $"Loaded {type}: {name}, Age {age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid line: {line}");
                Console.WriteLine($"Reason: {ex.Message}");
            }
        }
    }
}