using Calculators;

namespace Exercise3Tests;

[QaVerification.Grading]
[TestFixture]
public class ArithmeticOperationsTests : BaseTest //inherit from baseTest class
{
    [Test]
    public void AdditionTest()
    {
        // You can use the 'calculator' property here, which is inherited from BaseTest.
        var result = calculator.Plus(2).Equals();
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void SubtractionTest()
    {
        var result = calculator.Minus(2).Equals();
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void MultiplicationTest()
    {
        var result = calculator.MultiplyBy(2).Equals();
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void DivisionTest()
    {
        var result = calculator.DivideBy(2).Equals();
        Assert.That(result, Is.EqualTo(2));
    }
}