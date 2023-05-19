using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new calculator and user interface.
        Calculator calculator = new Calculator();
        UserInterface ui = new UserInterface();

        // Display a welcome message.
        ui.DisplayMessage("Welcome to the calculator!");

        // Main loop.
        bool running = true;
        while (running)
        {
            // Get input from the user.
            double num1 = ui.GetDoubleFromUser("Enter the first number:");
            string op = ui.GetOperatorFromUser("Enter an operator (+, -, *, /, ^, %, sin, cos, tan):");
            double num2 = ui.GetDoubleFromUser("Enter the second number:");

            // Perform the calculation and display the result.
            double result = calculator.Calculate(num1, op, num2);

            // Loop for additional operations.
            bool continueCalculation = ui.GetYesNoFromUser("Would you like to do another operation for this equation? (yes/no):");
            while (continueCalculation)
            {
                num1 = result;
                op = ui.GetOperatorFromUser("Enter an operator (+, -, *, /, ^, %, sin, cos, tan):");
                num2 = ui.GetDoubleFromUser("Enter the next number:");
                result = calculator.Calculate(num1, op, num2);
                continueCalculation = ui.GetYesNoFromUser("Would you like to do another operation for this equation? (yes/no):");
            }

            ui.DisplayMessage($"The result is: {result}");

            // Ask the user if they want to perform another calculation.
            running = ui.GetYesNoFromUser("Would you like to perform another calculation? (yes/no):");
        }

        // Display a goodbye message.
        ui.DisplayMessage("Goodbye!");
    }
}
