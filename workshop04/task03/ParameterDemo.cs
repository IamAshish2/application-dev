namespace task03;

public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullName)
    {
        fullName = "Ashish Karki";
    }

    public int SumAll(params int[] numbers)
    {
        return numbers.Sum(number => number);
    }
}