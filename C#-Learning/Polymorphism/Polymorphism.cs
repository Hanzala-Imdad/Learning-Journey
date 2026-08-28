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
        Console.WriteLine("==========Question-1 ===========");
        Calculator obj = new Calculator();
        obj.add(2, 3);
        obj.add(2, 3, 4);
        obj.add(2.5, 2.5);

        Console.WriteLine("==========Question-2 ==========");
        printer Obj = new printer();
        Obj.print("Hanzala");
        Obj.print(22);
        Obj.print("Hanzala", 22);

        Console.WriteLine("==========Question-3 ==========");
        Calculate OBJ = new Calculate();
        Console.WriteLine(OBJ.square(4));
        Console.WriteLine(OBJ.add(4));
        Console.WriteLine(OBJ.multiply(4, 2));

    }
}
// Question No: 2 of Compile-time Polymorphism
class printer
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

