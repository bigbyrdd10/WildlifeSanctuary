
# Wildlife Sanctuary
## Jackson Byrd
## CSCI 1260 -

### World Description
My world is a Wildlife Sanctuary Management System that tracks animals, health records, rescues, and ranger activity within a wildlife sanctuary.

### Programming Language
C# (.NET)

### How to Run the Program

1. Open the project folder in Visual Studio Code.
2. Open a terminal in the project directory.
3. Build the project:

```bash
dotnet build
```

4. Run the project:

```bash
dotnet run
```

### Design Answers

#### 1. Why did you choose your world?
I chose a wildlife sanctuary because it naturally supports different animal types and allowed me to demonstrate inheritance, abstraction, interfaces, aggregation, and composition using realistic relationships.

#### 2. How did inheritance improve your design?
Inheritance allowed me to place shared properties and behavior in the Animal class while allowing specialized classes such as Lion, Elephant, Dolphin, and Bird to provide their own unique behavior. This reduced duplicate code and improved maintainability.

#### 3. Why did you use interfaces?
I used the IRescuable interface because not every class should necessarily have rescue functionality. The interface allowed me to define rescue behavior separately from the inheritance hierarchy and apply it only where needed.

### Video Recording

Video Link:
PASTE YOUR VIDEO LINK HERE

### UML Diagram

Located in:
docs/uml.png

### Items Not Finished

- data.txt file loading is not currently locating the file correctly during execution.
  (Remove this item if you successfully fixed it.)

OR

- None. All project requirements were completed.

### Project Features

- Classes and Objects
- Inheritance
- Abstraction
- Polymorphism
- Interfaces
- Aggregation
- Composition
- Collections
- IComparable
- IComparer
- IEquatable
- Exception Handling
- File Processing
- IDisposable
- GitHub Actions Build Workflow
``
