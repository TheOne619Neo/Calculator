using System.Collections;
using Calculators;

namespace Exercise5Tests;

[TestFixture]
public class Exercise5Tests
{
    private SimpleCalculator Calculator { get; } = new();

    [QaVerification.Grading]
    // use the [TestCase] annotation here
    [TestCase(5,7,12)]
    [TestCase(2,-3,-1)]   //specifies input values from the get go
    public void ValuesBasedDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        var result = value1 + (value2);
        Assert.AreEqual(expected, result);
    }


    private static IEnumerable AdditionTestData()
    {   
            yield return new object[] { 1m, 1m, 2m };
            yield return new object[] { 1m, 2m, 3m };
            yield return new object[] { -1m, -2m, -3m };
       
    }

    [QaVerification.Grading]
    // use the [TestCaseSource] annotation here
     [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
            var result = value1 + value2;
            Assert.AreEqual(expected, result);
    }
}