using Calculators;
using NUnit.Framework;

namespace Exercise2Tests;


[QaVerification.Grading]
[TestFixture]
public class Exercise1Tests
{
    private SimpleCalculator calculator = new SimpleCalculator();

    [SetUp]
     //setup is to prepare the correct starting state for a test.
    public void SetUp(){
        calculator.Enter(4);    
    }


    [TearDown]
    // teardown is to clear the state of the environment after a test.
    public void Teardown(){
        calculator.Reset();
    }

    [Test]
    public void AdditionTest()
    {
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