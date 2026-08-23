using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp;

public class Program
{
    public static void Main(string[] args)

    //QUESTION 1 - 4 USING (Where);

    // Question 1 — Even Numbers (Using Where)
    {
        List<int> num = new List<int>();
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.Add(4);
        num.Add(5);
        num.Add(6);
        num.Add(7);
        num.Add(8);

        var even = num.Where(n => n%2 == 0 );

        foreach(var number in even){
            Console.WriteLine($"{number}");
        }

    // Question 2 — Greater Than 50  (Using Where)
        
        List<int> numbers = new List<int>()
        {
            20, 30, 40, 50, 60, 70, 80, 90,
        };

        var Bignum = numbers.Where(m => m > 50);

        foreach(var nums in Bignum)
        {
            Console.WriteLine(nums);
        }
        
    // Question 3 — Long Names (Using Where)
        
        List<string> names = new List<string>()
        {
            "Hanzala",
            "Ahmed",
            "Huzaifa",
            "Umer",
            "Farhan",
            "Ali",
            "Ajmal",
            "Osama",
        };
        
        var findName = names.Where(n => n.Length > 5);

        foreach(var name in findName)
        {
            Console.WriteLine(name);
        }

    // Question 4 — Age Filter (Using Where)

        List<int> age = new List<int>()
        {
            14, 15, 16, 17, 18, 19, 20, 21, 22,
        };

        var findAge = age.Where(Age => Age >= 18);

        foreach(var agee in findAge)
        {
            Console.WriteLine(agee);
        }

    // Question 1 — Double (Using Select)
        List<int> numb = new List<int>()
        {
            1, 2, 3, 4,
        };

        var DouBle = numb.Select(n => n * n).ToList();

        foreach(var number in DouBle)
        {
            Console.WriteLine(number);
        }

    // Question 2 — Name Length (Using Select)
    List<string> namesList = new List<string>()
    {
        "Hanzala", "Umer", "Ezaz"
    };
    var Name = namesList.Select(n => n.Length ).ToList();

    foreach(var NAME in Name)
        {
            Console.WriteLine(NAME);
        }
    
    // Question 3 — Person → Name
        List<Person> people = new List<Person>()
        {
            new Person("Hanzala", 22),
            new Person("Ahmed", 21),
            new Person("Umer", 23),
        };

        var personNames = people.Select(person => person.Name).ToList();

        foreach(var personName in personNames)
        {
            Console.WriteLine(personName);
        }
    
    // Question 4 — Person → Label
        var label = people.Select(person => $"{person.Name} - {person.Age} ").ToList();

        foreach(var peopleData in label)
        {
            Console.WriteLine(peopleData);
        }
    // Question 1 OrderBy() — Ascending
        List<OrderBY> Peoplee = new List<OrderBY>()
        {
           new OrderBY("Hanzala", 22, "Islamabad"),
           new OrderBY("Ali", 21, "Rawalpindi"),
           new OrderBY("Ahmed", 25, "Islamabad"),
           new OrderBY("Usman", 20, "Lahore"),
           new OrderBY("Bilal", 23, "Rawalpindi"),
           new OrderBY("Hamza", 26, "Lahore"),
           new OrderBY("Ahsan", 19, "Islamabad"),
           new OrderBY("Zain", 24, "Rawalpindi"),
        };
        var orderBy = Peoplee.OrderBy(p => p.aGE).ToList();

        foreach(var peoPle in orderBy)
        {
            Console.WriteLine($"{peoPle.nAME} - {peoPle.aGE} - {peoPle.city}");
        }
    // Question 2 OrderByDescending() — Descending
        var orderByDecending = Peoplee.OrderByDescending(p => p.aGE).ToList();
        
        foreach(var people_age in orderByDecending)
        {
            Console.WriteLine($"{people_age.nAME}-{people_age.aGE}-{people_age.city}");
        }

    // Question 1 — Count()
        List<int> Num =new List<int>()
        {
            40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90,
        };

        var count = Num.Count();
        Console.WriteLine($"count of Num is {count}");
    
    // Question 2 - Sum()
        var sum = Num.Sum();
        Console.WriteLine($"The total Sum of Num is {sum}");
    
    // Question 3 - average()
        var average = Num.Average();
        Console.WriteLine($"The average of Num is {average}");

    // Question 4 - Max()
        var max = Num.Max();
        Console.WriteLine($"Max number in given Num is {max}");

    // Question 5 - Min()
        var min = Num.Min();
        Console.WriteLine($"Min number in given Num is {min}");
       
       var first = Num.First(s => s > 20);
       Console.WriteLine(first);

       var firstOrDefault = Num.FirstOrDefault(s => s > 90);

       if (firstOrDefault != 0)
       {
           Console.WriteLine(firstOrDefault);
       }
      else
        {    
           Console.WriteLine("Not found");
        }

    } 
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person (string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
}

public class OrderBY
{
    public string nAME {get; set;}
    public int aGE {get; set;}
    public string city {get; set;}

    public OrderBY(string NAME, int AGE, string CITY)
    {
        nAME = NAME;
        aGE = AGE;
        city = CITY;
    }
}    
