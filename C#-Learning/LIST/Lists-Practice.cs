namespace ConsoleApp1;

public class LISTS
{
       static void Main(string[] args)
        {
            Question1();
            Question2();
            Question3();
            Question4();
            Question5();
        }
        
       // Question 1 of List Practice
    static void Question1()
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        
     foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }   
    }
       // Question 2 of List Practice
    static void Question2()
    {
        List<string> names = new List<string>();
        names.Add("Hanzala");
        names.Add("Ali");
        names.Add("Ahmed");
         // Remove "Ali" from the list
        names.Remove("Ali");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
       // Question 3 of List Practice
    static void Question3()
    {
        List<string> fruits= new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");
        
        // Remove Index 1 from the list
        fruits.RemoveAt(1);
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);   
        }
    }
       // Question 4 of List Practice
    static void Question4()
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        Console.WriteLine("Enter the fruit you want to search for:");
        string searchFruit = Console.ReadLine();

        Console.WriteLine(fruits.Contains(searchFruit) ? $"{searchFruit} is in the list." : $"{searchFruit} is not in the list.");

    }
       // Question 5 of List Practice
    static void Question5()
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Cherry");

        Console.WriteLine("Enter the fruit you want to search Index for:");
        string searchFruit = Console.ReadLine();

        var index = fruits.IndexOf(searchFruit);

        Console.WriteLine(searchFruit + " is at index " + index);
        
    }
}

