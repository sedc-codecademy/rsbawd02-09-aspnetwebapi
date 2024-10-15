namespace Services.Tests;

[TestClass]
public class RandomServiceTest
{
    private readonly RandomService _randomService;
    
    public RandomServiceTest()
    {
        _randomService = new RandomService();
    }

    // MethodName_StateUnderTest_ExpectedBehavior

    [TestMethod]
    public void Sum_BothNumberAreValid_PositiveResultNumber()
    {
        // Arrange
        int number1 = 10;
        int number2 = 20;

        int expectedResult = 30;
        
        // Act
        int? result = _randomService.Sum(number1, number2);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void Sum_LargeIntegerNumbers_NULL()
    {
        // Arrange
        int number1 = 2111111111;
        int number2 = 2111111111;

        // Act
        int? result = _randomService.Sum(number1, number2);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Sum_NormalIntegerNumbers_NOT_NULL()
    {
        // Arrange
        int number1 = 50;
        int number2 = 100;

        // Act
        int? result = _randomService.Sum(number1, number2);

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void IsFirstNumberLarger_FirstNumberIsLarger_TRUE()
    {
        // Arrange
        int num1 = 25;
        int num2 = 10;

        // Act
        bool result = _randomService.IsFirstNumberLarger(num1, num2);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsFirstNumberLarger_SecondNumberIsLarger_FALSE()
    {
        // Arrange
        int num1 = 50;
        int num2 = 50;

        // Act
        bool result = _randomService.IsFirstNumberLarger(num1, num2);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void GetDigitName_DoubleDigit_Exception()
    {
        // Arrange
        int position = 12;

        // Act
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => 
        _randomService.GetDigitName(position));
    }

    [TestMethod]
    public void GetDigitName_Pass5_Five()
    {
        int position = 5;

        string expectedResult = "Five";

        string result = _randomService.GetDigitName(position);

        Assert.AreEqual(expectedResult, result);
    }
}
