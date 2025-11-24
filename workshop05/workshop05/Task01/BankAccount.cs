public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property: AccountNumber (get only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property: Balance (get only, private set)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Balance cannot be zero or negative.");
                return;
            }
            balance = value;
        }
    }

    // Constructor
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;

        if (initialBalance <= 0)
        {
            Console.WriteLine("Initial balance must be greater than zero. Setting balance to 1.");
            this.balance = 1;
        }
        else
        {
            this.balance = initialBalance;
        }
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {balance}");
    }
}