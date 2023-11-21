using Calculators;

namespace Exercise6Tests;

[QaVerification.Grading]
public class NegativeTestScenarios
{
    private readonly SimpleCalculator _calculator = new();
    
    public void OverflowAddition(){

        Assert.Throws<OverflowException>(()=> _calculator.Plus(decimal.MaxValue));
    }

}