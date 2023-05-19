using System;

class UserInterface
{
    // This method displays a message to the user.
    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    // This method gets a double from the user.
    public double GetDoubleFromUser(string prompt)
    {
        double result;
        Console.WriteLine(prompt);
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return result;
    }

    // This method gets an operator from the user.
    public string GetOperatorFromUser(string prompt)
    {
        string result;
        Console.WriteLine(prompt);
        result = Console.ReadLine();
        while (result != "+" && result != "-" && result != "*" && result != "/" && result != "^" && result != "%" && result != "sin" && result != "cos" && result != "tan")
        {
            Console.WriteLine("Invalid operator. Please enter +, -, *, /, ^, %, sin, cos, or tan.");
            result = Console.ReadLine();
        }
        return result;
    }

    // This method gets a yes/no answer from the user.
    public bool GetYesNoFromUser(string prompt)
    {
        string result;
        Console.WriteLine(prompt);
        result = Console.ReadLine().ToLower();
        while (result != "yes" && result != "no")
        {
            Console.WriteLine("Invalid input. Please enter yes or no.");
            result = Console.ReadLine().ToLower();
        }
        return result == "yes";
    }
}
