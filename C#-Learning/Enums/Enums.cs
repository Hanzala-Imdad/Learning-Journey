// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========Question 1 of Enums=========");
        Days today = Days.Monday;
        Console.WriteLine($"{today} is the day of the week.");

        Console.WriteLine("\n=========Question 2 of Enums=========");
        colour favoriteColor = colour.Blue;
        Console.WriteLine($"My favorite color is {favoriteColor}.");

        Console.WriteLine("\n=========Question 3 of Enums=========");
        status Status = status.Pending;
        if (Status == status.Approved)
        {
            Console.WriteLine($"The status of the request is {Status}.");
        }
        else if (Status == status.Pending)
        {
            Console.WriteLine($"The status of the request is {Status}.");
        }
        else
        {
            Console.WriteLine($"The status of the request is {Status}.");
        }
    }
}

        //===============ENUMS==============//
//Question 1 of Enums
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

//Question 2 of Enums
enum colour
{
    Red,
    Green,
    Blue,
    Yellow,
    Orange,
    Purple
}

//Question 3 of Enums
enum status
{
    Pending,
    Approved,
    Rejected,
}
