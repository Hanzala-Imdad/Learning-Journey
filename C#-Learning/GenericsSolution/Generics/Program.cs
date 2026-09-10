//Question:1 of Generics
class Box<T>
{
    public T Value { get; set; }
}
//Question:2 of Generics
class Container<T>
{
    public T Data { get; set; }
}

//Question:3 of Generics
class student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class box1<student>
{
    public student Value { get; set; }
}
class Program { 
    static void Main(string[] args)
    {
        Console.WriteLine("===========Question:1 of Generics===========");
        Box<int> box = new Box<int>();
         box.Value = 100;

        Box<string> box2 = new Box<string>();
        box2.Value = "Hello World";

        Console.WriteLine(box2.Value);
        Console.WriteLine(box.Value);

        Console.WriteLine("\n===========Question:2 of Generics===========");
        Container<double> container = new Container<double>();
        container.Data = 3.14;

        Container<bool> container2 = new Container<bool>();
        container2.Data = true;

        Console.WriteLine(container.Data);
        Console.WriteLine(container2.Data);

        Console.WriteLine("\n===========Question:3 of Generics===========");
        box1<student> box3 = new box1<student>();
        box3.Value = new student { Name = "John", Age = 20 };
        Console.WriteLine($"Name: {box3.Value.Name}\nAge: {box3.Value.Age}");
    }
}