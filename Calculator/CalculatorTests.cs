using System;
using NUnit.Framework;

namespace Calculator;

public class CalculatorTests
{
    [Test]
    public void TestAddition()
    {
        var calc = new CalculatorCode(5, 3, '+');
        Assert.That(calc.Execute(), Is.EqualTo(8));
    }

    [Test]
    public void TestSubtraction()
    {
        var calc = new CalculatorCode(10, 4, '-');
        Assert.That(calc.Execute(), Is.EqualTo(6));
    }

    [Test]
    public void TestMultiplication()
    {
        var calc = new CalculatorCode(6, 7, '*');
        Assert.That(calc.Execute(), Is.EqualTo(42));
    }

    [Test]
    public void TestDivision()
    {
        var calc = new CalculatorCode(20, 5, '/');
        Assert.That(calc.Execute(), Is.EqualTo(4));
    }

    [Test]
    public void TestDivisionByZero()
    {
        var calc = new CalculatorCode(10, 0, '/');
        Assert.Throws<DivideByZeroException>(() => calc.Execute());
    }

    [Test]
    public void TestInvalidOperation()
    {
        var calc = new CalculatorCode(2, 3, '%');
        Assert.Throws<InvalidOperationException>(() => calc.Execute());
    }
}