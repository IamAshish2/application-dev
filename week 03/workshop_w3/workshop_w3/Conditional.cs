namespace workshop_w3;

public class Conditional
{
    public void AgeCheck(int age)
    {
        if (age < 13)
        {
            Console.WriteLine("You are a child.");
        }else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a teenager.");
        } else if (age >= 20)
        {
            Console.WriteLine("You are an adult.");
        }
    }
}