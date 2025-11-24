namespace Task01;

public class Program
{
    public static void Main()
    {
        // Create object of BankAccount
        BankAccount account = new BankAccount("11910017503413", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Initial Balance: " + account.Balance);

        // Deposit money
        account.Deposit(1500);

        // Withdraw money
        account.Withdraw(2000);

        // Display remaining balance
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}