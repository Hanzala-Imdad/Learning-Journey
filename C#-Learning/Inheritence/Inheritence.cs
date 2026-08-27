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

        DOG dogy = new DOG();
        dogy.NAME = "PUPPY";

        dogy.EAT();
        dogy.bark();

        cat m = new cat();
        m.NAME = "Catie";
        m.EAT();
        m.meaw();

        Teacher TEACH = new Teacher();
        TEACH.name = "Proff.Akeel";
        TEACH.Introducce();
        TEACH.teach();

        Studentt st = new Studentt();
        st.name = "Hanzala";
        st.Introducce();
        st.study();

        Puppy play=new Puppy();
        play.eat();
        play.bark();
        play.play();

        CAT meaw = new CAT();
        meaw.eat();
        meaw.meaw();

        
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

// Question 3 of Multilevel Inheritence "Student Chain"
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
           //-----------Hierarchical Inheritance------------//

//Question 1 of Hierarchical Inheritance "Animal"
class animal
{
    public string NAME ;
    public void EAT()
    {
        Console.WriteLine($"{NAME} is Eating");
    }
}
class DOG : animal
{
    public void bark()
    {
        Console.WriteLine($"Dog says woouf");
    }
}
class cat : animal
{
    public void meaw()
    {
        Console.WriteLine("Cat says meaw");
    }
}

//Question 2 of Hierarchical Inheritance "Person"
class Personn
{
    public string name;
    public void Introducce()
    {
        Console.WriteLine($"my name is {name}");
    }

}
class Studentt : Personn
{
    public void study()
    {
        Console.WriteLine("I,am doing studies");
    }
}
 class Teacher : Personn
{
    public void teach()
    {
        Console.WriteLine($"{name} teaching a lesson ");
    }
}
          //------------HYBRID INHERITENCE------------//
//Question 1 of Hybrid Inheritence "Animal Hybrid"
class ANIMAL
{
    public void eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class DOg :ANIMAL
{
    public void bark()
    {
        Console.WriteLine("Dog is barking");
    }
} 
class CAT : ANIMAL
{
    public void meaw()
    {
        Console.WriteLine("cat says meaw");
    }
}
class Puppy : DOg
{
    public void play()
    {
        Console.WriteLine("Puppy is playing");
    }
}