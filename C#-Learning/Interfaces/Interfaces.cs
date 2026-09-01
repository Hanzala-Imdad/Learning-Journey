
// See https://aka.ms/new-console-template for more information

public class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========= Question:1 =========");
        IAnimal dog = new Dog();
        dog.makeSound();

        Console.WriteLine("\n========= Question:2 =========");
        IEmployee developer = new Developer();
        developer.Name = "Alice";
        developer.Work();

        Console.WriteLine("\n========= Question:3 =========");
        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();
        duck.Launch(duck);

    }
}
//Question:1 of Interface 
interface IAnimal
{
    void makeSound();

}
class Dog : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("Woof");
    }
}
//Question:2 of Interface
interface IEmployee
{
    string Name { get; set; }
    void Work();

}
class Developer : IEmployee
{
    public string Name { get; set; }
    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}
//Question:3 of Interface
interface IFlyable
{
    void Fly();
}
interface ISwimmable
{
    void Swim();
}
class Duck : IFlyable, ISwimmable
{
    public void Launch(IFlyable flyer)
    {
        flyer.Fly();
    }
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }
    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}
