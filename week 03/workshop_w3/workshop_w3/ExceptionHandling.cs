namespace workshop_w3;

public class ExceptionHandling
{
    public void CheckUserInput()
    {
        try
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid Number Format.");
        }
        finally
        {
            Console.WriteLine("Program Executed.");
        }
    }

    public void CheckPassword()
    {
        try
        {
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}