using System;

namespace Calculator;

public class CalculatorCode
{
    private double A { get; }
    private double B { get; }
    private char Operation { get; }

    public CalculatorCode(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Execute()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B != 0 ? A / B : throw new DivideByZeroException("Cannot divide by zero."),
            _   => throw new InvalidOperationException($"Invalid operation: {Operation}")
        };
    }
}