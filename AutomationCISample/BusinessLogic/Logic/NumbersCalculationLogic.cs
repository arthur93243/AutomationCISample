namespace BusinessLogic.Logic;

public class NumbersCalculationLogic : INumbersCalculationLogic
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int AddThree(int source)
    {
        return source + 3;
    }

    public bool IsEven(int source)
    {
        return source % 2 == 0;
    }

    public int AddOne(int source)
    {
        return source + 1 + 1;
    }
}
