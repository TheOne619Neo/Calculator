using Calculators;

namespace Exercise4Tests;

[QaVerification.Grading]
[TestFixture]
public class Exercise4Tests
{
    
    private CalculatorFactory calculatorFactory = new CalculatorFactory(); //private property
   
    [Test]
    public void AdditionTest()
    {
        // Arrange: Get a calculator from the factory with an initial value of 100.00
         SimpleCalculator calculator = calculatorFactory.CreateWithInitialStateOf(100);

        // Act: Perform the addition operation add 20.00
        var result = calculator.Plus(20).Equals();

        // Assert: Check the result
         Assert.That(result, Is.EqualTo(120));

    }

    [Test]
    public void SubtractionTest()
    {
        // Arrange: Get a calculator from the factory with an initial value of 10.00
         SimpleCalculator calculator = calculatorFactory.CreateWithInitialStateOf(10);

        // Act: Perform the subtraction operation minus 5.00
        var result = calculator.Minus(5).Equals();

        // Assert: Check the result
         Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void MultiplicationTest()
    {
        // Arrange: Get a calculator from the factory with an initial value of 25.00
         SimpleCalculator calculator = calculatorFactory.CreateWithInitialStateOf(25);

        // Act: Perform the multiplication operation, multiply by 4.00
        var result = calculator.MultiplyBy(4).Equals();

        // Assert: Check the result
         Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void DivisionTest()
    {
        // Arrange: Get a calculator from the factory with an initial value of 33.00
         SimpleCalculator calculator = calculatorFactory.CreateWithInitialStateOf(33);

        // Act: Perform the division operation, divise by 11.00
        var result = calculator.DivideBy(11).Equals();

        // Assert: Check the result
         Assert.That(result, Is.EqualTo(3));
    }
}