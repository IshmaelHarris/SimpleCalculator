using System;

class CalculatorTests
{
    // This method runs all the tests.
    public void RunAllTests()
    {
        TestAdd();
        TestSubtract();
        TestMultiply();
        TestDivide();
        TestPower();
        TestModulus();
        TestSin();
        TestCos();
        TestTan();
    }

    // These methods test the individual operations.
    private void TestAdd()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(1, "+", 1);
        if (result != 2)
        {
            throw new Exception("Add test failed.");
        }
    }

    private void TestSubtract()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(3, "-", 1);
        if (result != 2)
        {
            throw new Exception("Subtract test failed.");
        }
    }

    private void TestMultiply()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(2, "*", 3);
        if (result != 6)
        {
            throw new Exception("Multiply test failed.");
        }
    }

    private void TestDivide()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(10, "/", 2);
        if (result != 5)
        {
            throw new Exception("Divide test failed.");
        }
    }

    private void TestPower()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(2, "^", 3);
        if (result != 8)
        {
            throw new Exception("Power test failed.");
        }
    }

    private void TestModulus()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(10, "%", 3);
        if (result != 1)
        {
            throw new Exception("Modulus test failed.");
        }
    }

    private void TestSin()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(Math.PI / 2, "sin", 0);
        if (Math.Abs(result - 1) > 0.0001)
        {
            throw new Exception("Sin test failed.");
        }
    }

    private void TestCos()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(Math.PI, "cos", 0);
        if (Math.Abs(result + 1) > 0.0001)
        {
            throw new Exception("Cos test failed.");
        }
    }

    private void TestTan()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(Math.PI / 4, "tan", 0);
        if (Math.Abs(result - 1) > 0.0001)
        {
            throw new Exception("Tan test failed.");
        }
    }
}
