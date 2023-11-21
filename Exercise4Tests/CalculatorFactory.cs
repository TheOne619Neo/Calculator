using Calculators;

namespace Exercise4Tests;

public class CalculatorFactory
{
    public SimpleCalculator CreateWithInitialStateOf(decimal initialState)
    {
        SimpleCalculator calculator = new SimpleCalculator();    //new object
        calculator.Enter(initialState);                          //value already entered 
        return calculator;
    }
}