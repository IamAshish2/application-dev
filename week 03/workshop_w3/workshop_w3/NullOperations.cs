namespace workshop_w3;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string userName = null;
        Console.WriteLine(userName == null ? "UserName is not available." : userName);
        Console.WriteLine(userName ?? "UserName is not available.");

        userName ??= "Ashish Karki";
        Console.WriteLine($"Updated userName: {userName}");
    }
}