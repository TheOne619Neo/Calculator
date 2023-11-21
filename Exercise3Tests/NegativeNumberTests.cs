using Calculators;


namespace  Exercise3Tests;

[TestFixture]

public class NegativeNumberTests: BaseTest
{

    [Test]
    public void NegativeNumberTest()
    {
        // You can use the 'calculator' property here, which is inherited from BaseTest.
        var result = calculator.Minus(6).Equals();
        Assert.That(result, Is.EqualTo(-2));
    }


}