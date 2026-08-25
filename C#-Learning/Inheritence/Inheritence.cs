// See https://aka.ms/new-console-template for more information
using System;

//Question 1 of single-Inheritence
class Person
{
    protected string Name;

    public Person(string name)
    {
        Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {Name}");
    }
}

class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public void Study()
    {
        Console.WriteLine("Student is studying");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Hanzala");
        s.Introduce();
        s.Study();

        Car c = new Car();
        c.Drive();

        Dog d = new Dog();
        d.Eat();   // Parent Animal se inherited
        d.Bark();  // Dog ka apna method
    }
}

//Question 2 of single-Inheritence
class Vehicle
{
    protected string Brand = "Honda";

    public void Start()
    {
        Console.WriteLine("Vehicle starts");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Start(); // Parent se inherited method
        Console.WriteLine(Brand); // Parent se inherited field
        Console.WriteLine("Car is driving");
    }
}

// Question 3 of Single Inheritance

class Animal
{
    protected string Name = "Rex";

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} says Woof!");
    }
}