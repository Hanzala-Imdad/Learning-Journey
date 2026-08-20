class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    static void Main(string[] args)
    {
        List<Person> person = new List<Person>();

        person.Add(new Person("Hanzala", 22));
        person.Add(new Person("Ali", 21));
        person.Add(new Person("Ahmed", 23));

        foreach (var personn in person)
        {
            Console.WriteLine($"{personn.Name} - {personn.Age}");
        }
    }
}