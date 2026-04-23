 public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    // Runtime polymorphism
    public override void Eat()
    {
        Console.WriteLine($"{Name} the dog is eating");
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}