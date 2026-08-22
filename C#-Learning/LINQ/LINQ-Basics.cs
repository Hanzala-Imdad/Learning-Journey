using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp;

public class Program
{
    public static void Main(string[] args)

    //QUESTION 1 - 4 USING (Where);

    // Question 1 — Even Numbers
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
            Console.WriteLine(number);
        }

    // Question 2 — Greater Than 50
        
        List<int> numbers = new List<int>()
        {
            20, 30, 40, 50, 60, 70, 80, 90,
        };

        var Bignum = numbers.Where(m => m > 50);

        foreach(var nums in Bignum)
        {
            Console.WriteLine(nums);
        }
        
    // Question 3 — Long Names
        
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

    // Question 4 — Age Filter

        List<int> age = new List<int>()
        {
            14, 15, 16, 17, 18, 19, 20, 21, 22,
        };

        var findAge = age.Where(Age => Age >= 18);

        foreach(var agee in findAge)
        {
            Console.WriteLine(agee);
        }

    // Question 1 — Double
        
        List<int> numb = new List<int>()
        {
            1, 2, 3, 4,
        };

        var DouBle = numb.Select(n => n * n).ToList();

        foreach(var number in DouBle)
        {
            Console.WriteLine(number);
        }
    }
}
