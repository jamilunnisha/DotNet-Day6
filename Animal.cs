public class Animal
{
    // Encapsulation
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Constructor
    public Animal(string name)
    {
        Name = name;
    }

    // Virtual method for polymorphism
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}