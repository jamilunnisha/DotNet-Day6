public class Animal
{
    private string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}