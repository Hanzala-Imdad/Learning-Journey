// See https://aka.ms/new-console-template for more information
class Program
{
    //      ===============Exception Handling================
    
    static void Main(string[] args)
    {
        //Question: 1 of Exeption Handling
        Console.WriteLine("=====Question 1 of Exception Handling=====");
        Console.WriteLine("Enter a 1st Number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a 2nd Number");
        int num2 = int.Parse(Console.ReadLine());

        try
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero ");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine(num1 / num2);

        //Question: 2 of Exeption Handling
        Console.WriteLine("\n=====Question 2 of Exception Handling=====");
        Console.WriteLine("Enter your Age");
        try
        {

            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Age is: " + age);

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for age.");
            Console.WriteLine(ex.Message);
        }

        //Question: 3 of Exeption Handling
        Console.WriteLine("\n=====Question 3 of Exception Handling=====");
        
        try
        {
        Console.WriteLine("Enter a Number1 to divide");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a Number2 to divide");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Result: " + (number1 / number2));

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        //Question: 4 of Exeption Handling
        Console.WriteLine("\n=====Question 4 of Exception Handling=====");
        Console.WriteLine("Enter Your Balance");
        double balance = 0;
        try
        {
            balance = double.Parse(Console.ReadLine());
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be negative");
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for balance.");
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Your Balance is: " + balance);
        Console.WriteLine("Enter Your Withdraw Amount");
        try
        {
            double withdrawAmount = double.Parse(Console.ReadLine());
            if (withdrawAmount > balance)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal.");
            }
            balance -= withdrawAmount;
            Console.WriteLine("Withdrawal successful. New balance: " + balance);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for withdrawal amount.");
            Console.WriteLine(ex.Message);
        }
    }
}
