namespace ConsoleApp1;

public class Class1
{
    
    static void Main(string[] args)
    {
        //Question 1 of Dictionary<>
        Dictionary<string, int> Grades = new Dictionary<string, int>();

        Grades.Add("Hanzala", 94);
        Grades.Add("Ahmed", 96);
        Grades.Add("Umer", 92);

        Console.WriteLine($"Grades of Hanzala is " +Grades["Hanzala"]);

        //Question 2 of Dictionary<>
        Dictionary<string, int> age = new Dictionary<string, int>();

        age.Add("Hanzala", 22);
        age.Add("Ahmed", 21);
        age.Add("Umer", 23);

        Console.WriteLine("Enter the Name to see Age");
        string Name = Console.ReadLine();

        if (age.ContainsKey(Name))
       {
          Console.WriteLine("The Age of the " + Name + " is " + age[Name]);
       }
       else
        {
            Console.WriteLine("User not Found");
        }

        //Question 3 of Dictionary<>
        Dictionary<string, int> Prices = new Dictionary<string, int>();

        Prices.Add("Laptop", 88000);
        Prices.Add("Mobile", 56000);
        Prices.Add("MacBook", 190000);

        Console.WriteLine("Entre the name of Product");
        string Product = Console.ReadLine();

       if(Prices.TryGetValue(Product, out int price))
        {
            Console.WriteLine(price);
        }
        else
        {
            Console.WriteLine("Your Searching Product is Not Available");
        }
        

    }
}
