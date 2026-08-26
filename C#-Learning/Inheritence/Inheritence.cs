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

        Developer dev = new Developer();
        dev.Introduce();
        dev.work();
        dev.code();

        dog dd = new dog();
        dd.eat();
        dd.bark();
        dd.Walk();

        universityStuent US = new universityStuent();
        US.name = "Hanzala";
        US.university = "Preston";       
 
        US.Introducee();
        US.study();
        US.showuniversity();
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
             //-------MULTILEVEL INHERITENCE---------//

// Question 1 of Multilevel Inheritence

class person
{
    public void Introduce()
    {
        Console.WriteLine($"I'm a Person");
    }

}
class Employee : person
{
    public void work()
    {
        Console.WriteLine($"Employee is Working ");
    }
}
class Developer : Employee
{
    public void code()
    {
        Console.WriteLine("Developer is Coding");
    }
}
 
// Question 2 of Multilevel Inheritence "Animal Chain"
class Animall
{
    public void eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}
class Mammel : Animall
{
    public void Walk()
    {
        Console.WriteLine("Mammel is Walking");
    }
}
class dog : Mammel
{
    public void bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}
class personn
{
   public string name;
    public void Introducee()
    {
        Console.WriteLine($"I'm {name}");
    }
}
class student : personn
{
    public void study()
    {
        Console.WriteLine("student is studing");
    }
}
class universityStuent : student
{
    public string university;
   public void showuniversity()
    {
       Console.WriteLine($"Name of University is {university}");
    }
}