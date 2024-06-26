using Xunit;
using BusinessLogic.Logic;

public class NumbersCalculationLogicTest
{
    readonly NumbersCalculationLogic numbersCalculationLogic;

    public NumbersCalculationLogicTest()
    {
        numbersCalculationLogic = new();
    }

    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        var result = numbersCalculationLogic.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_ReturnsSumWhenNegativeNumbers()
    {
        var result = numbersCalculationLogic.Add(-2, -3);
        Assert.Equal(-5, result);
    }

    [Fact]
    public void AddThree_ReturnsNumberPlusThree()
    {
        var result = numbersCalculationLogic.AddThree(2);
        Assert.Equal(5, result);
    }

    [Fact]
    public void AddThree_ReturnsNumberPlusThreeWhenNegative()
    {
        var result = numbersCalculationLogic.AddThree(-2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void IsEven_ReturnsTrueWhenEven()
    {
        var result = numbersCalculationLogic.IsEven(2);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_ReturnsFalseWhenOdd()
    {
        var result = numbersCalculationLogic.IsEven(3);
        Assert.False(result);
    }
}