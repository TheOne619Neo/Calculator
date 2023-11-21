using Calculators;


namespace  Exercise3Tests;
//presence of the [TestFixture] attribute signals to the NUnit test runner that the class contains test methods.
// When you run your tests using an NUnit test runner, it scans your code for classes marked with [TestFixture] 
//and executes the test methods within those classes.
[TestFixture]

public class BaseTest
{
    
    protected SimpleCalculator calculator = new SimpleCalculator();

    [SetUp]
     //setup is to prepare the correct starting state for a test.
    public void SetUp(){
        calculator.Enter(4); 
        TestContext.Progress.WriteLine("Setup method in BaseTest class invoked.");   
    }


    [TearDown]
    // teardown is to clear the state of the environment after a test.
    public void Teardown(){
        calculator.Reset();
        TestContext.Progress.WriteLine("Teardown method in BaseTest class invoked.");
    }
}