using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the first number from the user.
        double num1 = GetDoubleFromUser("Enter the first number:");

        // Get the operator from the user.
        string op = GetOperatorFromUser("Enter an operator (+, -, *, /):");

        // Get the second number from the user.
        double num2 = GetDoubleFromUser("Enter the second number:");

        // Perform the operation specified by the user and print the result.
        switch (op)
        {
            case "+":
                Console.WriteLine(num1 + num2);
                break;
            case "-":
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }

    // This method prompts the user for a double.
    // It keeps asking until the user enters a valid double.
    static double GetDoubleFromUser(string prompt)
    {
        double result;
        Console.WriteLine(prompt);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return result;
    }

    // This method prompts the user for an operator.
    // It keeps asking until the user enters a valid operator (+, -, *, or /).
    static string GetOperatorFromUser(string prompt)
    {
        string result;
        Console.WriteLine(prompt);
        result = Console.ReadLine();
        while (result != "+" && result != "-" && result != "*" && result != "/")
        {
            Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
            result = Console.ReadLine();
        }
        return result;
    }
}
