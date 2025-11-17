namespace task04;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Default Constructor: ");
        Player player = new Player();
        
        Console.WriteLine("Parameterized Constructor: ");
        Player player2 = new Player("Messi",20,100);
        Console.Write($"The player is {player2.playerName} with level {player2.level} and health {player2.health}.");
    }
}