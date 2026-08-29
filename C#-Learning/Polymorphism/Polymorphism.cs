//See https://aka.ms/new-console-template for more information

// =========================================//
//------Method Overloading (Compile-time Polymorphism)------//

//Question No: 1 of Compile-time Polymorphism
class Calculator
{
    public void add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }

    public void add(double a, double b)
    {
        Console.WriteLine(a + b);
    }
}
class Preogram
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nMethod Overloading (Compile-time Polymorphism)");
        Console.WriteLine("==========Question-1 ===========");
        Calculator obj = new Calculator();
        obj.add(2, 3);
        obj.add(2, 3, 4);
        obj.add(2.5, 2.5);

        Console.WriteLine("\n==========Question-2 ==========");
        Printer Obj = new Printer();
        Obj.print("Hanzala");
        Obj.print(22);
        Obj.print("Hanzala", 22);

        Console.WriteLine("\n==========Question-3 ==========");
        Calculate OBJ = new Calculate();
        Console.WriteLine(OBJ.square(4));
        Console.WriteLine(OBJ.add(4));
        Console.WriteLine(OBJ.multiply(4, 2));
        
        Console.WriteLine("\nOperator Overloading (Compile-Time Polimorphism)");
        Console.WriteLine("==========Question-1 ==========");
        Book b1 = new Book(100);
        Book b2 = new Book(200);

        Book total = b1 + b2;

        Console.WriteLine(total.Pages);

        Console.WriteLine("\n==========Question-2 ==========");
        Money m1 = new Money(100);
        Money m2 = new Money(300);

        Money Total = m1 + m2;

        Console.WriteLine(Total.Cash);

        Console.WriteLine("\n==========Question-3 ===========");
        Temperature t1 = new Temperature(30);
        Temperature t2 = new Temperature(10);

        Temperature Diff = t1 - t2;

        Console.WriteLine(Diff.Temp);
        
        Console.WriteLine("\nPolymorphism Override (Run-Time Polimorphism)");
        Console.WriteLine("==========Question-1 ===========");
        Animal animal = new Dog();
        animal.makeSound();

        Console.WriteLine("\n==========Question-2 ===========");
        Vehicle vehicle = new Car();
        vehicle.Start();

        Console.WriteLine("\n==========Question-3 ===========");
        Employee e1 = new Developer();
        Employee e2 = new Designer();

        e1.Work();
        e2.Work();

        Console.WriteLine("\n==========Question-4 ===========");
        Student s1 = new Student();
        s1.showInfo();
        


    }
}
// Question No: 2 of Compile-time Polymorphism
class Printer
{
    public void print(string s)
    {
        Console.WriteLine(s);
    }

    public void print(int p)
    {
        Console.WriteLine(p);
    }

    public void print(string s, int p)
    {
        Console.WriteLine($"{s} {p}");
    }
}

// Question No: 3 of Compile-time Polymorphism

class Calculate
{
    public int square(int d)
    {
        return d * d;
        
    }

    public int add(int d)
    {
        return d + d;
        
    }
    public int multiply(int d, int m)
    {
        return d * m;
        
    }
}
//------Operator Overloading (Compile-Time Polimorphism------//)
// Question 1 of Compile Time Polymorphism "Operator Overloading"
class Book
{
    public int Pages {get; set;}
    public Book (int pages)
    {
        Pages = pages;
    }
    public static Book operator +(Book a, Book b)
    {
        return new Book(a.Pages + b.Pages);
    }
}
// Question 2 of Compile Time Polymorphism "Operator Overloading"
class Money
{
    public int Cash {get; set;}
    public Money (int cash)
    {
        Cash = cash;
    }
    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Cash + b.Cash);
    }
}
// Question 3 of Compile Time Polymorphism "Operator Overloading"
class Temperature
{
    public int Temp {get; set;}
    public Temperature(int temp)
    {
        Temp = temp;
    }
    public static Temperature operator -(Temperature a, Temperature b)
    {
        return new Temperature(a.Temp - b.Temp);
    }
}
//========Polymorphism Override (Run-Time Polimorphism)========//
// Question 1 of Run-Time Polimorphism (Overridng) 
class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine ("Aminal makes sound");
    }
}
class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Dog says Wooof!");
    }
}
// Question 2 of Run-Time Polimorphism (Overridng)
class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car Engine Started");
    }
}
// Question 3 of Run-Time Polimorphism (Overridng)
class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is Working");
    }
}
class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Designer is Writing Code");
    }
}
class Designer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Designer is creating a Design");
    }
}
// Question 4 of Run-Time Polimorphism (Overridng)
class Person
{
    public virtual void showInfo()
    {
        Console.WriteLine("This is a Person");
    }

}
class Student : Person
{
    public override void showInfo()
    {
        base.showInfo();
        Console.WriteLine("This is a Student");
    }
}
