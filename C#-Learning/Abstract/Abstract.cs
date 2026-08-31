// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======== Question:1 =========");
        Dog obj = new Dog();
        obj.Name = "Whisky";
        obj.eat();
        obj.makeSound();

        Console.WriteLine("\n======== Question:2 =========");
        Circle Obj = new Circle();
        Obj.Colour = "Red";
        Obj.Describe();
        Obj.getArea(4);
        Console.WriteLine(Obj.Area);
        
        Console.WriteLine("\n======== Question:3 =========");
        Employee e1 = new Developer();
        Employee e2 = new Designer();
        e1.Work();
        e2.Work();

        Console.WriteLine("\n======== Question:4 =========");
        Car car = new Car("Toyota");
        car.ShowBrand();
        car.Drive();

        Bike bike = new Bike("Honda");
        bike.ShowBrand();
        bike.Drive();
    }
}
           //===========Abstruct Classes============//
//Question 1 of Abstruct class
abstract class Animal
{
   public string Name {get; set;} = "";
   public void eat()
    {
        Console.WriteLine($"{Name} is eating");
    }
    public abstract void makeSound();
}
class Dog : Animal
{
    public Dog() { Name = ""; }
    public override void makeSound()
    {
        Console.WriteLine("Woof");
    }
}
//Question 2 of Abstruct class
abstract class Shape
{
    public string Colour {get; set;} = "";
     public double Area;
    public abstract double getArea(double radius);
    public void Describe()
    {
        Console.WriteLine($"A {Colour} shape with area {Area} ");
    }
}
class Circle : Shape
{
    public double radius;
   
    public override double getArea(double radius)
    {
        this.radius = radius;
        Area = Math.PI * radius * radius;
        Console.WriteLine($"The area of a circle with radius {this.radius} is {Area}");
        return Area;
    }
}
//Question 3 of Abstruct class
abstract class Employee
{
    public string name = "";
    public void logIn()
    {
        Console.WriteLine(name);
    }
    public abstract void Work();
}
class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer is writing code");
    }
}
class Designer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Designer is Making Designs");
    }
}
//Question 4 of Abstruct class
abstract class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void ShowBrand()
    {
        Console.WriteLine(Brand);
    }

    public abstract void Drive();
}

class Car : Vehicle
{
    public Car(string brand) : base(brand)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}

class Bike : Vehicle
{
    public Bike(string brand) : base(brand)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Bike is driving");
    }
}