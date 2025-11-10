namespace workshop_w3;

public class LoopDay
{
    public void SumTillN()
    {
        Console.WriteLine("Please enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= input; i++)
        {
            sum += i;
        }
        Console.WriteLine($"The sum till {input} is {sum}.");

        int start = 1;
        int end = 20;
        
        while (start <= end)
        {
            if (start % 4 == 0)
            {
                start++;
                continue;
            }

            if (start == 15)
            {
                break;
            }
            
            Console.WriteLine(start);
            start++;
        }


        int[] array = { 1, 2, 3, 4, 5 };
        int sumOfArray = 0;
        foreach (var num in array)
        {
            sumOfArray += num;
        }
        
        Console.WriteLine($"The sum of all array is {sumOfArray}.");

    }
}