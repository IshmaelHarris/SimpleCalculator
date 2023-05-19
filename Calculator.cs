using System;

class Calculator
{
    // This method performs a calculation and returns the result.
    public double Calculate(double num1, string op, double num2)
    {
        switch (op)
        {
            case "+":
                return Add(num1, num2);
            case "-":
                return Subtract(num1, num2);
            case "*":
                return Multiply(num1, num2);
            case "/":
                return Divide(num1, num2);
            case "^":
                return Power(num1, num2);
            case "%":
                return Modulus(num1, num2);
            case "sin":
                return Sin(num1);
            case "cos":
                return Cos(num1);
            case "tan":
                return Tan(num1);
            default:
                throw new ArgumentException($"Invalid operator: {op}");
        }
    }

    // These methods perform the individual operations.
    private double Add(double num1, double num2) => num1 + num2;
    private double Subtract(double num1, double num2) => num1 - num2;
    private double Multiply(double num1, double num2) => num1 * num2;
    private double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
    private double Power(double num1, double num2) => Math.Pow(num1, num2);
    private double Modulus(double num1, double num2) => num1 % num2;
    private double Sin(double num1) => Math.Sin(num1);
    private double Cos(double num1) => Math.Cos(num1);
    private double Tan(double num1) => Math.Tan(num1);
}
