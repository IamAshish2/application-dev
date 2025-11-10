namespace workshop_w3;

public class Program
{
    public static void Main()
    {
        Opeartors operators = new Opeartors();
        operators.OddEvenFinder(2);
        operators.Add(1, 2);
        operators.Subtract(50, 40);
        operators.Multiply(10, 20);
        operators.Divide(10, 20);


        NullOperations nullOperations = new NullOperations();
        nullOperations.PerformNullChecks();

        Console.WriteLine("Task 4: Conditionals");
        Conditional conditional = new Conditional();
        conditional.AgeCheck(20);

        DayChecker dayChecker = new DayChecker();
        Console.WriteLine("Please enter a day number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        dayChecker.CheckDay(input);


        LoopDay loop = new LoopDay();
        Console.WriteLine("Task 5: Loops");
        loop.SumTillN();

        ExceptionHandling exceptionHandling = new ExceptionHandling();
        Console.WriteLine("Task 6: ExceptionHandling");

        Console.WriteLine();
        Console.WriteLine("Checking user password:");
        exceptionHandling.CheckPassword();
        Console.WriteLine("Checking user Input: ");
        exceptionHandling.CheckUserInput();
    }
}